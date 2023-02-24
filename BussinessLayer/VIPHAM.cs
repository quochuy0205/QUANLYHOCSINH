using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class VIPHAM
    {
        QUANLYHOCSINHEntities1 db = null;

        public VIPHAM()
        {
            db = new QUANLYHOCSINHEntities1();
        }

        public List<tb_ViPham> getList()
        {
            return db.tb_ViPham.ToList();
        }

        public tb_ViPham getItem(int mavp)
        {
            return db.tb_ViPham.FirstOrDefault(x=>x.MaViPham==mavp);
        }

        public tb_ViPham Add(tb_ViPham vp)
        {
            try
            {
                db.tb_ViPham.Add(vp);
                db.SaveChanges();
                return vp;
            }
            catch(Exception ex)
            {
                throw new Exception("Loi:"+ ex.Message);
            }
        }

        public tb_ViPham Update(tb_ViPham vp)
        {
            try
            {
                var _vp = db.tb_ViPham.FirstOrDefault(x => x.MaViPham == vp.MaViPham);
                _vp.MaNamHoc = vp.MaNamHoc;
                _vp.MaHK =  vp.MaHK;
                _vp.MaLop= vp.MaLop;
                _vp.NgayViPham= vp.NgayViPham;
                _vp.TongSoLoi = vp.TongSoLoi;
                _vp.TongDiem = vp.TongDiem;
                _vp.Updated_By = vp.Updated_By;
                _vp.Updated_Date = vp.Updated_Date;
                _vp.GhiChu = vp.GhiChu;
                db.SaveChanges();    
                return vp;
            }
            catch(Exception ex ) 
            { 
                throw new Exception("Loi"+ex.Message);
            }
        }

        public void Delete (int mavp, int idUser)
        {
                var _vp = db.tb_ViPham.FirstOrDefault(x=>x.MaViPham==mavp);
            _vp.Deleted_By = idUser;
            _vp.Deleted_Date= DateTime.Now;
            db.SaveChanges();
                
        }
    }
}
