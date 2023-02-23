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
        QUANLYHOCSINHEntities db = null;
        public TRINHDO()
        {
             db = new QUANLYHOCSINHEntities();
        }
        public List<tb_TrinhDo> getList()
        {
            return db.tb_TrinhDo.ToList();
        }
    }
}
