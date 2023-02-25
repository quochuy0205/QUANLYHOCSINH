using BussinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmQuanLyLoiVP : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLyLoiVP()
        {
            InitializeComponent();
        }
        NAMHOC _nh;
        HOCKY _hocky;
        KHOILOP _khoilop;
        LOP _lophoc;
        HOCSINH _hocsinh;
        DM_VIPHAM _loi;
        private void frmQuanLyLoiVP_Load(object sender, EventArgs e)
        {
            _nh = new NAMHOC();
            _hocky = new HOCKY();
            _lophoc = new LOP();
            _khoilop= new KHOILOP();
            _hocsinh = new HOCSINH();
            _loi = new DM_VIPHAM();
            showHide(true);
            LoadData();
            LoadHocSinh();
            LoadDMLOI();
        }

        void LoadData()
        {
            cbnamhoc.DataSource=_nh.getList();
            cbnamhoc.DisplayMember = "TenNamHoc";
            cbnamhoc.ValueMember = "MaNamHoc";

            cbhocky.DataSource = _hocky.getList();
            cbhocky.DisplayMember = "TenHK";
            cbhocky.ValueMember = "MaHK";

            cbkhoilop.DataSource = _khoilop.getList();
            cbkhoilop.DisplayMember = "TenKL";
            cbkhoilop.ValueMember = "MaKL";

            cblop.DataSource = _lophoc.getList();
            cblop.DisplayMember = "TenLop";
            cblop.ValueMember = "MaLop";
        }

        void LoadHocSinh()
        {
            slHS.Properties.DataSource = _hocsinh.getList();
            slHS.Properties.DisplayMember = "HOTEN" + "TEN";
            slHS.Properties.ValueMember = "MaHS";
        }

        void LoadDMLOI()
        {
            slDmloi.Properties.DataSource = _loi.getlist();
            slDmloi.Properties.DisplayMember = "TENVP";
            slDmloi.Properties.ValueMember = "MAVP";
        }
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtGhiChu.Enabled = !kt;
            dtNgay.Enabled = !kt;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            showHide(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHide(false);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            showHide(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            showHide(true);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}