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
    // Form dang nhap 
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

	    // Kiem tra ten dang nhap va mat khau
            // tenDangNhap = admin
            // matKhau = ducanh
            if(txtTenDangNhap.Text=="admin" && txtMatKhau.Text=="ducanh") 
            {
                // DangNhap b = new DangNhap();
                this.Hide();
                Form1 a = new Form1();
                a.Show();
                //Form1 b = new Form1();


            }

        }

        private void button1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
	    // Kiem tra ten dang nhap va mat khau
            // tenDangNhap = admin
            // matKhau = ducanh
            if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "ducanh")
            {
                Form1 a = new Form1();
                a.Show();
                DangNhap b = new DangNhap();
                b.Close();

            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc Tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
