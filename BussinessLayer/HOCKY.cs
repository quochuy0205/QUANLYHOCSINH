using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class HOCKY
    {
        QUANLYHOCSINHEntities1 db = null;
        public HOCKY() 
        {
        db = new QUANLYHOCSINHEntities1();
        }

        public List<tb_HocKy> getList()
        {
            return db.tb_HocKy.ToList();
        }

        public tb_HocKy getItem(int mahk)
        {
            return db.tb_HocKy.FirstOrDefault(x=>x.MaHK== mahk);
        }

        public tb_HocKy Add(tb_HocKy hk)
        {
            try
            {
                db.tb_HocKy.Add(hk);
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("LOI:" + ex.Message);
            }
        }

        public tb_HocKy Update(tb_HocKy hk)
        {
            try
            {
                var _hk = db.tb_HocKy.FirstOrDefault(x => x.MaHK == hk.MaHK);
                _hk.TenHK = hk.TenHK;
                _hk.HeSo= hk.HeSo;
                _hk.Updated_By= hk.Updated_By;
                _hk.Updated_Date = hk.Updated_Date;
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("LOI:" + ex.Message);
            }
        }
    }
}
