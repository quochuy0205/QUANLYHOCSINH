using BussinessLayer;
using DataAccessLayer;
using DevExpress.DataAccess.Excel;
using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class frmDanhMucViPham : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMucViPham()
        {
            InitializeComponent();
        }
        bool _them;
        DM_VIPHAM _vp;
        int _id = 0;
        bool _import;
        private void btnThem_Click(object sender, EventArgs e)
        {
            _import= true;
            btnExcel.Enabled = true;
            showHide(false);
            _them = true;
        }
        void LoadData()
        {
            gdDanhSach.DataSource = _vp.getlist();
            gvViPham.OptionsBehavior.Editable = false;
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
            txttenvp.Enabled = !kt;
            txtghichu.Enabled = !kt;
            spindiem.Enabled = !kt;

        }
        private void frmDanhMucViPham_Load(object sender, EventArgs e)
        {
            showHide(true);
            _vp = new DM_VIPHAM();
            LoadData();
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
            if(_import)
            {
                SaveExcel();
            }
            else
            {
            SaveData();
            LoadData();
            showHide(true);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            showHide(true);
            _them = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SaveExcel()
        {
            for(int i = 0; i < gvViPham.RowCount; i++)
            {
                tb_DanhMucLoi vp = new tb_DanhMucLoi();
                vp.TENVP = gvViPham.GetRowCellValue(i,"TENVP").ToString();
                vp.DIEM = int.Parse(gvViPham.GetRowCellValue(i, "DIEM").ToString());
                vp.NGHIEMTRONG = bool.Parse(gvViPham.GetRowCellValue(i, "NGHIEMTRONG").ToString());
                if(gvViPham.GetRowCellValue(i, "GHICHU") == null)
                {
                    vp.GHICHU = "";
                }
                else
                {
                    vp.GHICHU = gvViPham.GetRowCellValue(i, "GHICHU").ToString();
                }
                
                vp.CREATED_BY = Commons.UserStatic.UID;
                vp.CREATED_DATE = DateTime.Now;
                _vp.Add(vp);
            }
            _import = false;
        }
        private void gdDanhSach_Click(object sender, EventArgs e)
        {
            if(gvViPham.RowCount > 0)
            {
                _id = int.Parse(gvViPham.GetFocusedRowCellValue("MAVP").ToString());
                txttenvp.Text = gvViPham.GetFocusedRowCellValue("TENVP").ToString();
                spindiem.Text = gvViPham.GetFocusedRowCellValue("DIEM").ToString();
                txtghichu.Text = gvViPham.GetFocusedRowCellValue("GHICHU").ToString();
            }
        }
        void SaveData()
        {
            if (_them)
            {
                tb_DanhMucLoi vp = new tb_DanhMucLoi();
                vp.TENVP = txttenvp.Text;
                vp.DIEM = Int32.Parse(spindiem.EditValue.ToString() );
                vp.NGHIEMTRONG = checkBox1.Checked;
                vp.GHICHU = txtghichu.Text;
                vp.CREATED_BY = Commons.UserStatic.UID;
                vp.CREATED_DATE = DateTime.Now;
                _vp.Add(vp);
            }
            else
            {
                tb_DanhMucLoi vp = _vp.getItem(_id);
                vp.TENVP = txttenvp.Text;
                vp.DIEM = Int32.Parse(spindiem.EditValue.ToString());
                vp.NGHIEMTRONG = checkBox1.Checked;
                vp.GHICHU = txtghichu.Text;
                vp.UPDATED_BY = Commons.UserStatic.UID;
                vp.UPDATED_DATE = DateTime.Now;
                _vp.Update(vp);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
    
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Chon file import";
            fd.Filter = "Excel (*.xls) | *.xls | (*.xlsx) | *.xlsx";
            if(fd.ShowDialog() == DialogResult.OK)
            {
                ExcelDataSource excel = new ExcelDataSource();
                excel.FileName = fd.FileName;
                ExcelWorksheetSettings excelWorksheet = new ExcelWorksheetSettings("Sheet1","A1:E100");
                excel.SourceOptions = new ExcelSourceOptions(excelWorksheet);
                excel.SourceOptions = new CsvSourceOptions() { CellRange = "A1:E100" };
                excel.SourceOptions.SkipEmptyRows = false;
                excel.SourceOptions.UseFirstRowAsHeader= true;
                excel.Fill();
                gdDanhSach.DataSource = excel;
                _import = true;
            }
        }
        //export ecel
        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportExcel("");
        }

        public bool ExportExcel(string filename)
        {
            try
            {
                if (gvViPham.FocusedRowHandle < 0)
                {

                }
                else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = filename;
                    dialog.Filter = @"Microsoft Excel | *.xlsx";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gvViPham.ColumnPanelRowHeight = 40;
                        gvViPham.OptionsPrint.AutoWidth = AutoSize;
                        gvViPham.OptionsPrint.ShowPrintExportProgress = true;
                        gvViPham.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";
                        ExportSettings.DefaultExportType = ExportType.Default;
                        gvViPham.ExportToXlsx(dialog.FileName, options);
                        XtraMessageBox.Show("Export Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);

                    
                    }
                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show("Error:" + ex, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}