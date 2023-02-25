namespace QUANLYHOCSINH
{
    partial class frmTruong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txttentruong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gdDanhSach = new DevExpress.XtraGrid.GridControl();
            this.tbTruongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvTruong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreated_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreated_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdated_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdated_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeleted_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTruongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTruong)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.txtWebsite);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiaChi);
            this.splitContainer1.Panel1.Controls.Add(this.txtDienThoai);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txttentruong);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gdDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1366, 465);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(804, 178);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 34);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(686, 178);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(568, 178);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 34);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(450, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(332, 178);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(214, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(539, 88);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(259, 27);
            this.txtWebsite.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(539, 28);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(259, 27);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(214, 145);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(230, 27);
            this.txtDienThoai.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // txttentruong
            // 
            this.txttentruong.Location = new System.Drawing.Point(214, 23);
            this.txttentruong.Name = "txttentruong";
            this.txttentruong.Size = new System.Drawing.Size(230, 27);
            this.txttentruong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Website";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Trường";
            // 
            // gdDanhSach
            // 
            this.gdDanhSach.DataSource = this.tbTruongBindingSource;
            this.gdDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gdDanhSach.MainView = this.gvTruong;
            this.gdDanhSach.Name = "gdDanhSach";
            this.gdDanhSach.Size = new System.Drawing.Size(1366, 230);
            this.gdDanhSach.TabIndex = 0;
            this.gdDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTruong});
            // 
            // tbTruongBindingSource
            // 
            this.tbTruongBindingSource.DataSource = typeof(DataAccessLayer.tb_Truong);
            // 
            // gvTruong
            // 
            this.gvTruong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTruong,
            this.colTenTruong,
            this.colEmail,
            this.colDienThoai,
            this.colDiaChi,
            this.colWebsite,
            this.colCreated_By,
            this.colCreated_Date,
            this.colUpdated_By,
            this.colUpdated_Date,
            this.colDeleted_By,
            this.colDeleted_Date});
            this.gvTruong.GridControl = this.gdDanhSach;
            this.gvTruong.Name = "gvTruong";
            this.gvTruong.Click += new System.EventHandler(this.gvTruong_Click);
            // 
            // colMaTruong
            // 
            this.colMaTruong.Caption = "Mã Trường";
            this.colMaTruong.FieldName = "MaTruong";
            this.colMaTruong.MinWidth = 30;
            this.colMaTruong.Name = "colMaTruong";
            this.colMaTruong.Visible = true;
            this.colMaTruong.VisibleIndex = 0;
            this.colMaTruong.Width = 112;
            // 
            // colTenTruong
            // 
            this.colTenTruong.Caption = "Tên Trường";
            this.colTenTruong.FieldName = "TenTruong";
            this.colTenTruong.MinWidth = 30;
            this.colTenTruong.Name = "colTenTruong";
            this.colTenTruong.Visible = true;
            this.colTenTruong.VisibleIndex = 1;
            this.colTenTruong.Width = 112;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 30;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 112;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện Thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.MinWidth = 30;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 3;
            this.colDienThoai.Width = 112;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 30;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            this.colDiaChi.Width = 112;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.MinWidth = 30;
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 5;
            this.colWebsite.Width = 112;
            // 
            // colCreated_By
            // 
            this.colCreated_By.FieldName = "Created_By";
            this.colCreated_By.MinWidth = 30;
            this.colCreated_By.Name = "colCreated_By";
            this.colCreated_By.Visible = true;
            this.colCreated_By.VisibleIndex = 6;
            this.colCreated_By.Width = 112;
            // 
            // colCreated_Date
            // 
            this.colCreated_Date.FieldName = "Created_Date";
            this.colCreated_Date.MinWidth = 30;
            this.colCreated_Date.Name = "colCreated_Date";
            this.colCreated_Date.Visible = true;
            this.colCreated_Date.VisibleIndex = 7;
            this.colCreated_Date.Width = 112;
            // 
            // colUpdated_By
            // 
            this.colUpdated_By.FieldName = "Updated_By";
            this.colUpdated_By.MinWidth = 30;
            this.colUpdated_By.Name = "colUpdated_By";
            this.colUpdated_By.Visible = true;
            this.colUpdated_By.VisibleIndex = 8;
            this.colUpdated_By.Width = 112;
            // 
            // colUpdated_Date
            // 
            this.colUpdated_Date.FieldName = "Updated_Date";
            this.colUpdated_Date.MinWidth = 30;
            this.colUpdated_Date.Name = "colUpdated_Date";
            this.colUpdated_Date.Visible = true;
            this.colUpdated_Date.VisibleIndex = 9;
            this.colUpdated_Date.Width = 112;
            // 
            // colDeleted_By
            // 
            this.colDeleted_By.FieldName = "Deleted_By";
            this.colDeleted_By.MinWidth = 30;
            this.colDeleted_By.Name = "colDeleted_By";
            this.colDeleted_By.Visible = true;
            this.colDeleted_By.VisibleIndex = 10;
            this.colDeleted_By.Width = 112;
            // 
            // colDeleted_Date
            // 
            this.colDeleted_Date.FieldName = "Deleted_Date";
            this.colDeleted_Date.MinWidth = 30;
            this.colDeleted_Date.Name = "colDeleted_Date";
            this.colDeleted_Date.Visible = true;
            this.colDeleted_Date.VisibleIndex = 11;
            this.colDeleted_Date.Width = 112;
            // 
            // frmTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 465);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTruong";
            this.Text = "Trường";
            this.Load += new System.EventHandler(this.frmTruong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTruongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTruong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDong;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtWebsite;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private TextBox txttentruong;
        private DevExpress.XtraGrid.GridControl gdDanhSach;
        private BindingSource tbTruongBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTruong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTruong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTruong;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_By;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_Date;
    }
}