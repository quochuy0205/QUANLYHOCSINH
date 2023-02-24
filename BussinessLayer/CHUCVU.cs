using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CHUCVU
    {
        QUANLYHOCSINHEntities1 db = null;
        public CHUCVU()
        {
            db =  new QUANLYHOCSINHEntities1();
        }

        public List<tb_ChucVu> getList()
        {
            return db.tb_ChucVu.ToList();
        }
    }
}
