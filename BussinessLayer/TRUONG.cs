using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TRUONG
    {
        QUANLYHOCSINHEntities1 db = null;
        public TRUONG()
        {
            db = new QUANLYHOCSINHEntities1();
        }

        public List<tb_Truong> getList()
        {
            return db.tb_Truong.ToList();
        }

        public tb_Truong getItem(int matruong)
        {
            return db.tb_Truong.FirstOrDefault(x=>x.MaTruong== matruong);
        }

        public tb_Truong Add(tb_Truong truong)
        {
            try
            {
                db.tb_Truong.Add(truong);
                db.SaveChanges();
                return truong;
            }
            catch(Exception ex)
            {
                throw new Exception("LOI:"+ex.Message);
            }
        }



        public tb_Truong Update(tb_Truong truong)
        {
            try
            {
                var _truong = db.tb_Truong.FirstOrDefault(x => x.MaTruong == truong.MaTruong);
                _truong.TenTruong = truong.TenTruong;
                _truong.Email = truong.Email;
                _truong.DienThoai = truong.DienThoai;
                _truong.DiaChi = truong.DiaChi;
                _truong.Updated_By= truong.Updated_By;
                db.SaveChanges();
                return truong;
            }
            catch (Exception ex)
            {
                throw new Exception("LOI:" + ex.Message);
            }
        }
    }
}
