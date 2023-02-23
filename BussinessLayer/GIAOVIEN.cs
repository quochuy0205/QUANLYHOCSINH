using BussinessLayer.DTO;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class GIAOVIEN
    {
        QUANLYHOCSINHEntities db = null;
        public GIAOVIEN()
        {
             db = new QUANLYHOCSINHEntities();
        }
        public tb_GiaoVien getItem(int maGV)
        {
            return db.tb_GiaoVien.FirstOrDefault(x=>x.MAGV== maGV);
        }
        public List<GiaoVienDTO> getList()
        {
            var lst = db.tb_GiaoVien.ToList();
            List<GiaoVienDTO> lsGV = new List<GiaoVienDTO>();
            GiaoVienDTO gvDTO;
            foreach(var item in lst)
            {
                gvDTO = new GiaoVienDTO();
                gvDTO.MAGV = item.MAGV;
                gvDTO.HOTEN = item.HOTEN;
                gvDTO.TEN= item.TEN;
                gvDTO.GIOITINH = item.GIOITINH;
                gvDTO.NGAYSINH= item.NGAYSINH;
                gvDTO.DIACHI = item.DIACHI;
                gvDTO.DIENTHOAI = item.DIENTHOAI;
                gvDTO.EMAIL = item.EMAIL;
                gvDTO.HINHANH = item.HINHANH;
                gvDTO.MaTD = item.MaTD;
               var td = db.tb_TrinhDo.FirstOrDefault(t=>t.MaTD== item.MaTD);
                gvDTO.TenTD = td.TenTD;
                gvDTO.MaCV = item.MaCV;
                var cv = db.tb_ChucVu.FirstOrDefault(g => g.MaCV == item.MaCV);
                gvDTO.TenCV = cv.TenCV;
                gvDTO.CREATED_BY= item.CREATED_BY;
                gvDTO.CREATED_DATE= item.CREATED_DATE;
                gvDTO.UPDATED_BY = item.UPDATED_BY;
                gvDTO.UPDATED_DATE = item.UPDATED_DATE; 
                gvDTO.DELETED_BY= item.DELETED_BY;
                gvDTO.DELETED_DATE = item.DELETED_DATE;
                lsGV.Add(gvDTO);
            }
            return lsGV;
        }
        public tb_GiaoVien Add(tb_GiaoVien gv)
        {
            try
            {
                db.tb_GiaoVien.Add(gv);
                db.SaveChanges();
                return gv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }

        public tb_GiaoVien Update(tb_GiaoVien gv)
        {
            try
            {
                var _gv = db.tb_GiaoVien.FirstOrDefault(x=>x.MAGV== gv.MAGV);
                _gv.HOTEN = gv.HOTEN;
                _gv.TEN = gv.TEN;
                _gv.GIOITINH = gv.GIOITINH;
                _gv.NGAYSINH = gv.NGAYSINH;
                _gv.DIACHI = gv.DIACHI;
                _gv.DIENTHOAI = gv.DIENTHOAI;
                _gv.EMAIL = gv.EMAIL;
                _gv.MaTD = gv.MaTD;
                _gv.MaCV = gv.MaCV;
                _gv.UPDATED_BY = gv.UPDATED_BY;
                _gv.UPDATED_DATE = gv.UPDATED_DATE;
                db.SaveChanges();
                return gv;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }

        public void Delete(int id, int uid)
        {
            try
            {
                var _gv = db.tb_GiaoVien.FirstOrDefault(x => x.MAGV == id);

                _gv.DELETED_BY = uid;
                _gv.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi" + ex.Message);
            }
        }
    }
}
