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
    public partial class FormGiaoVien : Form
    {
        int flag ;
        public FormGiaoVien()
        {
            InitializeComponent();
        }
       // QuanLyContextDataContext db = new QuanLyContextDataContext();
        QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();
        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            ListGiaoVien();
            ComboMonHoc();

        }
        public void ListGiaoVien()
        {

            var list = from a in db.GiaoViens
                       join b in db.MonHocs
                       on a.MonHocID equals b.MonHocID
                       where a.IsActive == true && b.IsActive == true
                       select new
                       {
                           GiaoVienID = a.GiaoVienID,
                           DayMon = b.TenMonHoc,
                           a.TenGiaoVien,
                           a.QueQuan,
                           a.NgaySinh,
                       };
            dtgGiaoVien.DataSource = list;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           flag = 1;
            txtQueQuan.Text = "";
            txtTenGv.Text = "";
            dtpNgaySinh.Text = "";
            txtIDGiaoVien.Text = "";
            txtQueQuan.Enabled = true;
            txtTenGv.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;
            dtpNgaySinh.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cbbDayMon.Enabled = true;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            txtQueQuan.Enabled = true;
            txtTenGv.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtIDGiaoVien.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            cbbDayMon.Enabled = true;
        }
        public void Insert()
        {
            db = new QuanLyContextDataDataContext();
            GiaoVien giaovien = new GiaoVien();
            giaovien.TenGiaoVien = txtTenGv.Text;
            giaovien.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("dd/MM/yyyy", null));
            giaovien.MonHocID = (Int32)cbbDayMon.SelectedValue;
            giaovien.QueQuan = txtQueQuan.Text;
           // giaovien.LopHocID = (Int32)cbbLop.SelectedValue;
            giaovien.IsActive = true;
            db.GiaoViens.InsertOnSubmit(giaovien);
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
            var query = from a in db.GiaoViens where a.GiaoVienID == Int32.Parse(txtIDGiaoVien.Text) select a;
            try
            {
                foreach (GiaoVien giaovien in query)
                {
                    giaovien.TenGiaoVien = txtTenGv.Text;
                    giaovien.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToString("dd/MM/yyyy", null));
                    giaovien.QueQuan = txtQueQuan.Text;
                    giaovien.MonHocID = (Int32)cbbDayMon.SelectedValue;
                    //    hocsinh.LopHocID = (Int32)cbbLop.SelectedValue;
                    giaovien.IsActive = true;
                }

                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (flag == 2)
                Update();
            flag = 0;
            ListGiaoVien();
            txtQueQuan.Enabled = false;
            txtTenGv.Enabled = false;
            dtpNgaySinh.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void dtgGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in dtgGiaoVien.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txtIDGiaoVien.Text = row.Cells["GiaoVienID"].Value.ToString();
                    txtQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
                    dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                    txtTenGv.Text = row.Cells["TenGiaoVien"].Value.ToString();
                    cbbDayMon.Text = row.Cells["DayMon"].Value.ToString();
                }
            }
            catch(Exception ex) { }

        }

        private void dtgGiaoVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtQueQuan.Enabled = false;
            txtTenGv.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtIDGiaoVien.Enabled = false;
            cbbDayMon.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn chắc chắn muôn xóa??",
                         "Thông báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Delete();
            }
            else
            {
            }
            ListGiaoVien();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;

        }
        public void Delete()
        {
            db = new QuanLyContextDataDataContext();
            var query = from a in db.GiaoViens where a.GiaoVienID == Int32.Parse(txtIDGiaoVien.Text) select a;
            try
            {
                foreach (GiaoVien giaovien in query)
                {
                    giaovien.IsActive = false;
                }
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void Search()
        {
            QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();

            var list = from a in db.GiaoViens
                       join b in db.MonHocs
                       on a.MonHocID equals b.MonHocID
                       where b.IsActive == true && a.IsActive == true && (a.TenGiaoVien.Trim().Contains(txtTimKiem.Text) || a.QueQuan.Trim().Contains(txtTimKiem.Text) || b.TenMonHoc.Trim().Contains(txtTimKiem.Text) || a.GiaoVienID.ToString() ==(txtTimKiem.Text.ToString()))
                       select new
                       {
                           GiaoVienID = a.GiaoVienID,
                           b.TenMonHoc,
                           a.TenGiaoVien,
                           a.QueQuan,
                           a.NgaySinh,
                       };
            dtgGiaoVien.DataSource = list;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                ListGiaoVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            txtIDGiaoVien.Enabled = false;
            txtQueQuan.Enabled = false;
            txtTenGv.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbbDayMon.Enabled = false;

        }
        public void ComboMonHoc()
        {
            try
            {
                var combo = (from a in db.MonHocs select new { a.MonHocID, a.TenMonHoc }).ToList();
                cbbDayMon.DataSource = combo;
               cbbDayMon.ValueMember = "MonHocID";
                cbbDayMon.DisplayMember = "TenMonHoc";
            }
            catch (Exception ex)
            {

            }

        }

        private void cbbDayMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
