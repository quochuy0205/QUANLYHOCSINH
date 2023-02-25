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
    public partial class frmTruong : DevExpress.XtraEditors.XtraForm
    {
        public frmTruong()
        {
            InitializeComponent();
        }
        bool _them;
        TRUONG _truong;
        int _id = 0;
        private void frmTruong_Load(object sender, EventArgs e)
        {
            showHide(true);
            _truong = new TRUONG();
            LoadData();
        }

        void LoadData()
        {
            gdDanhSach.DataSource = _truong.getList();
            gvTruong.OptionsBehavior.Editable = false;
        }
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            txttentruong.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtWebsite.Enabled = !kt;
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
                tb_Truong truong = new tb_Truong();
                truong.TenTruong = txttentruong.Text;
                truong.Email = txtEmail.Text;
                truong.DienThoai = txtDienThoai.Text;
                truong.DiaChi = txtDiaChi.Text;
                truong.Website= txtWebsite.Text;
                truong.Created_By = 1;
                truong.Created_Date = DateTime.Now;
                _truong.Add(truong);
            }
            else
            {
                tb_Truong truong = _truong.getItem(_id);
                truong.TenTruong = txttentruong.Text;
                truong.Email = txtEmail.Text;
                truong.DienThoai = txtDienThoai.Text;
                truong.DiaChi = txtDiaChi.Text;
                truong.Website = txtWebsite.Text;
                truong.Updated_By = 1;
                truong.Updated_Date = DateTime.Now;
                _truong.Update(truong);
            }
        }
        private void gvTruong_Click(object sender, EventArgs e)
        {
            if (gvTruong.RowCount > 0)
            {
                _id = int.Parse(gvTruong.GetFocusedRowCellValue("MaTruong").ToString());
                txttentruong.Text = gvTruong.GetFocusedRowCellValue("TenTruong").ToString();
                txtEmail.Text = gvTruong.GetFocusedRowCellValue("Email").ToString();
                txtDienThoai.Text = gvTruong.GetFocusedRowCellValue("DienThoai").ToString();
                txtDiaChi.Text = gvTruong.GetFocusedRowCellValue("DiaChi").ToString();
                txtWebsite.Text = gvTruong.GetFocusedRowCellValue("Website").ToString();
            }
        }
    }
}