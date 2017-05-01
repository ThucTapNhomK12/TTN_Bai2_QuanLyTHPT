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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        QuanLyContextDataDataContext db = new QuanLyContextDataDataContext();
        private void ThongKe_Load(object sender, EventArgs e)
        {
            DiemHocSinh();
            ComboMonHoc();
        }
        public void DiemHocSinhTheoMon()
        {
            if (cbbMonhoc.SelectedValue != null)
            {
                var list = (from a in db.HocSinhs
                            join b in db.Diems on a.HocSinhID equals b.HocSinhID
                            join c in db.MonHocs on b.MonHocID equals c.MonHocID
                            join e in db.LopHocs on a.LopHocID equals e.LopHocID
                            where a.IsActive == true && b.IsActive == true && c.IsActive == true
                            && c.MonHocID == (Int32)cbbMonhoc.SelectedValue 
                            select new
                            {
                                HocSinhID = b.HocSinhID,
                                TenHocSinh = a.TenHocSinh,
                                b.DiemSo,
                                e.TenLopHoc,
                                c.TenMonHoc
                            }).OrderByDescending(z=>z.DiemSo).ToList();
                dtgThongKe.DataSource = list;
            }
        }
        public void DiemHocSinh()
        {
            var list = (from a in db.HocSinhs
                        join b in db.Diems on a.HocSinhID equals b.HocSinhID
                        join c in db.MonHocs on b.MonHocID equals c.MonHocID
                        join e in db.LopHocs on a.LopHocID equals e.LopHocID
                        where a.IsActive == true && b.IsActive == true && c.IsActive == true
                        select new
                        {
                            HocSinhID = b.HocSinhID,
                            TenHocSinh = a.TenHocSinh,
                            b.DiemSo,
                            e.TenLopHoc,
                            c.TenMonHoc
                        }).OrderByDescending(z => z.DiemSo).ToList();
            dtgThongKe.DataSource = list;
        }

        private void cbbMonhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DiemHocSinhTheoMon();
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
    }
}
