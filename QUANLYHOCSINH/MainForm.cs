using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
      //  OverlayWindowOptions options = new OverlayWindowOptions(
    
          //    backColor: Color.Black,
          //    opacity: 0.5,
         //     fadeIn: false,
         //     fadeOut: false
     
        //    );
       // IOverlaySplashScreenHandle ShowProgressPanel(Control control, OverlayWindowOptions optoin)
       // {
          //  return SplashScreenManager.ShowOverlayForm(control, optoin);
       // }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Commons.handle = ShowProgressPanel(this, options);
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
        void openForm(Type typeform)
        {
            foreach(var frm in MdiChildren)
            {
                if(frm.GetType()==typeform)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeform);
            f.MdiParent = this;
            f.Show();
        }
        private void mnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmMonHoc));
        }

        private void mnNamHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmNamHoc));
        }

        private void mnGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmGiaoVien));
        }

        private void mnViPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDanhMucViPham));
        }

        private void mnQLViPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmQuanLyLoiVP));
        }

        private void mnKhoiLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmKhoiLop));
        }

        private void mnHocLuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmTruong));
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmLop));
        }

        private void mnHocKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmHocKy));
        }
    }
}