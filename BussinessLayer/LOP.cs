using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class LOP
    {
        QUANLYHOCSINHEntities1 db = null;

        public LOP()
        {
            db = new QUANLYHOCSINHEntities1();
        }

        public List<tb_Lop> getList()
        {
            return db.tb_Lop.ToList();
        }

        public tb_Lop getItem(int malop)
        {
            return db.tb_Lop.FirstOrDefault(x=>x.MaLop==malop);
        }

        public tb_Lop Add(tb_Lop lp)
        {
            try
            {
                db.tb_Lop.Add(lp);
                db.SaveChanges();
                return lp;
            }
            catch(Exception ex) 
            {
                throw new Exception("LOI:"+ex.Message);
            }
        }

        public tb_Lop Update(tb_Lop lp)
        {
            try
            {
                var _lop = db.tb_Lop.FirstOrDefault(x => x.MaLop == lp.MaLop);
                _lop.TenLop = lp.TenLop;
                _lop.GhiChu = lp.GhiChu;
                _lop.SapXep = lp.SapXep;
                _lop.MaTruong = lp.MaTruong;
                _lop.MaKL = lp.MaKL;
                _lop.Updated_By = lp.Updated_By;
                _lop.Updated_Date = lp.Updated_Date;
                db.SaveChanges();
                return lp;
            }
            catch(Exception ex)
            {
                throw new Exception("LOI:" + ex.Message);
            }
        }
    }
}
