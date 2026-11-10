
namespace Bai6._5
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
            this.flpPhongHat = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTenPhongChon = new System.Windows.Forms.Label();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.btnMoPhong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.nmSoLuongDV = new System.Windows.Forms.NumericUpDown();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDV = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongDV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDV)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPhongHat
            // 
            this.flpPhongHat.AutoScroll = true;
            this.flpPhongHat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPhongHat.Location = new System.Drawing.Point(12, 12);
            this.flpPhongHat.Name = "flpPhongHat";
            this.flpPhongHat.Size = new System.Drawing.Size(417, 426);
            this.flpPhongHat.TabIndex = 0;
            this.flpPhongHat.Paint += new System.Windows.Forms.PaintEventHandler(this.flpPhongHat_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoPhong);
            this.groupBox1.Controls.Add(this.lblGioVao);
            this.groupBox1.Controls.Add(this.lblTenPhongChon);
            this.groupBox1.Location = new System.Drawing.Point(435, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Phòng";
            // 
            // lblTenPhongChon
            // 
            this.lblTenPhongChon.AutoSize = true;
            this.lblTenPhongChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhongChon.Location = new System.Drawing.Point(6, 16);
            this.lblTenPhongChon.Name = "lblTenPhongChon";
            this.lblTenPhongChon.Size = new System.Drawing.Size(178, 24);
            this.lblTenPhongChon.TabIndex = 0;
            this.lblTenPhongChon.Text = "Chưa chọn phòng";
            this.lblTenPhongChon.Click += new System.EventHandler(this.lblTenPhongChon_Click);
            // 
            // lblGioVao
            // 
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.Location = new System.Drawing.Point(7, 40);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(65, 13);
            this.lblGioVao.TabIndex = 1;
            this.lblGioVao.Text = "Giờ vào: --:--";
            this.lblGioVao.Click += new System.EventHandler(this.lblGioVao_Click);
            // 
            // btnMoPhong
            // 
            this.btnMoPhong.BackColor = System.Drawing.Color.LightGreen;
            this.btnMoPhong.Location = new System.Drawing.Point(10, 56);
            this.btnMoPhong.Name = "btnMoPhong";
            this.btnMoPhong.Size = new System.Drawing.Size(75, 23);
            this.btnMoPhong.TabIndex = 2;
            this.btnMoPhong.Text = "MỞ PHÒNG";
            this.btnMoPhong.UseVisualStyleBackColor = false;
            this.btnMoPhong.Click += new System.EventHandler(this.btnMoPhong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnThemDV);
            this.groupBox2.Controls.Add(this.nmSoLuongDV);
            this.groupBox2.Controls.Add(this.cboDichVu);
            this.groupBox2.Location = new System.Drawing.Point(435, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ && Đồ uống";
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(59, 19);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(121, 21);
            this.cboDichVu.TabIndex = 0;
            this.cboDichVu.SelectedIndexChanged += new System.EventHandler(this.cboDichVu_SelectedIndexChanged);
            // 
            // nmSoLuongDV
            // 
            this.nmSoLuongDV.Location = new System.Drawing.Point(59, 46);
            this.nmSoLuongDV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuongDV.Name = "nmSoLuongDV";
            this.nmSoLuongDV.Size = new System.Drawing.Size(121, 20);
            this.nmSoLuongDV.TabIndex = 1;
            this.nmSoLuongDV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuongDV.ValueChanged += new System.EventHandler(this.nmSoLuongDV_ValueChanged);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(10, 72);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(170, 23);
            this.btnThemDV.TabIndex = 2;
            this.btnThemDV.Text = "Thêm Dịch Vụ";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dịch vụ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.dgvChiTietDV);
            this.groupBox3.Location = new System.Drawing.Point(435, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 219);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Dịch vụ đã đặt";
            // 
            // dgvChiTietDV
            // 
            this.dgvChiTietDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDV.Location = new System.Drawing.Point(10, 19);
            this.dgvChiTietDV.Name = "dgvChiTietDV";
            this.dgvChiTietDV.ReadOnly = true;
            this.dgvChiTietDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDV.Size = new System.Drawing.Size(337, 149);
            this.dgvChiTietDV.TabIndex = 0;
            this.dgvChiTietDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDV_CellContentClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.Orange;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(10, 174);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(337, 39);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "THANH TOÁN && TÍNH TIỀN ";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpPhongHat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ ĐẶT PHÒNG & DỊCH VỤ KARAOKE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongDV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPhongHat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMoPhong;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.Label lblTenPhongChon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.NumericUpDown nmSoLuongDV;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvChiTietDV;
    }
}

