namespace WindowsFormsApplication1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lichPhanCongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.lớpHọcToolStripMenuItem,
            this.giáoViênToolStripMenuItem,
            this.lichPhanCongToolStripMenuItem,
            this.điểmSốToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::WindowsFormsApplication1.Properties.Resources.Graduation_256;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItem1.Text = "Học Sinh";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.class_icon_44976;
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.lớpHọcToolStripMenuItem.Text = "Lớp Học";
            this.lớpHọcToolStripMenuItem.Click += new System.EventHandler(this.lớpHọcToolStripMenuItem_Click);
            // 
            // giáoViênToolStripMenuItem
            // 
            this.giáoViênToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.giáoViênToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.singing_teacher16001;
            this.giáoViênToolStripMenuItem.Name = "giáoViênToolStripMenuItem";
            this.giáoViênToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.giáoViênToolStripMenuItem.Text = "Giáo Viên";
            this.giáoViênToolStripMenuItem.Click += new System.EventHandler(this.giáoViênToolStripMenuItem_Click);
            // 
            // lichPhanCongToolStripMenuItem
            // 
            this.lichPhanCongToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.calendar;
            this.lichPhanCongToolStripMenuItem.Name = "lichPhanCongToolStripMenuItem";
            this.lichPhanCongToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.lichPhanCongToolStripMenuItem.Text = "Lịch Phân Công";
            this.lichPhanCongToolStripMenuItem.Click += new System.EventHandler(this.lichPhanCongToolStripMenuItem_Click);
            // 
            // điểmSốToolStripMenuItem
            // 
            this.điểmSốToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.score_scorecard_paper_pad_512;
            this.điểmSốToolStripMenuItem.Name = "điểmSốToolStripMenuItem";
            this.điểmSốToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.điểmSốToolStripMenuItem.Text = "Điểm HS";
            this.điểmSốToolStripMenuItem.Click += new System.EventHandler(this.điểmSốToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.chart;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.Graphicloads_100_Flat_Contact__1_;
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn - Liên hệ";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(578, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "SV2N2 TEAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(39, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "System of Score\'s Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Welcome you";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._7c32448f5a6db92ae192c95cd4667a2e_authorized_red_rounded;
            this.pictureBox2.Location = new System.Drawing.Point(572, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Welcome_Image_1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(698, 444);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chào Mừng Bạn Đến Với Hệ Thống Quản Lý Điểm THPT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lichPhanCongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}