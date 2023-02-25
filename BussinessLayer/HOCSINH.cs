using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class HOCSINH
    {
        QUANLYHOCSINHEntities1 db = null;
        public HOCSINH() 
        {
            db = new QUANLYHOCSINHEntities1();
        }

        public List<tb_HocSinh> getList()
        {
            return db.tb_HocSinh.ToList();
        }
    }
}
