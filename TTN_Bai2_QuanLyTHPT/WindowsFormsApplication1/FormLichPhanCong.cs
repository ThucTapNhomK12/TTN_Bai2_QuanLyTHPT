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
    public partial class LichPhanCongg : Form
    {
        int flag;
        public LichPhanCongg()
        {
            InitializeComponent();

        }

        private void LichPhanCongg_Load(object sender, EventArgs e)
        {
            ListLichPhanCong();
            ComboGiaoVien();

        }
        QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();
        public void ListLichPhanCong()
        {

            var list = from a in db.GiaoViens
                       join b in db.LichPhanCongs
                       on a.GiaoVienID equals b.GiaoVienID
                       join c in db.MonHocs
                       on a.MonHocID equals c.MonHocID
                       where b.IsActive == true
                       select new
                       {
                           GiaoVienID = a.GiaoVienID,
                           a.TenGiaoVien,
                           DayMon = c.TenMonHoc,
                           b.ThoiGian,
                           b.GhiChu
                       };
            dtgLichPhanCong.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            txtGhiChu.Text = "";
            txtGiaoVienID.Text = "";
            //txtTenLopHoc.Text = "";
            txtThoiGianDay.Text = "";
            cbbGiaovien.Text = "";
           // txtTenLopHoc.Enabled = true;
            txtGhiChu.Enabled = true;
            txtThoiGianDay.Enabled = true;
            cbbGiaovien.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        public void ComboGiaoVien()
        {
            try
            {
                var list = (from a in db.LichPhanCongs
                            join b in db.GiaoViens
                            on a.GiaoVienID equals b.GiaoVienID
                            where a.IsActive == true
                            select new
                            {
                                a.GiaoVienID,
                                b.TenGiaoVien,

                            }).ToList();
                var combo = (from a in db.GiaoViens select new { a.GiaoVienID, a.TenGiaoVien }).ToList();
                var list2 = combo.Except(list).ToList();
                cbbGiaovien.DataSource = list2;
                cbbGiaovien.ValueMember = "GiaoVienID";
                cbbGiaovien.DisplayMember = "TenGiaoVien";
            }
            catch (Exception ex)
            {

            }

        }

        private void dtgLichPhanCong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in dtgLichPhanCong.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txtGiaoVienID.Text = row.Cells["GiaoVienID"].Value.ToString();
                    txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                 //   txtTenLopHoc.Text = row.Cells["DayMon"].Value.ToString();
                    txtThoiGianDay.Text = row.Cells["ThoiGian"].Value.ToString();
                    cbbGiaovien.Text = row.Cells["TenGiaoVien"].Value.ToString();
                }
            }
            catch (Exception ex) { }

        }

        private void dtgLichPhanCong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtThoiGianDay.Enabled = false;
            txtGiaoVienID.Enabled = false;
            txtGhiChu.Enabled = false;
          //  txtTenLopHoc.Enabled = false;
            cbbGiaovien.Enabled = false;
        }

        public void Insert()
        {
            db = new QuanLyContextDataDataContext();
            LichPhanCong lichphancong = new LichPhanCong();
            lichphancong.GhiChu = txtGhiChu.Text;
            lichphancong.GiaoVienID = (Int32)cbbGiaovien.SelectedValue;
            lichphancong.ThoiGian = txtThoiGianDay.Text;
            lichphancong.IsActive = true;
            db.LichPhanCongs.InsertOnSubmit(lichphancong);
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
            var query = from a in db.LichPhanCongs where a.GiaoVienID == Int32.Parse(txtGiaoVienID.Text) select a;
            try
            {
                foreach (LichPhanCong lichphancong in query)
                {
                    lichphancong.ThoiGian = txtThoiGianDay.Text;
                    lichphancong.GhiChu = txtGhiChu.Text;
                    lichphancong.IsActive = true;
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
            ListLichPhanCong();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
        }
        public void Delete()
        {
            db = new QuanLyContextDataDataContext();
            var query = from a in db.LichPhanCongs where a.GiaoVienID == Int32.Parse(txtGiaoVienID.Text) select a;
            try
            {
                foreach (LichPhanCong lichphancong in query)
                {
                    lichphancong.IsActive = false;
                }
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi phát sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtgLichPhanCong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtGhiChu.Enabled = false;
            txtGiaoVienID.Enabled = false;
            txtThoiGianDay.Enabled = false;
            cbbGiaovien.Enabled = false;
       //     txtTenLopHoc.Enabled = false;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (flag == 1)
                Insert();
            else if (flag == 2)
                Update();
            ListLichPhanCong();
            txtGhiChu.Enabled = false;
            txtThoiGianDay.Enabled = false;
            txtGiaoVienID.Enabled = false;
            // txtTenLopHoc.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            flag = 2;
            txtGhiChu.Enabled = true;
            //     txtTenLopHoc.Enabled = true;
            //cbbGiaovien.Enabled = true;
            txtThoiGianDay.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                ListLichPhanCong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Search();
        }
        public void Search()
        {
            QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();

            var list = from a in db.GiaoViens
                       join b in db.LichPhanCongs
                       on a.GiaoVienID equals b.GiaoVienID
                       join c in db.MonHocs
                       on a.MonHocID equals c.MonHocID
                       where b.IsActive == true && (a.TenGiaoVien.Trim().Contains(txtTimKiem.Text) || b.GhiChu.Trim().Contains(txtTimKiem.Text) || b.ThoiGian.Trim().Contains(txtTimKiem.Text)|| c.TenMonHoc.Trim().Contains(txtTimKiem.Text) || a.GiaoVienID.ToString() == txtTimKiem.Text.ToString())
                       select new
                       {
                           GiaoVienID = a.GiaoVienID,
                           a.TenGiaoVien,
                           DayMon = c.TenMonHoc,
                           b.ThoiGian,
                           b.GhiChu
                       };
            dtgLichPhanCong.DataSource = list;

        }

        private void LichPhanCongg_Load_1(object sender, EventArgs e)
        {

        }
    }
}
