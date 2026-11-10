using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Bai6._4.DTO;

namespace Bai6._4.DAL
{
    public class GarageDAL : DatabaseAccess
    {
        // 1. Tiếp nhận Xe & Tra cứu Biển số bằng SqlParameter
        public DataTable SearchXeByBienSo(string bienSo)
        {
            string query = @"SELECT x.BienSo, x.HieuXe, x.NamSanXuat, kh.MaKH, kh.TenKH, kh.DienThoai, kh.DiaChi
                             FROM Xe x JOIN KhachHang kh ON x.MaKH = kh.MaKH
                             WHERE x.BienSo LIKE @BienSo";
            MySqlParameter[] p = { new MySqlParameter("@BienSo", "%" + bienSo + "%") };
            return ExecuteQuery(query, p);
        }

        public bool TiepNhanXeMoi(KhachHangDTO kh, XeDTO xe)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Chèn Khách hàng
                    string q1 = "INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) VALUES (@TenKH, @Sdt, @DiaChi); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);
                    cmd1.Parameters.AddWithValue("@TenKH", kh.TenKH);
                    cmd1.Parameters.AddWithValue("@Sdt", kh.DienThoai);
                    cmd1.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                    int maKH = Convert.ToInt32(cmd1.ExecuteScalar());

                    // Chèn Xe
                    string q2 = "INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat) VALUES (@BienSo, @MaKH, @HieuXe, @NamSanXuat)";
                    MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);
                    cmd2.Parameters.AddWithValue("@BienSo", xe.BienSo);
                    cmd2.Parameters.AddWithValue("@MaKH", maKH);
                    cmd2.Parameters.AddWithValue("@HieuXe", xe.HieuXe);
                    cmd2.Parameters.AddWithValue("@NamSanXuat", xe.NamSanXuat);
                    cmd2.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

        // 2. Danh mục Phụ tùng
        public DataTable GetListPhuTung() => ExecuteQuery("SELECT * FROM PhuTung");

        public bool UpdatePhuTung(PhuTungDTO pt)
        {
            string query = "UPDATE PhuTung SET DonGia = @DonGia, SoLuongTon = @SoLuongTon WHERE MaPhuTung = @MaPT";
            MySqlParameter[] p = {
                new MySqlParameter("@DonGia", pt.DonGia),
                new MySqlParameter("@SoLuongTon", pt.SoLuongTon),
                new MySqlParameter("@MaPT", pt.MaPhuTung)
            };
            return ExecuteNonQuery(query, p) > 0;
        }

        // 3. THỰC THI MYSQL TRANSACTION: LẬP PHIẾU SỬA CHỮA & TRỪ PHỤ TÙNG
        public bool LapPhieuSuaChuaTransaction(string bienSo, string noiDung, List<ChiTietSuaChuaDTO> listChiTiet, out string errorMessage)
        {
            errorMessage = "";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // BƯỚC 1: Kiểm tra tồn kho trước khi thực hiện giao dịch
                    foreach (var ct in listChiTiet)
                    {
                        string qCheck = "SELECT SoLuongTon FROM PhuTung WHERE MaPhuTung = @MaPT";
                        MySqlCommand cmdCheck = new MySqlCommand(qCheck, conn, trans);
                        cmdCheck.Parameters.AddWithValue("@MaPT", ct.MaPhuTung);

                        object res = cmdCheck.ExecuteScalar();
                        int tonHienTai = (res != null) ? Convert.ToInt32(res) : 0;

                        if (tonHienTai < ct.SoLuong)
                        {
                            trans.Rollback(); // ROLLBACK khi phụ tùng không đủ số lượng
                            errorMessage = $"Phụ tùng [{ct.TenPhuTung}] không đủ số lượng tồn kho! (Tồn: {tonHienTai}, Cần: {ct.SoLuong})";
                            return false;
                        }
                    }

                    // BƯỚC 2: Tính tổng tiền phiếu sửa chữa
                    decimal tongTien = 0;
                    foreach (var ct in listChiTiet) tongTien += ct.ThanhTien;

                    // BƯỚC 3: Tạo bản ghi PhieuSuaChua
                    string q1 = "INSERT INTO PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai) VALUES (@BienSo, NOW(), @NoiDung, @TongTien, 'Đang sửa'); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);
                    cmd1.Parameters.AddWithValue("@BienSo", bienSo);
                    cmd1.Parameters.AddWithValue("@NoiDung", noiDung);
                    cmd1.Parameters.AddWithValue("@TongTien", tongTien);
                    int maPhieu = Convert.ToInt32(cmd1.ExecuteScalar());

                    // BƯỚC 4: Tạo ChiTietSuaChua và Trừ SoLuongTon trong PhuTung
                    foreach (var ct in listChiTiet)
                    {
                        string q2 = "INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong) VALUES (@MaPhieu, @MaPT, @SoLuong, @TienCong)";
                        MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);
                        cmd2.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmd2.Parameters.AddWithValue("@MaPT", ct.MaPhuTung);
                        cmd2.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                        cmd2.Parameters.AddWithValue("@TienCong", ct.TienCong);
                        cmd2.ExecuteNonQuery();

                        string q3 = "UPDATE PhuTung SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaPhuTung = @MaPT";
                        MySqlCommand cmd3 = new MySqlCommand(q3, conn, trans);
                        cmd3.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                        cmd3.Parameters.AddWithValue("@MaPT", ct.MaPhuTung);
                        cmd3.ExecuteNonQuery();
                    }

                    trans.Commit(); // Gọi Commit khi hoàn tất thành công
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }

        // 4. Thanh toán & Xuất hóa đơn
        public DataTable GetListPhieuSuaChua()
        {
            string query = @"SELECT p.MaPhieu, p.BienSo, x.HieuXe, kh.TenKH, p.NgayNhan, p.NoiDungSua, p.TongTien, p.TrangThai
                             FROM PhieuSuaChua p
                             JOIN Xe x ON p.BienSo = x.BienSo
                             JOIN KhachHang kh ON x.MaKH = kh.MaKH
                             ORDER BY p.MaPhieu DESC";
            return ExecuteQuery(query);
        }

        public bool ThanhToanPhieu(int maPhieu)
        {
            string query = "UPDATE PhieuSuaChua SET TrangThai = 'Đã thanh toán' WHERE MaPhieu = @MaPhieu";
            MySqlParameter[] p = { new MySqlParameter("@MaPhieu", maPhieu) };
            return ExecuteNonQuery(query, p) > 0;
        }
    }
}