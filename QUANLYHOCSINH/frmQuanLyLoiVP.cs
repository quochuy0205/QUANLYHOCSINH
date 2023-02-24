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
        NAMHOC nh;
        
        private void frmQuanLyLoiVP_Load(object sender, EventArgs e)
        {
            showHide(true);
        }

        void LoadData()
        {

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