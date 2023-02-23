using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.DTO
{
    public class GiaoVienDTO
    {
        public int MAGV { get; set; }
        public string HOTEN { get; set; }
        public string TEN { get; set; }
        public Nullable<int> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public byte[] HINHANH { get; set; }
        public string DIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public Nullable<int> MaTD { get; set; }
        public Nullable<int> MaCV { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }

        public string TenTD { get; set; }
        public string TenCV { get; set; }
    }
}
