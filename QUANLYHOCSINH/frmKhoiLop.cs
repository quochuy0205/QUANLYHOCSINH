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
    public partial class frmKhoiLop : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoiLop()
        {
            InitializeComponent();
        }
        bool _them;
        KHOILOP _kl;
        int _id = 0;
        private void frmKhoiLop_Load(object sender, EventArgs e)
        {
            
            _kl = new KHOILOP();
            showHide(true);
            LoadData();
        }
        void LoadData()
        {
            gdDanhSach.DataSource = _kl.getList();
            gvKhoiLop.OptionsBehavior.Editable = false;
        }
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;  
            txtKhoiLop.Enabled = !kt;
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
            if (MessageBox.Show("Ban Co Chac Chan Xoa Khong?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _kl.Delete(_id);

            }
            LoadData();
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
                tb_KhoiLop kl = new tb_KhoiLop();
                kl.TenKL = txtKhoiLop.Text;
                _kl.Add(kl);
            }
            else
            {
                tb_KhoiLop kl = _kl.getItem(_id);
                kl.TenKL = txtKhoiLop.Text;
                _kl.Update(kl);
            }
        }
        private void gvKhoiLop_Click(object sender, EventArgs e)
        {
            if (gvKhoiLop.RowCount > 0)
            {
                _id = int.Parse(gvKhoiLop.GetFocusedRowCellValue("MaKL").ToString());
                txtKhoiLop.Text = gvKhoiLop.GetFocusedRowCellValue("TenKL").ToString();
               
            }
        }
    }
}