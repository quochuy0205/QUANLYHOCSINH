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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        public frmLop()
        {
            InitializeComponent();
        }
        bool _them;
        TRUONG _truong;
        LOP _lop;
        KHOILOP _khoilop;
        int _id = 0;
        private void frmLop_Load(object sender, EventArgs e)
        {
            showHide(true);
            _truong = new TRUONG();
            _lop = new LOP();
            _khoilop = new KHOILOP();
            LoadData();
        }

        void LoadData()
        {
            gdDanhSach.DataSource = _lop.getList();
            gvLop.OptionsBehavior.Editable = false;

            cbTruong.DataSource = _truong.getList();
            cbTruong.ValueMember = "MaTruong";
            cbTruong.DisplayMember = "TenTruong";

            cbKhoiLop.DataSource = _khoilop.getList();
            cbKhoiLop.ValueMember = "MaKL";
            cbKhoiLop.DisplayMember = "TenKL";
        }
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            txttenlop.Enabled = !kt;
            txtghichu.Enabled = !kt;
            txtsapxep.Enabled = !kt;
            cbKhoiLop.Enabled = !kt;
            cbTruong.Enabled = !kt;
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
                tb_Lop lop = new tb_Lop();
                lop.TenLop = txttenlop.Text;
                lop.GhiChu = txtghichu.Text;
                lop.SapXep = int.Parse(txtsapxep.Text);
                lop.MaTruong = int.Parse(cbTruong.SelectedValue.ToString());
                lop.MaKL = int.Parse(cbKhoiLop.SelectedValue.ToString());
                lop.Created_By = 1;
                lop.Created_Date = DateTime.Now;
                _lop.Add(lop);
            }
            else
            {
                tb_Lop lop = _lop.getItem(_id);
                lop.TenLop = txttenlop.Text;
                lop.GhiChu = txtghichu.Text;
                lop.SapXep = Int32.Parse(txtsapxep.Text);
                lop.MaTruong = Int32.Parse(cbTruong.SelectedValue.ToString());
                lop.MaKL = Int32.Parse(cbKhoiLop.SelectedValue.ToString());
                lop.Updated_By = 1;
                lop.Updated_Date = DateTime.Now;
                _lop.Update(lop);
            }
        }
        private void gvLop_Click(object sender, EventArgs e)
        {
            if (gvLop.RowCount > 0)
            {
                _id = int.Parse(gvLop.GetFocusedRowCellValue("MaLop").ToString());
                txttenlop.Text = gvLop.GetFocusedRowCellValue("TenLop").ToString();
                txtghichu.Text = gvLop.GetFocusedRowCellValue("GhiChu").ToString();
                txtsapxep.Text = gvLop.GetFocusedRowCellValue("SapXep").ToString();

            }
        }
    }
}