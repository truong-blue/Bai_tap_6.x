using System;
using System.Data;
using MySql.Data.MySqlClient;
using Bai6._5.DTO;

namespace Bai6._5.DAL
{
    public class KaraokeDAL : DatabaseAccess
    {
        // 1. Quản lý Danh mục Phòng & Dịch vụ
        public DataTable GetListPhongHat() => ExecuteQuery("SELECT * FROM PhongHat");
        public DataTable GetListDichVu() => ExecuteQuery("SELECT * FROM DichVu");

        // 2. Nghiệp vụ Mở phòng hát
        public bool MoPhongHat(int maPhong)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Đổi trạng thái phòng sang 'Đang hát'
                    string q1 = "UPDATE PhongHat SET TrangThai = 'Đang hát' WHERE MaPhong = @MaPhong";
                    MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);
                    cmd1.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd1.ExecuteNonQuery();

                    // Tạo Hóa đơn mới ghi nhận GioVao
                    string q2 = "INSERT INTO HoaDon (MaPhong, GioVao, TrangThai) VALUES (@MaPhong, NOW(), 0)";
                    MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);
                    cmd2.Parameters.AddWithValue("@MaPhong", maPhong);
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

        // 3. Lấy thông tin Hóa đơn hiện tại của phòng đang hát
        public DataTable GetHoaDonHienTaiByMaPhong(int maPhong)
        {
            string query = "SELECT * FROM HoaDon WHERE MaPhong = @MaPhong AND TrangThai = 0 LIMIT 1";
            MySqlParameter[] p = { new MySqlParameter("@MaPhong", maPhong) };
            return ExecuteQuery(query, p);
        }

        // 4. Lấy danh sách Dịch vụ đã gọi của Hóa đơn (Disconnected Model)
        public DataTable GetChiTietDichVuByMaHD(int maHD)
        {
            string query = @"SELECT ct.MaHD, ct.MaDV, dv.TenDV, ct.SoLuong, ct.DonGia, (ct.SoLuong * ct.DonGia) AS ThanhTien
                             FROM ChiTietDichVu ct JOIN DichVu dv ON ct.MaDV = dv.MaDV
                             WHERE ct.MaHD = @MaHD";
            MySqlParameter[] p = { new MySqlParameter("@MaHD", maHD) };
            return ExecuteQuery(query, p);
        }

        // 5. Thêm/Cập nhật Dịch vụ cho phòng
        public bool ThemDichVuVaoHoaDon(int maHD, int maDV, int soLuong, decimal donGia)
        {
            string query = @"INSERT INTO ChiTietDichVu (MaHD, MaDV, SoLuong, DonGia) 
                             VALUES (@MaHD, @MaDV, @SoLuong, @DonGia)
                             ON DUPLICATE KEY UPDATE SoLuong = SoLuong + @SoLuong";
            MySqlParameter[] p = {
                new MySqlParameter("@MaHD", maHD),
                new MySqlParameter("@MaDV", maDV),
                new MySqlParameter("@SoLuong", soLuong),
                new MySqlParameter("@DonGia", donGia)
            };
            return ExecuteNonQuery(query, p) > 0;
        }

        // 6. THỰC THI MYSQL TRANSACTION: TÍNH GIỜ & THANH TOÁN HÓA ĐƠN
        public bool ThanhToanHoaDonTransaction(int maHD, int maPhong, out decimal tongTienPhong, out decimal tongTienDV, out string errorMessage)
        {
            tongTienPhong = 0;
            tongTienDV = 0;
            errorMessage = "";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Lấy GioVao và Giá phòng theo giờ
                    string q1 = @"SELECT hd.GioVao, p.GiaTheoGio 
                                 FROM HoaDon hd JOIN PhongHat p ON hd.MaPhong = p.MaPhong 
                                 WHERE hd.MaHD = @MaHD";
                    MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);
                    cmd1.Parameters.AddWithValue("@MaHD", maHD);

                    DateTime gioVao = DateTime.Now;
                    decimal giaTheoGio = 0;
                    using (MySqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            gioVao = Convert.ToDateTime(reader["GioVao"]);
                            giaTheoGio = Convert.ToDecimal(reader["GiaTheoGio"]);
                        }
                    }

                    // Tính tổng số giờ hát (làm tròn lên theo phút)
                    DateTime gioRa = DateTime.Now;
                    TimeSpan thoiGianHat = gioRa - gioVao;
                    double soGio = Math.Max(0.5, thoiGianHat.TotalHours); // Tối thiểu tính 0.5h
                    tongTienPhong = (decimal)soGio * giaTheoGio;

                    // Tính tổng tiền dịch vụ và kiểm tra tồn kho
                    string q2 = "SELECT MaDV, SoLuong, DonGia FROM ChiTietDichVu WHERE MaHD = @MaHD";
                    MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);
                    cmd2.Parameters.AddWithValue("@MaHD", maHD);

                    DataTable dtCT = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                    da.Fill(dtCT);

                    foreach (DataRow row in dtCT.Rows)
                    {
                        int maDV = Convert.ToInt32(row["MaDV"]);
                        int soLuong = Convert.ToInt32(row["SoLuong"]);
                        decimal donGia = Convert.ToDecimal(row["DonGia"]);

                        tongTienDV += (soLuong * donGia);

                        // Kiểm tra kho
                        string qCheck = "SELECT TonKho, TenDV FROM DichVu WHERE MaDV = @MaDV";
                        MySqlCommand cmdCheck = new MySqlCommand(qCheck, conn, trans);
                        cmdCheck.Parameters.AddWithValue("@MaDV", maDV);

                        using (MySqlDataReader rDV = cmdCheck.ExecuteReader())
                        {
                            if (rDV.Read())
                            {
                                int ton = Convert.ToInt32(rDV["TonKho"]);
                                string tenDV = rDV["TenDV"].ToString();
                                if (ton < soLuong)
                                {
                                    trans.Rollback();
                                    errorMessage = $"Dịch vụ [{tenDV}] không đủ số lượng tồn kho! (Tồn: {ton}, Cần: {soLuong})";
                                    return false;
                                }
                            }
                        }

                        // Trừ tồn kho
                        string qTru = "UPDATE DichVu SET TonKho = TonKho - @SoLuong WHERE MaDV = @MaDV";
                        MySqlCommand cmdTru = new MySqlCommand(qTru, conn, trans);
                        cmdTru.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmdTru.Parameters.AddWithValue("@MaDV", maDV);
                        cmdTru.ExecuteNonQuery();
                    }

                    // Cập nhật Hóa đơn (GioRa, TongTienPhong, TongTienDichVu, TrangThai = 1)
                    string q3 = @"UPDATE HoaDon 
                                 SET GioRa = NOW(), TongTienPhong = @TienPhong, TongTienDichVu = @TienDV, TrangThai = 1 
                                 WHERE MaHD = @MaHD";
                    MySqlCommand cmd3 = new MySqlCommand(q3, conn, trans);
                    cmd3.Parameters.AddWithValue("@TienPhong", tongTienPhong);
                    cmd3.Parameters.AddWithValue("@TienDV", tongTienDV);
                    cmd3.Parameters.AddWithValue("@MaHD", maHD);
                    cmd3.ExecuteNonQuery();

                    // Cập nhật Trạng thái phòng về 'Trống'
                    string q4 = "UPDATE PhongHat SET TrangThai = 'Trống' WHERE MaPhong = @MaPhong";
                    MySqlCommand cmd4 = new MySqlCommand(q4, conn, trans);
                    cmd4.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd4.ExecuteNonQuery();

                    trans.Commit();
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
    }
}