using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class DM_VIPHAM
    {
        QUANLYHOCSINHEntities db = null;

        public DM_VIPHAM()
        {
            db = new QUANLYHOCSINHEntities();
        }
        
        public List<tb_DanhMucLoi> getlist()
        {
            return db.tb_DanhMucLoi.ToList();
        }

        public tb_DanhMucLoi getItem(int mavp)
        {
            return db.tb_DanhMucLoi.FirstOrDefault(x=>x.MAVP== mavp);
        }

        public tb_DanhMucLoi Add(tb_DanhMucLoi vp)
        {
            try
            {
                db.tb_DanhMucLoi.Add(vp);
                db.SaveChanges();
                return vp;
            }
            catch(Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }

        public tb_DanhMucLoi Update(tb_DanhMucLoi vp)
        {
            try
            {
                var _vp = db.tb_DanhMucLoi.FirstOrDefault(x=>x.MAVP == vp.MAVP);
                _vp.TENVP = vp.TENVP;
                _vp.GHICHU = vp.GHICHU;
                _vp.DIEM = vp.DIEM;
                _vp.NGHIEMTRONG = vp.NGHIEMTRONG;
                _vp.UPDATED_BY = vp.UPDATED_BY;
                _vp.UPDATED_DATE = vp.UPDATED_DATE;
                db.SaveChanges();
                return vp;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }

        public void Delete(int mavp, int UserID)
        {
            try
            {
                var _vp = db.tb_DanhMucLoi.FirstOrDefault(x=>x.MAVP == mavp);
                _vp.UPDATED_BY = UserID;
                _vp.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
            }
             catch (Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }
    }
}
