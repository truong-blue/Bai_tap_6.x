using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Bai6._4.BUS;
using Bai6._4.DTO;

namespace Bai6._4
{
    public partial class Form1 : Form
    {
        private GarageBUS bus = new GarageBUS();
        private List<ChiTietSuaChuaDTO> listChiTiet = new List<ChiTietSuaChuaDTO>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ GARAGE VÀ BẢO BƯỠNG XE Ô TÔ (GARAGE MANAGEMENT SYSTEM)";

            LoadAllData();
        }

        private void LoadAllData()
        {
            try
            {
                DataTable dtXe = bus.SearchXeByBienSo("");
                dgvDanhSachXe.DataSource = dtXe; 
                if (dgvDanhSachXe != null) dgvDanhSachXe.DataSource = dtXe;

                DataTable dtPhuTung = bus.GetListPhuTung();
                dgvPhuTung.DataSource = dtPhuTung;
                comboBox1.DataSource = dtPhuTung;
                comboBox1.DisplayMember = "TenPhuTung";
                comboBox1.ValueMember = "MaPhuTung";
                dgvPhieuSuaChua.DataSource = bus.GetListPhieuSuaChua();
                if (dgvPhieuSuaChua.Columns["TongTien"] != null)
                {
                    dgvPhieuSuaChua.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL GarageDB: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= TAB 1: TIẾP NHẬN XE & CHỦ XE (CRUD) =================
        private void btnSearchXe_Click(object sender, EventArgs e)
        {
            DataTable dt = bus.SearchXeByBienSo(txtSearchBienSo.Text.Trim());
            dgvDanhSachXe.DataSource = dt;
            if (dgvDanhSachXe != null) dgvDanhSachXe.DataSource = dt;
        }

        private void btnTiepNhanXe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBienSoMoi.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Biển số xe, Tên chủ xe và Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHangDTO kh = new KhachHangDTO
            {
                TenKH = txtTenKH.Text.Trim(),
                DienThoai = txtSdt.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            XeDTO xe = new XeDTO
            {
                BienSo = txtBienSoMoi.Text.Trim().ToUpper(),
                HieuXe = txtHieuXe.Text.Trim(),
                NamSanXuat = string.IsNullOrWhiteSpace(txtNamSX.Text) ? DateTime.Now.Year : Convert.ToInt32(txtNamSX.Text)
            };

            if (bus.TiepNhanXeMoi(kh, xe))
            {
                MessageBox.Show("Tiếp nhận xe mới và đăng ký Chủ xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Tiếp nhận xe thất bại! (Biển số xe hoặc SĐT đã tồn tại)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatPhuTung_Click(object sender, EventArgs e)
        {
            if (dgvPhuTung.CurrentRow == null) return;
            int maPT = Convert.ToInt32(dgvPhuTung.CurrentRow.Cells["MaPhuTung"].Value);
            decimal donGia = Convert.ToDecimal(dgvPhuTung.CurrentRow.Cells["DonGia"].Value);
            int ton = Convert.ToInt32(dgvPhuTung.CurrentRow.Cells["SoLuongTon"].Value);

            PhuTungDTO pt = new PhuTungDTO { MaPhuTung = maPT, DonGia = donGia, SoLuongTon = ton };
            if (bus.UpdatePhuTung(pt))
            {
                MessageBox.Show("Cập nhật đơn giá và số lượng tồn kho phụ tùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllData();
            }
        }

        // ================= TAB 2: LẬP PHIẾU SỬA CHỮA (MYSQL TRANSACTION) =================
        private void btnThemPhuTungItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;
            DataRowView row = comboBox1.SelectedItem as DataRowView;
            if (row == null) return;

            int maPT = Convert.ToInt32(row["MaPhuTung"]);
            string tenPT = row["TenPhuTung"].ToString();
            decimal donGia = Convert.ToDecimal(row["DonGia"]);
            int soLuong = (int)numericUpDown1.Value;
            decimal tienCong = numericUpDown2.Value;

            var item = listChiTiet.Find(x => x.MaPhuTung == maPT);
            if (item != null)
            {
                item.SoLuong += soLuong;
                item.TienCong += tienCong;
            }
            else
            {
                listChiTiet.Add(new ChiTietSuaChuaDTO
                {
                    MaPhuTung = maPT,
                    TenPhuTung = tenPT,
                    DonGia = donGia,
                    SoLuong = soLuong,
                    TienCong = tienCong
                });
            }

            BindChiTietGrid();
        }

        private void BindChiTietGrid()
        {
            dgvChiTietPhieu.DataSource = null;
            dgvChiTietPhieu.DataSource = listChiTiet;

            decimal tong = 0;
            foreach (var item in listChiTiet) tong += item.ThanhTien;
            lblTongTienPhieu.Text = $"Tổng tiền phiếu: {tong:N0} VNĐ";
        }

        private void btnXacNhanLapPhieu_Click(object sender, EventArgs e)
        {
            string bienSo = textBox1.Text.Trim(); 
            string noiDung = textBox2.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(bienSo))
            {
                MessageBox.Show("Vui lòng nhập Biển số xe cần lập phiếu sửa chữa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error = "";
            bool ok = bus.LapPhieuSuaChua(bienSo, noiDung, listChiTiet, out error);

            if (ok)
            {
                MessageBox.Show("Lập phiếu sửa chữa thành công!\nĐã tự động trừ phụ tùng trong kho và lưu bản ghi sửa chữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listChiTiet.Clear();
                BindChiTietGrid();
                textBox1.Clear();
                textBox2.Clear();
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Lập phiếu sửa chữa thất bại (Rollback Transaction)!\nChi tiết: " + error, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= TAB 3: THANH TOÁN & XUẤT HÓA ĐƠN =================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvPhieuSuaChua.CurrentRow == null) return;
            int maPhieu = Convert.ToInt32(dgvPhieuSuaChua.CurrentRow.Cells["MaPhieu"].Value);
            string trangThai = dgvPhieuSuaChua.CurrentRow.Cells["TrangThai"].Value.ToString();

            if (trangThai == "Đã thanh toán")
            {
                MessageBox.Show("Phiếu sửa chữa này đã được thanh toán trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bus.ThanhToanPhieu(maPhieu))
            {
                MessageBox.Show($"Thanh toán phiếu sửa chữa #{maPhieu} thành công! Đã chuyển trạng thái sang [Đã thanh toán].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllData();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }      
        private void label12_Click(object sender, EventArgs e) { }
        private void txtSearchBienSo_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtBienSoMoi_TextChanged(object sender, EventArgs e) { }
        private void txtTenKH_TextChanged(object sender, EventArgs e) { }
        private void txtSdt_TextChanged(object sender, EventArgs e) { }
        private void txtDiaChi_TextChanged(object sender, EventArgs e) { }
        private void txtHieuXe_TextChanged(object sender, EventArgs e) { }
        private void txtNamSX_TextChanged(object sender, EventArgs e) { }
        private void dgvPhuTung_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) { }
        private void dgvChiTietPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblTongTienPhieu_Click(object sender, EventArgs e) { }
        private void dgvPhieuSuaChua_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}