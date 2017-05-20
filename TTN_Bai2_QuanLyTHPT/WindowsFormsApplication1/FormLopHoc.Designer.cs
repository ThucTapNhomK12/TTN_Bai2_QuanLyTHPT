namespace Bai2ThucTapNhom
{
    partial class FormLopHoc
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
            this.cbbGiaovien = new System.Windows.Forms.ComboBox();
            this.txtIDLopHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenLopHoc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgLopHoc = new System.Windows.Forms.DataGridView();
            this.lblTenHocSinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(429, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Giáo viên CN";
            // 
            // cbbGiaovien
            // 
            this.cbbGiaovien.BackColor = System.Drawing.SystemColors.Window;
            this.cbbGiaovien.FormattingEnabled = true;
            this.cbbGiaovien.Location = new System.Drawing.Point(505, 84);
            this.cbbGiaovien.Name = "cbbGiaovien";
            this.cbbGiaovien.Size = new System.Drawing.Size(121, 21);
            this.cbbGiaovien.TabIndex = 79;
            this.cbbGiaovien.SelectedIndexChanged += new System.EventHandler(this.cbbDayMon_SelectedIndexChanged);
            this.cbbGiaovien.SelectionChangeCommitted += new System.EventHandler(this.cbbGiaovien_SelectionChangeCommitted);
            // 
            // txtIDLopHoc
            // 
            this.txtIDLopHoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDLopHoc.Enabled = false;
            this.txtIDLopHoc.Location = new System.Drawing.Point(103, 88);
            this.txtIDLopHoc.Name = "txtIDLopHoc";
            this.txtIDLopHoc.Size = new System.Drawing.Size(100, 20);
            this.txtIDLopHoc.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 77;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(585, 305);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(57, 23);
            this.btnLuu.TabIndex = 76;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(168, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Danh Sách Lớp Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(429, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "TÌm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Location = new System.Drawing.Point(626, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(57, 23);
            this.btnTimKiem.TabIndex = 69;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.Location = new System.Drawing.Point(505, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 68;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.BackColor = System.Drawing.Color.Transparent;
            this.lblLop.Location = new System.Drawing.Point(31, 94);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(60, 13);
            this.lblLop.TabIndex = 67;
            this.lblLop.Text = "ID Lớp học";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Location = new System.Drawing.Point(585, 355);
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
            this.btnXoa.Location = new System.Drawing.Point(585, 256);
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
            this.btnSua.Location = new System.Drawing.Point(585, 201);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(57, 23);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenLopHoc
            // 
            this.txtTenLopHoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenLopHoc.Location = new System.Drawing.Point(297, 86);
            this.txtTenLopHoc.Name = "txtTenLopHoc";
            this.txtTenLopHoc.Size = new System.Drawing.Size(116, 20);
            this.txtTenLopHoc.TabIndex = 63;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(585, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 23);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgLopHoc
            // 
            this.dtgLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLopHoc.Location = new System.Drawing.Point(21, 150);
            this.dtgLopHoc.Name = "dtgLopHoc";
            this.dtgLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLopHoc.Size = new System.Drawing.Size(527, 234);
            this.dtgLopHoc.TabIndex = 61;
            this.dtgLopHoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgLopHoc_CellMouseClick);
            this.dtgLopHoc.SelectionChanged += new System.EventHandler(this.dtgLopHoc_SelectionChanged);
            // 
            // lblTenHocSinh
            // 
            this.lblTenHocSinh.AutoSize = true;
            this.lblTenHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.lblTenHocSinh.Location = new System.Drawing.Point(227, 91);
            this.lblTenHocSinh.Name = "lblTenHocSinh";
            this.lblTenHocSinh.Size = new System.Drawing.Size(64, 13);
            this.lblTenHocSinh.TabIndex = 60;
            this.lblTenHocSinh.Text = "Tên lớp học";
            this.lblTenHocSinh.Click += new System.EventHandler(this.lblTenHocSinh_Click);
            // 
            // FormLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackgroundImage = global::Bai2ThucTapNhom.Properties.Resources.PZ_WhitePolygon13;
            this.ClientSize = new System.Drawing.Size(698, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbGiaovien);
            this.Controls.Add(this.txtIDLopHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenLopHoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgLopHoc);
            this.Controls.Add(this.lblTenHocSinh);
            this.Name = "FormLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLopHoc";
            this.Load += new System.EventHandler(this.FormLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbGiaovien;
        private System.Windows.Forms.TextBox txtIDLopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenLopHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgLopHoc;
        private System.Windows.Forms.Label lblTenHocSinh;
    }
}