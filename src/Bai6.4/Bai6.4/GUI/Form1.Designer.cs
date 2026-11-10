
namespace Bai6._4
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBienSo = new System.Windows.Forms.TextBox();
            this.btnSearchXe = new System.Windows.Forms.Button();
            this.dgvDanhSachXe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBienSoMoi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.btnTiepNhanXe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhuTung = new System.Windows.Forms.DataGridView();
            this.btnCapNhatPhuTung = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhuTungItem = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPhieu = new System.Windows.Forms.DataGridView();
            this.lblTongTienPhieu = new System.Windows.Forms.Label();
            this.btnXacNhanLapPhieu = new System.Windows.Forms.Button();
            this.dgvPhieuSuaChua = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuSuaChua)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tiếp nhận Xe & Phụ tùng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lập Phiếu Sửa Chữa & Vật tư";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnLamMoi);
            this.tabPage3.Controls.Add(this.btnThanhToan);
            this.tabPage3.Controls.Add(this.dgvPhieuSuaChua);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thanh Toán & Xuất Hóa Đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDanhSachXe);
            this.groupBox1.Controls.Add(this.btnSearchXe);
            this.groupBox1.Controls.Add(this.txtSearchBienSo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu danh sách xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển số:";
            // 
            // txtSearchBienSo
            // 
            this.txtSearchBienSo.Location = new System.Drawing.Point(57, 16);
            this.txtSearchBienSo.Name = "txtSearchBienSo";
            this.txtSearchBienSo.Size = new System.Drawing.Size(137, 20);
            this.txtSearchBienSo.TabIndex = 2;
            this.txtSearchBienSo.TextChanged += new System.EventHandler(this.txtSearchBienSo_TextChanged);
            // 
            // btnSearchXe
            // 
            this.btnSearchXe.Location = new System.Drawing.Point(9, 42);
            this.btnSearchXe.Name = "btnSearchXe";
            this.btnSearchXe.Size = new System.Drawing.Size(185, 23);
            this.btnSearchXe.TabIndex = 3;
            this.btnSearchXe.Text = "Tra cứu Biển số";
            this.btnSearchXe.UseVisualStyleBackColor = true;
            this.btnSearchXe.Click += new System.EventHandler(this.btnSearchXe_Click);
            // 
            // dgvDanhSachXe
            // 
            this.dgvDanhSachXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachXe.Location = new System.Drawing.Point(9, 71);
            this.dgvDanhSachXe.Name = "dgvDanhSachXe";
            this.dgvDanhSachXe.Size = new System.Drawing.Size(486, 336);
            this.dgvDanhSachXe.TabIndex = 4;
            this.dgvDanhSachXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnTiepNhanXe);
            this.groupBox2.Controls.Add(this.txtNamSX);
            this.groupBox2.Controls.Add(this.txtHieuXe);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtSdt);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.txtBienSoMoi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(515, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng ký xe && Chủ xe mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Biển số xe mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên chủ xe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hiệu xe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Năm sản xuất:";
            // 
            // txtBienSoMoi
            // 
            this.txtBienSoMoi.Location = new System.Drawing.Point(90, 16);
            this.txtBienSoMoi.Name = "txtBienSoMoi";
            this.txtBienSoMoi.Size = new System.Drawing.Size(165, 20);
            this.txtBienSoMoi.TabIndex = 6;
            this.txtBienSoMoi.TextChanged += new System.EventHandler(this.txtBienSoMoi_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(90, 42);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(165, 20);
            this.txtTenKH.TabIndex = 7;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(90, 68);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(165, 20);
            this.txtSdt.TabIndex = 8;
            this.txtSdt.TextChanged += new System.EventHandler(this.txtSdt_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(90, 94);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(165, 20);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(90, 120);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(165, 20);
            this.txtHieuXe.TabIndex = 10;
            this.txtHieuXe.TextChanged += new System.EventHandler(this.txtHieuXe_TextChanged);
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(90, 146);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(165, 20);
            this.txtNamSX.TabIndex = 11;
            this.txtNamSX.TextChanged += new System.EventHandler(this.txtNamSX_TextChanged);
            // 
            // btnTiepNhanXe
            // 
            this.btnTiepNhanXe.BackColor = System.Drawing.Color.LightBlue;
            this.btnTiepNhanXe.Location = new System.Drawing.Point(9, 172);
            this.btnTiepNhanXe.Name = "btnTiepNhanXe";
            this.btnTiepNhanXe.Size = new System.Drawing.Size(246, 23);
            this.btnTiepNhanXe.TabIndex = 12;
            this.btnTiepNhanXe.Text = "Tiếp nhận xe mới";
            this.btnTiepNhanXe.UseVisualStyleBackColor = false;
            this.btnTiepNhanXe.Click += new System.EventHandler(this.btnTiepNhanXe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnCapNhatPhuTung);
            this.groupBox3.Controls.Add(this.dgvPhuTung);
            this.groupBox3.Location = new System.Drawing.Point(515, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý Danh mục Phụ tùng";
            // 
            // dgvPhuTung
            // 
            this.dgvPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuTung.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPhuTung.Location = new System.Drawing.Point(3, 16);
            this.dgvPhuTung.Name = "dgvPhuTung";
            this.dgvPhuTung.Size = new System.Drawing.Size(263, 150);
            this.dgvPhuTung.TabIndex = 0;
            this.dgvPhuTung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuTung_CellContentClick);
            // 
            // btnCapNhatPhuTung
            // 
            this.btnCapNhatPhuTung.Location = new System.Drawing.Point(9, 172);
            this.btnCapNhatPhuTung.Name = "btnCapNhatPhuTung";
            this.btnCapNhatPhuTung.Size = new System.Drawing.Size(246, 23);
            this.btnCapNhatPhuTung.TabIndex = 1;
            this.btnCapNhatPhuTung.Text = "Lưu cập nhật Phụ tùng";
            this.btnCapNhatPhuTung.UseVisualStyleBackColor = true;
            this.btnCapNhatPhuTung.Click += new System.EventHandler(this.btnCapNhatPhuTung_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 126);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phiếu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Biển xe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mô tả:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnThemPhuTungItem);
            this.groupBox5.Controls.Add(this.numericUpDown2);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(250, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 126);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chọn Phụ tùng && Dịch vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phụ tùng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số lượng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tiền công:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(65, 46);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(65, 72);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnThemPhuTungItem
            // 
            this.btnThemPhuTungItem.Location = new System.Drawing.Point(9, 97);
            this.btnThemPhuTungItem.Name = "btnThemPhuTungItem";
            this.btnThemPhuTungItem.Size = new System.Drawing.Size(216, 23);
            this.btnThemPhuTungItem.TabIndex = 6;
            this.btnThemPhuTungItem.Text = "Thêm vào phiếu";
            this.btnThemPhuTungItem.UseVisualStyleBackColor = true;
            this.btnThemPhuTungItem.Click += new System.EventHandler(this.btnThemPhuTungItem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btnXacNhanLapPhieu);
            this.groupBox6.Controls.Add(this.lblTongTienPhieu);
            this.groupBox6.Controls.Add(this.dgvChiTietPhieu);
            this.groupBox6.Location = new System.Drawing.Point(8, 138);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(776, 283);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lưới giỏ vật tư && Xác nhận";
            // 
            // dgvChiTietPhieu
            // 
            this.dgvChiTietPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieu.Location = new System.Drawing.Point(3, 16);
            this.dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            this.dgvChiTietPhieu.Size = new System.Drawing.Size(780, 203);
            this.dgvChiTietPhieu.TabIndex = 0;
            this.dgvChiTietPhieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieu_CellContentClick);
            // 
            // lblTongTienPhieu
            // 
            this.lblTongTienPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTienPhieu.AutoSize = true;
            this.lblTongTienPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienPhieu.Location = new System.Drawing.Point(11, 222);
            this.lblTongTienPhieu.Name = "lblTongTienPhieu";
            this.lblTongTienPhieu.Size = new System.Drawing.Size(230, 24);
            this.lblTongTienPhieu.TabIndex = 1;
            this.lblTongTienPhieu.Text = "Tổng tiền phiếu: 0 VNĐ";
            this.lblTongTienPhieu.Click += new System.EventHandler(this.lblTongTienPhieu_Click);
            // 
            // btnXacNhanLapPhieu
            // 
            this.btnXacNhanLapPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhanLapPhieu.BackColor = System.Drawing.Color.Orange;
            this.btnXacNhanLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanLapPhieu.Location = new System.Drawing.Point(247, 244);
            this.btnXacNhanLapPhieu.Name = "btnXacNhanLapPhieu";
            this.btnXacNhanLapPhieu.Size = new System.Drawing.Size(299, 33);
            this.btnXacNhanLapPhieu.TabIndex = 2;
            this.btnXacNhanLapPhieu.Text = "XÁC NHẬN LẬP PHIẾU (TRANSACTION)";
            this.btnXacNhanLapPhieu.UseVisualStyleBackColor = false;
            this.btnXacNhanLapPhieu.Click += new System.EventHandler(this.btnXacNhanLapPhieu_Click);
            // 
            // dgvPhieuSuaChua
            // 
            this.dgvPhieuSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuSuaChua.Location = new System.Drawing.Point(8, 35);
            this.dgvPhieuSuaChua.Name = "dgvPhieuSuaChua";
            this.dgvPhieuSuaChua.ReadOnly = true;
            this.dgvPhieuSuaChua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuSuaChua.Size = new System.Drawing.Size(776, 277);
            this.dgvPhieuSuaChua.TabIndex = 0;
            this.dgvPhieuSuaChua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuSuaChua_CellContentClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.LightGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(185, 318);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(401, 44);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán && Xuất Hóa Đơn";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(185, 368);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(401, 36);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Tải lại danh sách";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ GARAGE VÀ BẢO BƯỠNG XE Ô TÔ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuSuaChua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCapNhatPhuTung;
        private System.Windows.Forms.DataGridView dgvPhuTung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTiepNhanXe;
        private System.Windows.Forms.TextBox txtNamSX;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtBienSoMoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachXe;
        private System.Windows.Forms.Button btnSearchXe;
        private System.Windows.Forms.TextBox txtSearchBienSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnXacNhanLapPhieu;
        private System.Windows.Forms.Label lblTongTienPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieu;
        private System.Windows.Forms.Button btnThemPhuTungItem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvPhieuSuaChua;
    }
}

