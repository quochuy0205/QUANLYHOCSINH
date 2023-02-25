using BussinessLayer;
using DataAccessLayer;
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
    public partial class frmHocKy : DevExpress.XtraEditors.XtraForm
    {
        public frmHocKy()
        {
            InitializeComponent();
        }
        bool _them;
        HOCKY _hk;
        int _id = 0;
        private void frmHocKy_Load(object sender, EventArgs e)
        {
            showHide(true);
            _hk = new HOCKY();
            LoadData();
        }

        void LoadData()
        {
            gdDanhSach.DataSource = _hk.getList();
            gvHocKy.OptionsBehavior.Editable = false;
        }
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            txtTenHocKy.Enabled = !kt;
            txtHeSo.Enabled = !kt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            showHide(false);
            _them = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHide(false);
            _them = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            LoadData();
            showHide(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            showHide(true);
            _them = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                tb_HocKy hk = new tb_HocKy();
                hk.TenHK = txtTenHocKy.Text;
                hk.HeSo = int.Parse(txtHeSo.Text);
                hk.Created_By = 1;
                hk.Created_Date = DateTime.Now;
                _hk.Add(hk);
            }
            else
            {
                tb_HocKy hk = _hk.getItem(_id);
                hk.TenHK = txtTenHocKy.Text;
                hk.HeSo = int.Parse(txtHeSo.Text);
                hk.Updated_By = 1;
                hk.Updated_Date = DateTime.Now;
                _hk.Update(hk);
            }
        }
        private void gvHocKy_Click(object sender, EventArgs e)
        {
            if (gvHocKy.RowCount > 0)
            {
                _id = int.Parse(gvHocKy.GetFocusedRowCellValue("MaHK").ToString());
                txtTenHocKy.Text = gvHocKy.GetFocusedRowCellValue("TenHK").ToString();
                txtHeSo.Text = gvHocKy.GetFocusedRowCellValue("HeSo").ToString();

            }
        }
    }
}