using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bai6._5.BUS;

namespace Bai6._5
{
    public partial class Form1 : Form
    {
        private KaraokeBUS bus = new KaraokeBUS();
        private int currentMaPhong = 0;
        private int currentMaHD = 0;
        private string currentTenPhong = "";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ ĐẶT PHÒNG & DỊCH VỤ KARAOKE (KARAOKE MANAGEMENT SYSTEM)";

            LoadVisualRoomGrid();
            LoadComboDichVu();
        }

        // ================= 1. SƠ ĐỒ PHÒNG HÁT TRỰC QUAN (VISUAL GRID LAYOUT) =================
        private void LoadVisualRoomGrid()
        {
            flpPhongHat.Controls.Clear();
            DataTable dtPhong = bus.GetListPhongHat();

            foreach (DataRow row in dtPhong.Rows)
            {
                int maPhong = Convert.ToInt32(row["MaPhong"]);
                string tenPhong = row["TenPhong"].ToString();
                string loaiPhong = row["LoaiPhong"].ToString();
                string trangThai = row["TrangThai"].ToString();

                Button btn = new Button
                {
                    Width = 125,
                    Height = 95,
                    Text = $"{tenPhong}\n({loaiPhong})\n[{trangThai}]",
                    Tag = maPhong,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Margin = new Padding(8)
                };

                // Đổi màu nút theo trạng thái: Trống = Xanh lá, Đang hát = Đỏ
                if (trangThai == "Đang hát")
                {
                    btn.BackColor = Color.LightCoral;
                    btn.ForeColor = Color.DarkRed;
                }
                else
                {
                    btn.BackColor = Color.LightGreen;
                    btn.ForeColor = Color.DarkGreen;
                }

                btn.Click += BtnPhongHat_Click;
                flpPhongHat.Controls.Add(btn);
            }
        }

        private void BtnPhongHat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            currentMaPhong = Convert.ToInt32(btn.Tag);
            DataTable dtPhong = bus.GetListPhongHat();
            DataRow[] rows = dtPhong.Select($"MaPhong = {currentMaPhong}");

            if (rows.Length > 0)
            {
                currentTenPhong = rows[0]["TenPhong"].ToString();
                string trangThai = rows[0]["TrangThai"].ToString();
                lblTenPhongChon.Text = $"{currentTenPhong} ({trangThai})";

                if (trangThai == "Đang hát")
                {
                    btnMoPhong.Enabled = false;
                    btnThemDV.Enabled = true;
                    btnThanhToan.Enabled = true;

                    // Lấy Hóa đơn hiện tại của phòng đang hát
                    DataTable dtHD = bus.GetHoaDonHienTaiByMaPhong(currentMaPhong);
                    if (dtHD.Rows.Count > 0)
                    {
                        currentMaHD = Convert.ToInt32(dtHD.Rows[0]["MaHD"]);
                        DateTime gioVao = Convert.ToDateTime(dtHD.Rows[0]["GioVao"]);
                        lblGioVao.Text = $"Giờ vào: {gioVao:HH:mm dd/MM/yyyy}";
                        LoadChiTietDichVu();
                    }
                }
                else
                {
                    btnMoPhong.Enabled = true;
                    btnThemDV.Enabled = false;
                    btnThanhToan.Enabled = false;
                    lblGioVao.Text = "Giờ vào: --:--";
                    dgvChiTietDV.DataSource = null;
                    currentMaHD = 0;
                }
            }
        }

        private void LoadComboDichVu()
        {
            DataTable dtDV = bus.GetListDichVu();
            cboDichVu.DataSource = dtDV;
            cboDichVu.DisplayMember = "TenDV";
            cboDichVu.ValueMember = "MaDV";
        }

        private void LoadChiTietDichVu()
        {
            if (currentMaHD == 0) return;
            DataTable dtCT = bus.GetChiTietDichVuByMaHD(currentMaHD);
            dgvChiTietDV.DataSource = dtCT;
            if (dgvChiTietDV.Columns["DonGia"] != null) dgvChiTietDV.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            if (dgvChiTietDV.Columns["ThanhTien"] != null) dgvChiTietDV.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }

        // ================= 2. MỞ PHÒNG HÁT =================
        private void btnMoPhong_Click(object sender, EventArgs e)
        {
            if (currentMaPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 phòng trống từ sơ đồ bên trái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bus.MoPhongHat(currentMaPhong))
            {
                MessageBox.Show($"Mở {currentTenPhong} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVisualRoomGrid();
                BtnPhongHat_Click(FindButtonByMaPhong(currentMaPhong), e);
            }
        }

        // ================= 3. GỌI DỊCH VỤ / ĐỒ UỐNG (DISCONNECTED MODEL) =================
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (currentMaHD == 0 || cboDichVu.SelectedValue == null) return;

            int maDV = Convert.ToInt32(cboDichVu.SelectedValue);
            DataRowView row = cboDichVu.SelectedItem as DataRowView;
            decimal donGia = Convert.ToDecimal(row["DonGia"]);
            int soLuong = (int)nmSoLuongDV.Value;

            if (bus.ThemDichVuVaoHoaDon(currentMaHD, maDV, soLuong, donGia))
            {
                LoadChiTietDichVu();
            }
        }

        // ================= 4. TÍNH TIỀN & THANH TOÁN (MYSQL TRANSACTION) =================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (currentMaHD == 0) return;

            decimal tongPhong = 0, tongDV = 0;
            string error = "";

            bool ok = bus.ThanhToanHoaDon(currentMaHD, currentMaPhong, out tongPhong, out tongDV, out error);

            if (ok)
            {
                decimal tongCong = tongPhong + tongDV;
                string msg = $"[HÓA ĐƠN THANH TOÁN - {currentTenPhong}]\n" +
                             $"- Tiền phòng: {tongPhong:N0} VNĐ\n" +
                             $"- Tiền dịch vụ: {tongDV:N0} VNĐ\n" +
                             $"-----------------------------------\n" +
                             $"TỔNG CỘNG: {tongCong:N0} VNĐ\n\n" +
                             $"Thanh toán thành công! Phòng đã được chuyển về trạng thái Trống.";

                MessageBox.Show(msg, "Thanh Toán Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                currentMaHD = 0;
                currentMaPhong = 0;
                lblTenPhongChon.Text = "Chưa chọn phòng";
                lblGioVao.Text = "Giờ vào: --:--";
                dgvChiTietDV.DataSource = null;

                LoadVisualRoomGrid();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại (Rollback Transaction)!\nChi tiết: " + error, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Button FindButtonByMaPhong(int maPhong)
        {
            foreach (Control c in flpPhongHat.Controls)
            {
                if (c is Button btn && Convert.ToInt32(btn.Tag) == maPhong) return btn;
            }
            return null;
        }

        // ==============================================================
        // GIỮ LẠI CÁC HÀM SỰ KIỆN RỖNG TRÁNH LỖI DESIGNER
        // ==============================================================
        private void label1_Click(object sender, EventArgs e) { }
        private void flpPhongHat_Paint(object sender, PaintEventArgs e) { }
        private void lblTenPhongChon_Click(object sender, EventArgs e) { }
        private void lblGioVao_Click(object sender, EventArgs e) { }
        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e) { }
        private void nmSoLuongDV_ValueChanged(object sender, EventArgs e) { }
        private void dgvChiTietDV_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}