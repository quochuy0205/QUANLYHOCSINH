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
using BussinessLayer;
using DataAccessLayer;
namespace QUANLYHOCSINH
{
    public partial class frmNamHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmNamHoc()
        {
            InitializeComponent();
        }
        bool _them;
        NAMHOC _namhoc;
        int _id = 0;
        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            ShowHide(true);
            _namhoc = new NAMHOC();
            LoadData();
        }
        void LoadData()
        {
            gdDanhSach.DataSource = _namhoc.getList();
            gvNamHoc.OptionsBehavior.Editable = false;
        }
        void ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled= kt;
            txttennamhoc.Enabled = !kt;
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

        void SaveData()
        {
            if(_them)
            {
                tb_NamHoc nh = new tb_NamHoc();
                nh.TenNamHoc = txttennamhoc.Text;
                nh.Created_By = 1;
                nh.Created_Date = DateTime.Now;
                _namhoc.Add(nh);
            }
            else
            {
                tb_NamHoc nh = _namhoc.getItem(_id);
                nh.TenNamHoc = txttennamhoc.Text;
                nh.Created_By = 1;
                nh.Created_Date = DateTime.Now;
                _namhoc.Update(nh);
            }
        }

        private void gdDanhSach_Click(object sender, EventArgs e)
        {
            if(gvNamHoc.RowCount> 0)
            {
                _id = int.Parse(gvNamHoc.GetFocusedRowCellValue("MaNamHoc").ToString());
                txttennamhoc.Text = gvNamHoc.GetFocusedRowCellValue("TenNamHoc").ToString();
            }
        }
    }
}