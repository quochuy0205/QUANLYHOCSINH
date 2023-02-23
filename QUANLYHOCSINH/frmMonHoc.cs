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
using DataAccessLayer;
namespace QUANLYHOCSINH
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        bool _them;
        MONHOC _monhoc;
        int _id = 0;
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            showHide(true);
            _monhoc = new MONHOC();
            LoadData();
        }
        void LoadData()
        {
            gcdanhsach.DataSource = _monhoc.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
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
            txtTenMonHoc.Enabled = !kt;
            spinSoTiet.Enabled = !kt;
            spinHeSo.Enabled = !kt;
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
            if(MessageBox.Show("Ban Co Chac Chan Xoa Khong?","Thong Bao",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _monhoc.Delete(_id,1);

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
            _them= false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if(_them)
            {
                tb_MonHoc mh = new tb_MonHoc();
                mh.TenMH = txtTenMonHoc.Text;
                mh.SoTiet = Int32.Parse(spinSoTiet.Text);
                mh.HeSo = Int32.Parse(spinHeSo.Text);
                mh.Created_By = 1;
                mh.Created_Date= DateTime.Now;
                _monhoc.Add(mh);
            }
            else
            {
                tb_MonHoc mh = _monhoc.getItem(_id);
                mh.TenMH = txtTenMonHoc.Text;
                mh.SoTiet = Int32.Parse(spinSoTiet.Text);
                mh.HeSo = Int32.Parse(spinHeSo.Text);
                mh.Created_By = 1;
                mh.Created_Date = DateTime.Now;
                _monhoc.Update(mh);
            }
        }

        private void gcdanhsach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount>0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaMH").ToString());
                txtTenMonHoc.Text = gvDanhSach.GetFocusedRowCellValue("TenMH").ToString();
                spinHeSo.Text = gvDanhSach.GetFocusedRowCellValue("HeSo").ToString();
                spinSoTiet.Text = gvDanhSach.GetFocusedRowCellValue("SoTiet").ToString();
            }
        }

       
    }
}