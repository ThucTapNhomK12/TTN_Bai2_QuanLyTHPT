using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2ThucTapNhom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHocSinh a = new FormHocSinh();
            a.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiaoVien a = new FormGiaoVien();
            a.Show();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLopHoc a = new FormLopHoc();
            a.Show();
        }

        private void lichPhanCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichPhanCongg a = new LichPhanCongg();
            a.Show();
        }

        private void điểmSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiemHS a = new DiemHS();
            a.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe a = new ThongKe();
            a.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huongdan a = new Huongdan();
            a.Show();
        }
    }
}
