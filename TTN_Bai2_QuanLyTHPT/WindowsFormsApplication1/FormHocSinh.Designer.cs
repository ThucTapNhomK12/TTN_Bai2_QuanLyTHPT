namespace WindowsFormsApplication1
{
    partial class FormHocSinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtHocSinhID = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgHocSinh = new System.Windows.Forms.DataGridView();
            this.lblTenHocSinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 56;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(596, 331);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(57, 23);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // txtHocSinhID
            // 
            this.txtHocSinhID.Enabled = false;
            this.txtHocSinhID.HideSelection = false;
            this.txtHocSinhID.Location = new System.Drawing.Point(560, 85);
            this.txtHocSinhID.Name = "txtHocSinhID";
            this.txtHocSinhID.Size = new System.Drawing.Size(100, 20);
            this.txtHocSinhID.TabIndex = 54;
            this.txtHocSinhID.Visible = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(337, 122);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(116, 20);
            this.dtpNgaySinh.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Quê quán";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Location = new System.Drawing.Point(273, 128);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 51;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(97, 125);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(100, 20);
            this.txtQueQuan.TabIndex = 50;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Items.AddRange(new object[] {
            "ví dụ"});
            this.cbbLop.Location = new System.Drawing.Point(97, 85);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(100, 21);
            this.cbbLop.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(141, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 29);
            this.label5.TabIndex = 48;
            this.label5.Text = "Danh Sách Học Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(465, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "TÌm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Location = new System.Drawing.Point(631, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(57, 23);
            this.btnTimKiem.TabIndex = 46;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(515, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 45;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.BackColor = System.Drawing.Color.Transparent;
            this.lblLop.Location = new System.Drawing.Point(40, 94);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(25, 13);
            this.lblLop.TabIndex = 44;
            this.lblLop.Text = "Lớp";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Location = new System.Drawing.Point(596, 381);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(57, 23);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(596, 282);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 23);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(596, 227);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(57, 23);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(337, 85);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(116, 20);
            this.txtTenHS.TabIndex = 40;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(596, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // dtgHocSinh
            // 
            this.dtgHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHocSinh.Location = new System.Drawing.Point(12, 168);
            this.dtgHocSinh.Name = "dtgHocSinh";
            this.dtgHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHocSinh.Size = new System.Drawing.Size(544, 249);
            this.dtgHocSinh.TabIndex = 38;
            // 
            // lblTenHocSinh
            // 
            this.lblTenHocSinh.AutoSize = true;
            this.lblTenHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.lblTenHocSinh.Location = new System.Drawing.Point(273, 94);
            this.lblTenHocSinh.Name = "lblTenHocSinh";
            this.lblTenHocSinh.Size = new System.Drawing.Size(44, 13);
            this.lblTenHocSinh.TabIndex = 37;
            this.lblTenHocSinh.Text = "Tên HS";
            // 
            // FormHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.PZ_WhitePolygon12;
            this.ClientSize = new System.Drawing.Size(698, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtHocSinhID);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgHocSinh);
            this.Controls.Add(this.lblTenHocSinh);
            this.Name = "FormHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sachs Học Sinh";
            this.Load += new System.EventHandler(this.FormHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtHocSinhID;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgHocSinh;
        private System.Windows.Forms.Label lblTenHocSinh;
    }
}