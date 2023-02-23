using BussinessLayer;
using DataAccessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        bool _them;
        GIAOVIEN _giaovien;
        TRINHDO _trinhdo;
        CHUCVU _chucvu;
        int _id = 0;
        int gioitinh = 0;
        void LoadData()
        {
            _giaovien = new GIAOVIEN();
            _trinhdo = new TRINHDO();
            _chucvu = new CHUCVU();
            gdDanhSach.DataSource = _giaovien.getList();
            gvGiaoVien.OptionsBehavior.Editable = false;
            
        }
        void LoadTrinhDo()
        {
            cbTrinhDo.DataSource = _trinhdo.getList();
            cbTrinhDo.DisplayMember = "TenTD";
            cbTrinhDo.ValueMember = "MaTD";
         
        }
        
        void LoadChucVu()
        {
            cbcv.DataSource = _chucvu.getList();
            cbcv.DisplayMember = "TenCV";
            cbcv.ValueMember = "MaCV";
        }
        void ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txthoten.Enabled = !kt;
            txtdiachi.Enabled = !kt;
            txtdienthoai.Enabled = !kt;
            txtemail.Enabled = !kt;
            checkbgioitinh.Enabled = !kt;
            btnHinh.Enabled = !kt;
            cbcv.Enabled = !kt;
            cbTrinhDo.Enabled = !kt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowHide(false);
            _them = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ShowHide(false);
            _them = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            LoadData();
            ShowHide(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ShowHide(false);
            _them = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            ShowHide(true);
            _giaovien = new GIAOVIEN();
            LoadData();
            LoadChucVu();
            LoadTrinhDo();
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        void SaveData()
        {
            if (_them)
            {
                tb_GiaoVien gv = new tb_GiaoVien();
                gv.HOTEN = txthoten.Text;
                gv.GIOITINH = gioitinh;
                int index = gv.HOTEN.LastIndexOf("");
                gv.TEN = gv.HOTEN.Substring(index);
                gv.NGAYSINH = dtngaysinh.Value;
                gv.EMAIL = txtemail.Text;
                gv.DIENTHOAI = txtdienthoai.Text;
                gv.DIACHI = txtdiachi.Text;
                gv.MaCV = int.Parse(cbcv.SelectedValue.ToString());
                gv.MaTD = int.Parse(cbTrinhDo.SelectedValue.ToString());
                gv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                gv.CREATED_BY = Commons.UserStatic.UID;
                gv.CREATED_DATE = DateTime.Now;
                _giaovien.Add(gv);
            }
            else
            {
                tb_GiaoVien gv = _giaovien.getItem(_id);
                gv.HOTEN = txthoten.Text;
                gv.GIOITINH = gioitinh;
                int index = gv.HOTEN.LastIndexOf("");
                gv.TEN = gv.HOTEN.Substring(index);
                gv.NGAYSINH = dtngaysinh.Value;
                gv.EMAIL = txtemail.Text;
                gv.DIENTHOAI = txtdienthoai.Text;
                gv.DIACHI = txtdiachi.Text;
                gv.MaCV = int.Parse(cbcv.SelectedValue.ToString());
                gv.MaTD = int.Parse(cbTrinhDo.SelectedValue.ToString());
                gv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                gv.UPDATED_BY = Commons.UserStatic.UID;
                gv.UPDATED_DATE = DateTime.Now;
                _giaovien.Update(gv);
            }


        }

        private void checkbgioitinh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbgioitinh.Checked)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
        }

        private void gdDanhSach_Click(object sender, EventArgs e)
        {
            if (gvGiaoVien.RowCount > 0)
            {
                _id = int.Parse(gvGiaoVien.GetFocusedRowCellValue("MAGV").ToString());
                var gv = _giaovien.getItem(_id);
                txthoten.Text = gv.HOTEN;
                txtdienthoai.Text = gv.DIENTHOAI;
                txtdiachi.Text = gv.DIACHI;
                dtngaysinh.Value = gv.NGAYSINH.Value;
                txtemail.Text = gv.EMAIL;
                cbcv.SelectedValue = gv.MaCV;
                cbTrinhDo.SelectedValue = gv.MaTD;
                if (gv.GIOITINH == 1)
                {
                    checkbgioitinh.Checked = true;
                }
                else
                {
                    checkbgioitinh.Checked = false;
                }
                picHinhAnh.Image = Base64ToImage(gv.HINHANH);
            }
        }

        private void btnHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openfile.Title = "Chon Hinh Anh";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openfile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void gvGiaoVien_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "colGIOITINH")
            {
                if (int.Parse(e.CellValue.ToString()) == 0)
                    e.DisplayText = "Nữ";

                else
                    e.DisplayText = "Nam";
            }  
        }

    }
}