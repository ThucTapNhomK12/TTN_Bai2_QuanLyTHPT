using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2ThucTapNhom
{
        public class QuaLyModels
        {

        }
    public class HocSinhModels
    {
        int HocSinhID { get; set; }
        string TenHocSinh { get; set; }
        int LopHocID { get; set; }
        string NgaySinh { get; set; }
        string QueQuan { get; set; }
        bool IsActive { get; set; }
    }
}
