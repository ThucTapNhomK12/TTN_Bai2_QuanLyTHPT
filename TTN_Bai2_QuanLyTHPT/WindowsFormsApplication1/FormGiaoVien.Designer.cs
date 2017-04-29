namespace WindowsFormsApplication1
{
    partial class FormGiaoVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbbDayMon = new System.Windows.Forms.ComboBox();
            this.txtIDGiaoVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenGv = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgGiaoVien = new System.Windows.Forms.DataGridView();
            this.lblTenHocSinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(452, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Dạy môn";
            // 
            // cbbDayMon
            // 
            this.cbbDayMon.FormattingEnabled = true;
            this.cbbDayMon.Location = new System.Drawing.Point(507, 64);
            this.cbbDayMon.Name = "cbbDayMon";
            this.cbbDayMon.Size = new System.Drawing.Size(103, 21);
            this.cbbDayMon.TabIndex = 79;
            this.cbbDayMon.SelectedIndexChanged += new System.EventHandler(this.cbbDayMon_SelectedIndexChanged);
            // 
            // txtIDGiaoVien
            // 
            this.txtIDGiaoVien.Enabled = false;
            this.txtIDGiaoVien.Location = new System.Drawing.Point(101, 68);
            this.txtIDGiaoVien.Name = "txtIDGiaoVien";
            this.txtIDGiaoVien.Size = new System.Drawing.Size(100, 20);
            this.txtIDGiaoVien.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 77;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(584, 330);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(57, 23);
            this.btnLuu.TabIndex = 76;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(304, 102);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(116, 20);
            this.dtpNgaySinh.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Quê quán";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Location = new System.Drawing.Point(240, 108);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 73;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(101, 105);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(100, 20);
            this.txtQueQuan.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(165, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Danh Sách Giáo Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(452, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "TÌm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Location = new System.Drawing.Point(625, 8);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(57, 23);
            this.btnTimKiem.TabIndex = 69;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(504, 10);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(106, 20);
            this.txtTimKiem.TabIndex = 68;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.BackColor = System.Drawing.Color.Transparent;
            this.lblLop.Location = new System.Drawing.Point(29, 74);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(66, 13);
            this.lblLop.TabIndex = 67;
            this.lblLop.Text = "ID Giáo viên";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Location = new System.Drawing.Point(584, 380);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(57, 23);
            this.btnHuy.TabIndex = 66;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(584, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 23);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(584, 226);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(57, 23);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenGv
            // 
            this.txtTenGv.Location = new System.Drawing.Point(304, 65);
            this.txtTenGv.Name = "txtTenGv";
            this.txtTenGv.Size = new System.Drawing.Size(116, 20);
            this.txtTenGv.TabIndex = 63;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(584, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 23);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgGiaoVien
            // 
            this.dtgGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGiaoVien.Location = new System.Drawing.Point(25, 175);
            this.dtgGiaoVien.Name = "dtgGiaoVien";
            this.dtgGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGiaoVien.Size = new System.Drawing.Size(527, 234);
            this.dtgGiaoVien.TabIndex = 61;
            this.dtgGiaoVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgGiaoVien_CellMouseClick);
            this.dtgGiaoVien.SelectionChanged += new System.EventHandler(this.dtgGiaoVien_SelectionChanged);
            // 
            // lblTenHocSinh
            // 
            this.lblTenHocSinh.AutoSize = true;
            this.lblTenHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.lblTenHocSinh.Location = new System.Drawing.Point(240, 74);
            this.lblTenHocSinh.Name = "lblTenHocSinh";
            this.lblTenHocSinh.Size = new System.Drawing.Size(44, 13);
            this.lblTenHocSinh.TabIndex = 60;
            this.lblTenHocSinh.Text = "Tên GV";
            // 
            // FormGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.PZ_WhitePolygon111;
            this.ClientSize = new System.Drawing.Size(698, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbDayMon);
            this.Controls.Add(this.txtIDGiaoVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenGv);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgGiaoVien);
            this.Controls.Add(this.lblTenHocSinh);
            this.Name = "FormGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiaoVien";
            this.Load += new System.EventHandler(this.FormGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbDayMon;
        private System.Windows.Forms.TextBox txtIDGiaoVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenGv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgGiaoVien;
        private System.Windows.Forms.Label lblTenHocSinh;
    }
}