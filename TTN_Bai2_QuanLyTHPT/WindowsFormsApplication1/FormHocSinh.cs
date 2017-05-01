using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Bai2ThucTapNhom
{
    public partial class FormHocSinh : Form
    {
        QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();
        public FormHocSinh()
        {
            InitializeComponent();
        }

        private void FormHocSinh_Load(object sender, EventArgs e)
        {
            ListHocSinh();
            ComboLop();
            cbbLop.Text = "Tất cả lớp";
            txtQueQuan.Enabled = false;
            txtTenHS.Enabled = false;
            dtpNgaySinh.Enabled = false;
        } 
        
        public void ComboLop()
        {
            try
            {
                var combo = (from a in db.LopHocs select new {a.LopHocID,a.TenLopHoc }).ToList();
                cbbLop.DataSource = combo;
                cbbLop.ValueMember = "LopHocID";
                cbbLop.DisplayMember = "TenLopHoc";
            }
            catch(Exception ex)
            {

            }
                       
        }
        public void ListHocSinh()
        {
            var list = from a in db.HocSinhs
                       join b in db.LopHocs
                       on a.LopHocID equals b.LopHocID
                       where a.IsActive == true
                       select new
                       {
                           MaHocSinh = a.HocSinhID,
                           a.TenHocSinh,
                           b.TenLopHoc,
                           a.NgaySinh,
                           QueQuan = a.QuenQuan
                       };
            dtgHocSinh.DataSource = list;
        }
        public void ListHocSinhTheoLop()
        {
            if(cbbLop.SelectedValue!=null)
            {
                var list = (from a in db.HocSinhs
                           join b in db.LopHocs
                           on a.LopHocID equals b.LopHocID
                           where b.LopHocID == (Int32)cbbLop.SelectedValue && a.IsActive==true
                           select new{
                               MaHocSinh = a.HocSinhID,
                               a.TenHocSinh,
                               b.TenLopHoc,
                               a.NgaySinh,
                               QueQuan = a.QuenQuan
                           }).ToList();
                dtgHocSinh.DataSource = list;
            }
        }


        private void cbbLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
            {
            }
            else
            {
                ListHocSinhTheoLop();
            }
        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtQueQuan.Text = "";
            txtTenHS.Text = "";
            cbbLop.Text = "";
            dtpNgaySinh.Text = "";
            txtQueQuan.Enabled = true;
            txtTenHS.Enabled = true;
            dtpNgaySinh.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void Insert ()
        {
            db = new QuanLyContextDataDataContext();
            HocSinh hocsinh = new HocSinh();
            hocsinh.TenHocSinh = txtTenHS.Text;
            hocsinh.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("dd/MM/yyyy", null));
            hocsinh.QuenQuan = txtQueQuan.Text;
            hocsinh.LopHocID = (Int32)cbbLop.SelectedValue;
            hocsinh.IsActive = true;
            db.HocSinhs.InsertOnSubmit(hocsinh);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh!", "Thông báo");

            }
        }
        public void Update()
        {
            db = new QuanLyContextDataDataContext();
            var query = from a in db.HocSinhs where a.HocSinhID == Int32.Parse(txtHocSinhID.Text) select a;
            try
            {
                foreach (HocSinh hocsinh in query)
                    {
                    hocsinh.TenHocSinh = txtTenHS.Text;
                    hocsinh.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("dd/MM/yyyy", null));
                    hocsinh.QuenQuan = txtQueQuan.Text;
                    hocsinh.LopHocID = (Int32)cbbLop.SelectedValue;
                    hocsinh.IsActive = true;
                    }

                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
        public void Delete()
        {
            db = new QuanLyContextDataDataContext();
            var query = from a in db.HocSinhs where a.HocSinhID == Int32.Parse(txtHocSinhID.Text) select a;
            try
            {
                foreach (HocSinh hocsinh in query)
                {
                    hocsinh.IsActive = false;
                }
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Insert();
            else
                Update();
            flag = 0;
            ListHocSinhTheoLop();
            txtQueQuan.Enabled = false;
            txtTenHS.Enabled = false;
            dtpNgaySinh.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            flag = 2;
            txtQueQuan.Enabled = true;
            txtTenHS.Enabled = true;
            dtpNgaySinh.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dtgHocSinh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtQueQuan.Enabled = false;
            txtTenHS.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }

        private void dtgHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dtgHocSinh.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txtHocSinhID.Text = row.Cells["MaHocSinh"].Value.ToString();
                txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
                cbbLop.Text = row.Cells["TenLopHoc"].Value.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtTenHS.Text = row.Cells["TenHocSinh"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn chắc chắn muôn xóa??",
                                     "Thông báo !!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Delete();
            }
            else
            { 
            }
            ListHocSinhTheoLop();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            flag = 0;
        }
        public void Search()
        {
            QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();
            var list = (from a in db.HocSinhs
                        join b in db.LopHocs
                        on a.LopHocID equals b.LopHocID
                        where a.IsActive == true && (a.TenHocSinh.Trim().Contains(txtTimKiem.Text) || a.QuenQuan.Trim().Contains(txtTimKiem.Text) || b.TenLopHoc.Trim().Contains(txtTimKiem.Text)|| a.HocSinhID.ToString() == (txtTimKiem.Text.ToString()))
                        select new
                        {
                            MaHocSinh = a.HocSinhID,
                            a.TenHocSinh,
                            b.TenLopHoc,
                            a.NgaySinh,
                            QueQuan = a.QuenQuan
                        }).ToList();
            dtgHocSinh.DataSource = list;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            Search();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                ListHocSinh();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            txtHocSinhID.Enabled = false;
            txtQueQuan.Enabled = false;
            txtTenHS.Enabled = false;
            dtpNgaySinh.Enabled = false;
            flag = 0;
        }
    }
}

