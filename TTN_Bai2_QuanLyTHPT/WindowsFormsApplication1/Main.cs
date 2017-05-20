using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHocSinh a = new FormHocSinh();
            a.Show();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLopHoc b = new FormLopHoc();
            b.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiaoVien a = new FormGiaoVien();
            c.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void điểmSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiemHS f = new DiemHS();
            f.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe g = new ThongKe();
            g.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan h = new HuongDan();
            h.Show();
        }

        private void lichPhanCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLichPhanCong e1 = new FormLichPhanCong();
            e1.Show();
        }
    }
}
