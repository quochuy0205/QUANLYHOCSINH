using BussinessLayer.DTO;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class VIPHAM_CT
    {
        QUANLYHOCSINHEntities1 db = null;
        public VIPHAM_CT()
        {
            db = new QUANLYHOCSINHEntities1();
        }

        public List<tb_ViPham_CT> getList(int mavp)
        {
            return db.tb_ViPham_CT.Where(x=>x.MaViPham==mavp).ToList();
        }

        public List<VIPHAM_CT_DTO> getListFull(int mavp)
        {
            var lst = db.tb_ViPham_CT.Where(x => x.MaViPham == mavp).ToList();
            List<VIPHAM_CT_DTO> lstDTO = new List<VIPHAM_CT_DTO>();
            VIPHAM_CT_DTO dto;
            foreach(var item in lst)
            {
                dto = new VIPHAM_CT_DTO();
                dto.MaViPham= item.MaViPham;
                dto.MaVPCT = item.MaVPCT;
                dto.MaHS = item.MaHS;
                dto.MaLoi = item.MaLoi;
                dto.NgayViPham= item.NgayViPham;
                dto.Diem = item.Diem;
                dto.GhiChu= item.GhiChu;
                var loi = db.tb_DanhMucLoi.FirstOrDefault(x=>x.MAVP == item.MaLoi);
                dto.TENLOI = loi.TENVP;
                var hs = db.tb_HocSinh.FirstOrDefault(x=>x.MaHS == item.MaHS);
                dto.TENHS = hs.Ten;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }

        public tb_ViPham_CT getitem(int mavpct)
        {
            return db.tb_ViPham_CT.FirstOrDefault(x=>x.MaVPCT==mavpct);
        }

        public tb_ViPham_CT Add(tb_ViPham_CT vpct)
        {
            try
            {
                db.tb_ViPham_CT.Add(vpct);
                db.SaveChanges();
                return vpct;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:" + ex.Message);
            }
        }

        public tb_ViPham_CT Update(tb_ViPham_CT vpct)
        {
            try
            {
                var _vpct = db.tb_ViPham_CT.FirstOrDefault(x => x.MaVPCT == vpct.MaVPCT);
                _vpct.MaHS = vpct.MaHS;
                _vpct.MaLoi = vpct.MaLoi;
                _vpct.MaViPham= vpct.MaViPham;
                _vpct.NgayViPham = vpct.NgayViPham;
                _vpct.Diem = vpct.Diem;
                _vpct.GhiChu = vpct.GhiChu;
                db.SaveChanges();
                return vpct;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }

        public void Delete(int mavpct)
        {
            var _vpct = db.tb_ViPham_CT.FirstOrDefault(x => x.MaVPCT == mavpct);
            db.tb_ViPham_CT.Remove(_vpct);
            db.SaveChanges();

        }
    }
}
