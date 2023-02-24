using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TRINHDO
    {
        QUANLYHOCSINHEntities1 db = null;
        public TRINHDO()
        {
             db = new QUANLYHOCSINHEntities1();
        }
        public List<tb_TrinhDo> getList()
        {
            return db.tb_TrinhDo.ToList();
        }
    }
}
