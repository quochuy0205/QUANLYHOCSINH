using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class KHOILOP
    {
        QUANLYHOCSINHEntities1 db = null;

        public KHOILOP() { 
        db = new QUANLYHOCSINHEntities1();
        }

        public List<tb_KhoiLop> getList()
        {
            return db.tb_KhoiLop.ToList();
        }

        public tb_KhoiLop getItem(int makl)
        {
            return db.tb_KhoiLop.FirstOrDefault(x=>x.MaKL== makl);
        }

        public tb_KhoiLop Add(tb_KhoiLop kl)
        {
            try
            {
                db.tb_KhoiLop.Add(kl);
                db.SaveChanges();
                return kl;
            }
            catch(Exception ex)
            {
                throw new Exception("LOI:"+ex.Message);
            }
        }

        public tb_KhoiLop Update(tb_KhoiLop kl)
        {
            try
            {
                var _kl = db.tb_KhoiLop.FirstOrDefault(x => x.MaKL == kl.MaKL);
                _kl.TenKL = kl.TenKL;
                db.SaveChanges();
                return kl;
            }
            catch(Exception ex) 
            {
                throw new Exception("Loi:"+ex.Message);
            }
        }

        public void Delete (int makl)
        {
            try
            {
                var _kl = db.tb_KhoiLop.FirstOrDefault(x => x.MaKL == makl);
                db.tb_KhoiLop.Remove(_kl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:"+ex.Message);
            }
        }
    }
}
