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
    public partial class FormLopHoc : Form
    {
        QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();
        int flag;
        public FormLopHoc()
        {
            InitializeComponent();
        }

        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            ListLopHoc();
            ComboLopHoc();

        }

        private void lblTenHocSinh_Click(object sender, EventArgs e)
        {

        }
        public void ListLopHoc()
        {

            var list = from a in db.GiaoViens
                       join b in db.LopHocs
                       on a.GiaoVienID equals b.GiaoVienID
                       where a.IsActive == true && a.IsActive == true
                       select new
                       {
                           LopHocID = b.LopHocID,
                           GiaoVienID = a.GiaoVienID,
                           TenLopHoc = b.TenLopHoc,
                           a.TenGiaoVien,
                       };
            dtgLopHoc.DataSource = list;
        }
        public void ComboLopHoc()
        {
            try
            {
                var combo = (from a in db.GiaoViens where a.IsActive==true select new { a.GiaoVienID, a.TenGiaoVien }).ToList();
                var list = (from a in db.GiaoViens
                                      join b in db.LopHocs
                                      on a.GiaoVienID equals b.GiaoVienID
                                      where a.IsActive == true && a.IsActive == true
                                      select new
                                      {
                                          GiaoVienID = a.GiaoVienID,
                                          a.TenGiaoVien,
                                      }).ToList();
                var list2 = combo.Except(list).ToList();
                cbbGiaovien.DataSource = list2;
                cbbGiaovien.ValueMember = "GiaoVienID";
                cbbGiaovien.DisplayMember = "TenGiaoVien";
            }
            catch (Exception ex)
            {

            }

        }
        public void Insert()
        {
            db = new QuanLyContextDataDataContext();
            LopHoc lophoc = new LopHoc();
            lophoc.TenLopHoc = txtTenLopHoc.Text;
            lophoc.GiaoVienID = (Int32)cbbGiaovien.SelectedValue;
            lophoc.IsActive = true;
            db.LopHocs.InsertOnSubmit(lophoc);
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
            var query = from a in db.LopHocs where a.LopHocID == Int32.Parse(txtIDLopHoc.Text) select a;
            try
            {
                foreach (LopHoc lophoc in query)
                {
                    lophoc.TenLopHoc = txtTenLopHoc.Text;
                    lophoc.GiaoVienID = (Int32)cbbGiaovien.SelectedValue;
                    lophoc.IsActive = true;
                }

                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                       join b in db.LopHocs
                       on a.GiaoVienID equals b.GiaoVienID
                       where  b.IsActive == true && a.IsActive == true && (a.TenGiaoVien.Trim().Contains(txtTimKiem.Text) || b.TenLopHoc.Trim().Contains(txtTimKiem.Text))    
                       select new
                       {
                           LopHocID = b.LopHocID,
                           GiaoVienID = a.GiaoVienID,
                           TenLopHoc = b.TenLopHoc,
                           a.TenGiaoVien,
                       };
            dtgLopHoc.DataSource = list;

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
             ListLopHoc();
        }
        public void Delete()
        {
            db = new QuanLyContextDataDataContext();
            var query = from a in db.LopHocs where a.LopHocID == Int32.Parse(txtIDLopHoc.Text) select a;
            try
            {
                foreach (LopHoc lophoc in query)
                {
                    lophoc.IsActive = false;
                }
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            flag = 1;
            txtIDLopHoc.Text = "";
            txtTenLopHoc.Text = "";
            cbbGiaovien.Text = "";
            txtTenLopHoc.Enabled = true;
            cbbGiaovien.Enabled = true;
        }

        private void cbbDayMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            txtTenLopHoc.Enabled = true;
            cbbGiaovien.Enabled = true;
            txtIDLopHoc.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
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
            ListLopHoc();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Insert();
            else if (flag == 2)
                Update();
            ListLopHoc();
            ComboLopHoc();
            txtIDLopHoc.Enabled = false;
            txtTenLopHoc.Enabled = false;
            cbbGiaovien.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void dtgLopHoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIDLopHoc.Enabled = false;
            txtTenLopHoc.Enabled = false;
            cbbGiaovien.Enabled = false;
        }

        private void dtgLopHoc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in dtgLopHoc.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txtIDLopHoc.Text = row.Cells["LopHocID"].Value.ToString();
                    txtTenLopHoc.Text = row.Cells["TenLopHoc"].Value.ToString();
                    cbbGiaovien.Text = row.Cells["TenGiaoVien"].Value.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
         //   try
         //   {
                Search();
       //     }
          //  catch { }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            txtIDLopHoc.Enabled = false;
            txtTenLopHoc.Enabled = false;
            cbbGiaovien.Enabled = false;
        }

        private void cbbGiaovien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ComboLopHoc();
        }
    }
}
