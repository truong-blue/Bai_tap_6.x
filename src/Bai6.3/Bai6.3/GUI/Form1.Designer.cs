
namespace Bai6._3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cboFilterDuAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFilterTrangThai = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.gbCreateTask = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenTask = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.cboDuAn = new System.Windows.Forms.ComboBox();
            this.cboUuTien = new System.Windows.Forms.ComboBox();
            this.dtpHanNop = new System.Windows.Forms.DateTimePicker();
            this.btnThemTask = new System.Windows.Forms.Button();
            this.gbActionTask = new System.Windows.Forms.GroupBox();
            this.cboThanhVien = new System.Windows.Forms.ComboBox();
            this.cboStatusChange = new System.Windows.Forms.ComboBox();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnCapNhatTrangThai = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCanhBaoOverdue = new System.Windows.Forms.Button();
            this.btnThongKeThanhVien = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.gbCreateTask.SuspendLayout();
            this.gbActionTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbActionTask);
            this.tabPage1.Controls.Add(this.gbCreateTask);
            this.tabPage1.Controls.Add(this.gbFilter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý Công việc & Tiến độ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvReport);
            this.tabPage2.Controls.Add(this.btnThongKeThanhVien);
            this.tabPage2.Controls.Add(this.btnCanhBaoOverdue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo cáo && Cảnh báo Trễ hạn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbFilter
            // 
            this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilter.Controls.Add(this.dgvTasks);
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.cboFilterTrangThai);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.cboFilterDuAn);
            this.gbFilter.Location = new System.Drawing.Point(8, 6);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(471, 410);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc công việc";
            // 
            // cboFilterDuAn
            // 
            this.cboFilterDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterDuAn.FormattingEnabled = true;
            this.cboFilterDuAn.Location = new System.Drawing.Point(70, 19);
            this.cboFilterDuAn.Name = "cboFilterDuAn";
            this.cboFilterDuAn.Size = new System.Drawing.Size(199, 21);
            this.cboFilterDuAn.TabIndex = 0;
            this.cboFilterDuAn.SelectedIndexChanged += new System.EventHandler(this.cboFilterDuAn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dự án:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái:";
            // 
            // cboFilterTrangThai
            // 
            this.cboFilterTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterTrangThai.FormattingEnabled = true;
            this.cboFilterTrangThai.Location = new System.Drawing.Point(70, 50);
            this.cboFilterTrangThai.Name = "cboFilterTrangThai";
            this.cboFilterTrangThai.Size = new System.Drawing.Size(199, 21);
            this.cboFilterTrangThai.TabIndex = 3;
            this.cboFilterTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboFilterTrangThai_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(9, 77);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(260, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Lọc dữ liệu";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(3, 109);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(465, 298);
            this.dgvTasks.TabIndex = 5;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // gbCreateTask
            // 
            this.gbCreateTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCreateTask.Controls.Add(this.btnThemTask);
            this.gbCreateTask.Controls.Add(this.dtpHanNop);
            this.gbCreateTask.Controls.Add(this.cboUuTien);
            this.gbCreateTask.Controls.Add(this.cboDuAn);
            this.gbCreateTask.Controls.Add(this.txtMoTa);
            this.gbCreateTask.Controls.Add(this.txtTenTask);
            this.gbCreateTask.Controls.Add(this.label7);
            this.gbCreateTask.Controls.Add(this.label6);
            this.gbCreateTask.Controls.Add(this.label5);
            this.gbCreateTask.Controls.Add(this.label4);
            this.gbCreateTask.Controls.Add(this.label3);
            this.gbCreateTask.Location = new System.Drawing.Point(502, 6);
            this.gbCreateTask.Name = "gbCreateTask";
            this.gbCreateTask.Size = new System.Drawing.Size(246, 191);
            this.gbCreateTask.TabIndex = 1;
            this.gbCreateTask.TabStop = false;
            this.gbCreateTask.Text = "Tạo công việc mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Task:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dự án thuộc về:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Độ ưu tiên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hạn nộp:";
            // 
            // txtTenTask
            // 
            this.txtTenTask.Location = new System.Drawing.Point(96, 19);
            this.txtTenTask.Name = "txtTenTask";
            this.txtTenTask.Size = new System.Drawing.Size(144, 20);
            this.txtTenTask.TabIndex = 5;
            this.txtTenTask.TextChanged += new System.EventHandler(this.txtTenTask_TextChanged);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(96, 45);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(144, 20);
            this.txtMoTa.TabIndex = 6;
            this.txtMoTa.TextChanged += new System.EventHandler(this.txtMoTa_TextChanged);
            // 
            // cboDuAn
            // 
            this.cboDuAn.FormattingEnabled = true;
            this.cboDuAn.Location = new System.Drawing.Point(96, 71);
            this.cboDuAn.Name = "cboDuAn";
            this.cboDuAn.Size = new System.Drawing.Size(144, 21);
            this.cboDuAn.TabIndex = 7;
            this.cboDuAn.SelectedIndexChanged += new System.EventHandler(this.cboDuAn_SelectedIndexChanged);
            // 
            // cboUuTien
            // 
            this.cboUuTien.FormattingEnabled = true;
            this.cboUuTien.Location = new System.Drawing.Point(96, 98);
            this.cboUuTien.Name = "cboUuTien";
            this.cboUuTien.Size = new System.Drawing.Size(144, 21);
            this.cboUuTien.TabIndex = 8;
            this.cboUuTien.SelectedIndexChanged += new System.EventHandler(this.cboUuTien_SelectedIndexChanged);
            // 
            // dtpHanNop
            // 
            this.dtpHanNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanNop.Location = new System.Drawing.Point(96, 125);
            this.dtpHanNop.Name = "dtpHanNop";
            this.dtpHanNop.Size = new System.Drawing.Size(144, 20);
            this.dtpHanNop.TabIndex = 9;
            this.dtpHanNop.ValueChanged += new System.EventHandler(this.dtpHanNop_ValueChanged);
            // 
            // btnThemTask
            // 
            this.btnThemTask.BackColor = System.Drawing.Color.LightBlue;
            this.btnThemTask.Location = new System.Drawing.Point(14, 157);
            this.btnThemTask.Name = "btnThemTask";
            this.btnThemTask.Size = new System.Drawing.Size(226, 23);
            this.btnThemTask.TabIndex = 10;
            this.btnThemTask.Text = "Thêm Task Mới";
            this.btnThemTask.UseVisualStyleBackColor = false;
            this.btnThemTask.Click += new System.EventHandler(this.btnThemTask_Click);
            // 
            // gbActionTask
            // 
            this.gbActionTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActionTask.Controls.Add(this.label9);
            this.gbActionTask.Controls.Add(this.label8);
            this.gbActionTask.Controls.Add(this.btnCapNhatTrangThai);
            this.gbActionTask.Controls.Add(this.btnPhanCong);
            this.gbActionTask.Controls.Add(this.cboStatusChange);
            this.gbActionTask.Controls.Add(this.cboThanhVien);
            this.gbActionTask.Location = new System.Drawing.Point(502, 200);
            this.gbActionTask.Name = "gbActionTask";
            this.gbActionTask.Size = new System.Drawing.Size(246, 213);
            this.gbActionTask.TabIndex = 2;
            this.gbActionTask.TabStop = false;
            this.gbActionTask.Text = "Phân công && Cập nhật tiến độ";
            // 
            // cboThanhVien
            // 
            this.cboThanhVien.FormattingEnabled = true;
            this.cboThanhVien.Location = new System.Drawing.Point(105, 19);
            this.cboThanhVien.Name = "cboThanhVien";
            this.cboThanhVien.Size = new System.Drawing.Size(135, 21);
            this.cboThanhVien.TabIndex = 2;
            this.cboThanhVien.SelectedIndexChanged += new System.EventHandler(this.cboThanhVien_SelectedIndexChanged);
            // 
            // cboStatusChange
            // 
            this.cboStatusChange.FormattingEnabled = true;
            this.cboStatusChange.Location = new System.Drawing.Point(105, 46);
            this.cboStatusChange.Name = "cboStatusChange";
            this.cboStatusChange.Size = new System.Drawing.Size(135, 21);
            this.cboStatusChange.TabIndex = 3;
            this.cboStatusChange.SelectedIndexChanged += new System.EventHandler(this.cboStatusChange_SelectedIndexChanged);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Location = new System.Drawing.Point(14, 73);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(226, 23);
            this.btnPhanCong.TabIndex = 5;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnCapNhatTrangThai
            // 
            this.btnCapNhatTrangThai.BackColor = System.Drawing.Color.LightGreen;
            this.btnCapNhatTrangThai.Location = new System.Drawing.Point(15, 102);
            this.btnCapNhatTrangThai.Name = "btnCapNhatTrangThai";
            this.btnCapNhatTrangThai.Size = new System.Drawing.Size(225, 23);
            this.btnCapNhatTrangThai.TabIndex = 6;
            this.btnCapNhatTrangThai.Text = "Cập nhật trạng thái";
            this.btnCapNhatTrangThai.UseVisualStyleBackColor = false;
            this.btnCapNhatTrangThai.Click += new System.EventHandler(this.btnCapNhatTrangThai_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chọn thành viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Trạng thái:";
            // 
            // btnCanhBaoOverdue
            // 
            this.btnCanhBaoOverdue.BackColor = System.Drawing.Color.Orange;
            this.btnCanhBaoOverdue.Location = new System.Drawing.Point(8, 6);
            this.btnCanhBaoOverdue.Name = "btnCanhBaoOverdue";
            this.btnCanhBaoOverdue.Size = new System.Drawing.Size(255, 23);
            this.btnCanhBaoOverdue.TabIndex = 0;
            this.btnCanhBaoOverdue.Text = "Lọc Task Quá Hạn (Overdue)";
            this.btnCanhBaoOverdue.UseVisualStyleBackColor = false;
            this.btnCanhBaoOverdue.Click += new System.EventHandler(this.btnCanhBaoOverdue_Click);
            // 
            // btnThongKeThanhVien
            // 
            this.btnThongKeThanhVien.Location = new System.Drawing.Point(269, 6);
            this.btnThongKeThanhVien.Name = "btnThongKeThanhVien";
            this.btnThongKeThanhVien.Size = new System.Drawing.Size(255, 23);
            this.btnThongKeThanhVien.TabIndex = 1;
            this.btnThongKeThanhVien.Text = "Xem Thống Kê % Hoàn Thành Theo Thành Viên";
            this.btnThongKeThanhVien.UseVisualStyleBackColor = true;
            this.btnThongKeThanhVien.Click += new System.EventHandler(this.btnThongKeThanhVien_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReport.Location = new System.Drawing.Point(3, 35);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(615, 386);
            this.dgvReport.TabIndex = 2;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ CÔNG VIỆC & TIẾN ĐỘ DỰ ÁN";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.gbCreateTask.ResumeLayout(false);
            this.gbCreateTask.PerformLayout();
            this.gbActionTask.ResumeLayout(false);
            this.gbActionTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboFilterTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilterDuAn;
        private System.Windows.Forms.GroupBox gbActionTask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCapNhatTrangThai;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.ComboBox cboStatusChange;
        private System.Windows.Forms.ComboBox cboThanhVien;
        private System.Windows.Forms.GroupBox gbCreateTask;
        private System.Windows.Forms.Button btnThemTask;
        private System.Windows.Forms.DateTimePicker dtpHanNop;
        private System.Windows.Forms.ComboBox cboUuTien;
        private System.Windows.Forms.ComboBox cboDuAn;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnThongKeThanhVien;
        private System.Windows.Forms.Button btnCanhBaoOverdue;
    }
}

