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
    public partial class DiemHS : Form
    {
        public DiemHS()
        {
            InitializeComponent();
        }
        QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();
        int flag;
        private void DiemHS_Load(object sender, EventArgs e)
        {
            DiemHocSinh();
            ComboMonHoc();
            ComboHocSinh();
            cbbMonhoc.Text = "Tất cả HS các lớp";
            cbbHocSinh.Text = "Tất cả học sinh";

        }
        public void DiemHocSinhTheoMon()
        {
            if (cbbMonhoc.SelectedValue != null)
            {
                var list = (from a in db.HocSinhs
                            join b in db.Diems on a.HocSinhID equals b.HocSinhID
                            join c in db.MonHocs on b.MonHocID equals c.MonHocID
                            join e in db.LopHocs on a.LopHocID equals e.LopHocID
                            where a.IsActive == true && b.IsActive == true && c.IsActive == true && e.IsActive == true
                            && c.MonHocID == (Int32)cbbMonhoc.SelectedValue
                            select new
                            {
                                HocSinhID = b.HocSinhID,
                                TenHocSinh = a.TenHocSinh,
                                b.DiemSo,
                                e.TenLopHoc,
                                c.TenMonHoc
                            }).ToList();
                dtgDiemSo.DataSource = list;
                ColumnsHS();
            }
        }
        public void DiemHocSinh()
        {
                var list = (from a in db.HocSinhs
                            join b in db.Diems on a.HocSinhID equals b.HocSinhID
                            join c in db.MonHocs on b.MonHocID equals c.MonHocID
                            join e in db.LopHocs on a.LopHocID equals e.LopHocID
                            where a.IsActive == true && b.IsActive == true && c.IsActive == true && e.IsActive == true
                            select new
                            {
                                HocSinhID = b.HocSinhID,
                                TenHocSinh = a.TenHocSinh,
                                b.DiemSo,
                                e.TenLopHoc,
                                c.TenMonHoc
                            }).ToList();
                dtgDiemSo.DataSource = list;
            ColumnsHS();
        }
        public void ComboMonHoc()
        {
            try
            {
                var combo = (from a in db.MonHocs select new { a.MonHocID, a.TenMonHoc }).ToList();
                cbbMonhoc.DataSource = combo;
                cbbMonhoc.ValueMember = "MonHocID";
                cbbMonhoc.DisplayMember = "TenMonHoc";
            }
            catch (Exception ex)
            {

            }

        }
        public void ComboHocSinh()
        {
            try
            {
                var combo = (from a in db.HocSinhs select new { a.HocSinhID, a.TenHocSinh }).ToList();
                cbbHocSinh.DataSource = combo;
                cbbHocSinh.ValueMember = "HocSinhID";
                cbbHocSinh.DisplayMember = "TenHocSinh";
            }
            catch (Exception ex)
            {

            }

        }


        private void cbbMonhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2)
            {
            }
            else
            {
                DiemHocSinhTheoMon();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            cbbHocSinh.Text = "";
            txtDiem.Text = "";
            cbbMonhoc.Text = "";
            txtTenLop.Enabled = false;
            cbbHocSinh.Enabled = true;
            txtDiem.Enabled = true;
            txtHS.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            txtTenLop.Enabled = false;
            cbbHocSinh.Enabled = false;
            txtDiem.Enabled = true;
            txtHS.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }
        public void Insert()
        {
            db = new QuanLyContextDataDataContext();
            Diem diem = new Diem();
            diem.HocSinhID = (Int32)cbbHocSinh.SelectedValue;
            diem.DiemSo = double.Parse(txtDiem.Text);
            diem.MonHocID = (Int32)cbbMonhoc.SelectedValue;
            diem.IsActive = true;
            db.Diems.InsertOnSubmit(diem);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void Update()
        {
            db = new QuanLyContextDataDataContext();
            var query = from a in db.Diems where a.HocSinhID == Int32.Parse(cbbHocSinh.Text) && a.MonHocID == (Int32)cbbMonhoc.SelectedValue select a;
            try
            {
                foreach (Diem diem in query)
                {
                diem.DiemSo = double.Parse(txtDiem.Text);
                    diem.IsActive = true;
                }

                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Có lỗi phát sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
         }
        public void Delete()
        {
            db = new QuanLyContextDataDataContext();
            var query = from a in db.Diems where a.HocSinhID == Int32.Parse(cbbHocSinh.Text) && a.MonHocID == (Int32)cbbMonhoc.SelectedValue select a;
            try
            {
                foreach (Diem diem in query)
                {
                    diem.IsActive = false;
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
            DiemHocSinhTheoMon();
            txtDiem.Enabled = false;
            txtHS.Enabled = false;
            txtTenLop.Enabled = false;
            cbbHocSinh.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void dtgDiemSo_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dtgDiemSo.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                cbbHocSinh.Text = row.Cells["HocSinhID"].Value.ToString();
                txtHS.Text = row.Cells["TenHocSinh"].Value.ToString();
                cbbMonhoc.Text = row.Cells["TenMonHoc"].Value.ToString();
                txtDiem.Text = row.Cells["DiemSo"].Value.ToString();
                txtTenLop.Text = row.Cells["TenLopHoc"].Value.ToString();
            }
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
            DiemHocSinhTheoMon();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            flag = 0;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                DiemHocSinh();
        }
        public void Search()
        {
            var list = (from a in db.HocSinhs
                        join b in db.Diems on a.HocSinhID equals b.HocSinhID
                        join c in db.MonHocs on b.MonHocID equals c.MonHocID
                        join e in db.LopHocs on a.LopHocID equals e.LopHocID
                        where a.IsActive == true && b.IsActive == true && c.IsActive == true && e.IsActive == true
                        && (a.TenHocSinh.Trim().Contains(txtTimKiem.Text) || e.TenLopHoc.Trim().Contains(txtTimKiem.Text) || c.TenMonHoc.Trim().Contains(txtTimKiem.Text) || b.HocSinhID.ToString() == (txtTimKiem.Text.ToString()))
                        select new
                        {
                            HocSinhID = b.HocSinhID,
                            TenHocSinh = a.TenHocSinh,
                            b.DiemSo,
                            e.TenLopHoc,
                            c.TenMonHoc
                        }).ToList();
            dtgDiemSo.DataSource = list;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void ColumnsHS()
        {
            dtgDiemSo.Columns["TenHocSinh"].HeaderText = "Tên Học Sinh";
            dtgDiemSo.Columns["HocSinhID"].HeaderText = "Mã Học Sinh";
            dtgDiemSo.Columns["DiemSo"].HeaderText = "Điểm Số";
            dtgDiemSo.Columns["TenLopHoc"].HeaderText = "Lớp học";
            dtgDiemSo.Columns["TenMonHoc"].HeaderText = "Môn học";
        }

        private void btnTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            txtDiem.Enabled = false;
            txtHS.Enabled = false;
            txtTenLop.Enabled = false;
            cbbHocSinh.Enabled = false;
            flag = 0;
        }

        private void dtgDiemSo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDiem.Enabled = false;
            txtHS.Enabled = false;
            txtTenLop.Enabled = false;
            cbbHocSinh.Enabled = false;
        }
    }
}
