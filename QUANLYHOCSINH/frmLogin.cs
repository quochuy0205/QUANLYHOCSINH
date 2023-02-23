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
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using BussinessLayer;

namespace QUANLYHOCSINH
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        USERS _user;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int lg = _user.Login(txtUsername.Text, txtPass.Text);
            if(lg == 1)
            {
                // if(Commons.handle != null)
                //SplashScreenManager.CloseOverlayForm(Commons.handle);
                Commons.UserStatic = _user.getItem(txtUsername.Text);
                MainForm main = (MainForm)Application.OpenForms["MainForm"];
                main.lbFullname.Caption = Commons.UserStatic.FULLNAME;
                this.Close();
             
            }
            else
            {
                MessageBox.Show("Ten Dang Nhap hoac mat khau khong dung.","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _user = new USERS();

        }
    }
}