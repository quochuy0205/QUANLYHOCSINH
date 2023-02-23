using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
   public class NAMHOC
    {
        QUANLYHOCSINHEntities db = null;
        public  NAMHOC()
            {
            db = new QUANLYHOCSINHEntities();
            }
        //Lay danh sach nam hoc
        public List<tb_NamHoc> getList()
        {
            return db.tb_NamHoc.ToList();
        }
        //Them Nam Hoc
        public tb_NamHoc Add(tb_NamHoc nh)
        {
            try
            {
                db.tb_NamHoc.Add(nh);
                db.SaveChanges();
                return nh;
            }
            catch(Exception ex)
            { 
                throw new Exception("Loi"+ex.Message);
            }
        }

        //lay ma nam hoc
        public tb_NamHoc getItem(int manamhoc)
        {
            return db.tb_NamHoc.FirstOrDefault(x=>x.MaNamHoc==manamhoc);
        }

        //Sua cap nhat ma nam hoc
        public tb_NamHoc Update(tb_NamHoc nh)
        {
            try
            {
             var _nh = db.tb_NamHoc.FirstOrDefault(x=>x.MaNamHoc==nh.MaNamHoc);
                _nh.TenNamHoc = nh.TenNamHoc;
                _nh.Updated_By = nh.Updated_By;
                _nh.Updated_Date = nh.Updated_Date;
                db.SaveChanges();
                return nh;
            }
            catch(Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }

        public void Delete(int manh, int UserID)
        {
            try
            {
                var _nh = db.tb_NamHoc.FirstOrDefault(x => x.MaNamHoc == manh);
                _nh.Deleted_By = UserID;
                _nh.Deleted_Date = DateTime.Now;
                db.SaveChanges();
           
            }
            catch(Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }
    }
}
