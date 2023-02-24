using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.DTO
{
    public class VIPHAM_CT_DTO
    {
        public int MaVPCT { get; set; }
        public Nullable<int> MaViPham { get; set; }
        public Nullable<int> MaLoi { get; set; }

        public string TENLOI { get; set; }
        public Nullable<int> Diem { get; set; }
        public Nullable<int> MaHS { get; set; }

        public string TENHS { get; set; }
        public Nullable<System.DateTime> NgayViPham { get; set; }
        public string GhiChu { get; set; }
    }
}
