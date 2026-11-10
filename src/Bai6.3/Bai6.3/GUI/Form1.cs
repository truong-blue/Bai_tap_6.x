using System;
using System.Data;
using System.Windows.Forms;
using Bai6._3.BUS;
using Bai6._3.DTO;

namespace Bai6._3
{
    public partial class Form1 : Form
    {
        private ProjectTaskBUS bus = new ProjectTaskBUS();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.dgvTasks.SelectionChanged += dgvTasks_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ CÔNG VIỆC & TIẾN ĐỘ DỰ ÁN (PROJECT & TASK MANAGEMENT)";

            InitComboData();
            LoadTaskList();
        }

        private void InitComboData()
        {
            try
            {
                DataTable dtDuAn = bus.GetListDuAn();
                cboDuAn.DataSource = dtDuAn;
                cboDuAn.DisplayMember = "TenDuAn";
                cboDuAn.ValueMember = "MaDuAn";
                DataTable dtFilterDuAn = dtDuAn.Copy();
                DataRow r = dtFilterDuAn.NewRow();
                r["MaDuAn"] = 0;
                r["TenDuAn"] = "-- Tất cả Dự án --";
                dtFilterDuAn.Rows.InsertAt(r, 0);
                cboFilterDuAn.DataSource = dtFilterDuAn;
                cboFilterDuAn.DisplayMember = "TenDuAn";
                cboFilterDuAn.ValueMember = "MaDuAn";
                cboThanhVien.DataSource = bus.GetListThanhVien();
                cboThanhVien.DisplayMember = "HoTen";
                cboThanhVien.ValueMember = "MaThanhVien";
                cboFilterTrangThai.Items.Clear();
                cboFilterTrangThai.Items.AddRange(new string[] { "Tất cả", "To Do", "In Progress", "Done" });
                cboFilterTrangThai.SelectedIndex = 0;

                cboStatusChange.Items.Clear();
                cboStatusChange.Items.AddRange(new string[] { "To Do", "In Progress", "Done" });

                cboUuTien.Items.Clear();
                cboUuTien.Items.AddRange(new string[] { "Cao", "Trung bình", "Thấp" });
                cboUuTien.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL ProjectTaskDB: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTaskList()
        {
            int maDuAn = Convert.ToInt32(cboFilterDuAn.SelectedValue ?? 0);
            string trangThai = cboFilterTrangThai.SelectedItem?.ToString() ?? "Tất cả";

            dgvTasks.DataSource = bus.GetTasksByFilter(maDuAn, trangThai);
        }

        // 1. LỌC DANH SÁCH TASK THEO DỰ ÁN VÀ TRẠNG THÁI
        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadTaskList();
        }

        // 2. THÊM TASK MỚI VÀO DỰ ÁN (CRUD 3-TIER)
        private void btnThemTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTask.Text))
            {
                MessageBox.Show("Vui lòng nhập tên công việc (Task)! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CongViecDTO task = new CongViecDTO
            {
                MaDuAn = Convert.ToInt32(cboDuAn.SelectedValue),
                TenTask = txtTenTask.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                HanNop = dtpHanNop.Value,
                DoUuTien = cboUuTien.SelectedItem.ToString(),
                TrangThai = "To Do"
            };

            if (bus.InsertTask(task))
            {
                MessageBox.Show("Thêm công việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTask.Clear();
                txtMoTa.Clear();
                LoadTaskList();
            }
            else
            {
                MessageBox.Show("Thêm công việc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. PHÂN CÔNG NGHỆP VỤ CHO THÀNH VIÊN
        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null || cboThanhVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn 1 Task trên bảng và 1 Thành viên để phân công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTask = Convert.ToInt32(dgvTasks.CurrentRow.Cells["MaTask"].Value);
            int maTV = Convert.ToInt32(cboThanhVien.SelectedValue);

            if (bus.AssignTask(maTask, maTV))
            {
                MessageBox.Show("Phân công thành viên xử lý Task thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaskList();
            }
        }

        // 4. CẬP NHẬT TRẠNG THÁI TASK (PARAMETERIZED SQL UPDATE)
        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn 1 Task cần cập nhật trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTask = Convert.ToInt32(dgvTasks.CurrentRow.Cells["MaTask"].Value);
            string trangThaiMoi = cboStatusChange.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(trangThaiMoi)) return;

            if (bus.UpdateStatus(maTask, trangThaiMoi))
            {
                MessageBox.Show($"Đã chuyển trạng thái công việc sang [{trangThaiMoi}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaskList();
            }
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow != null && dgvTasks.CurrentRow.Cells["TrangThai"].Value != null)
            {
                cboStatusChange.SelectedItem = dgvTasks.CurrentRow.Cells["TrangThai"].Value.ToString();
            }
        }

        // 5. CẢNH BÁO TRỄ HẠN (OVERDUE TASKS - DATAREADER)
        private void btnCanhBaoOverdue_Click(object sender, EventArgs e)
        {
            DataTable dtOverdue = bus.GetOverdueTasks();
            dgvReport.DataSource = dtOverdue;
            MessageBox.Show($"Cảnh báo: Hiện có {dtOverdue.Rows.Count} công việc đã quá hạn (HanNop) chưa hoàn thành!", "Cảnh báo Overdue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // 6. THỐNG KÊ TỶ LỆ % HOÀN THÀNH THEO THÀNH VIÊN (GROUP BY)
        private void btnThongKeThanhVien_Click(object sender, EventArgs e)
        {
            DataTable dtStat = bus.GetMemberTaskStatistics();
            dgvReport.DataSource = dtStat;
        }
        // GIỮ LẠI CÁC HÀM SỰ KIỆN RỖNG ĐỂ TRÁNH LỖI DESIGNER
        
        private void cboFilterDuAn_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboFilterTrangThai_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtTenTask_TextChanged(object sender, EventArgs e) { }
        private void txtMoTa_TextChanged(object sender, EventArgs e) { }
        private void cboDuAn_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboUuTien_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtpHanNop_ValueChanged(object sender, EventArgs e) { }
        private void cboThanhVien_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboStatusChange_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}