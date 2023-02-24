namespace QUANLYHOCSINH
{
    partial class frmKhoiLop
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
            this.txtKhoiLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvKhoiLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.tbKhoiLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKhoiLopBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtKhoiLop);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gdDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1115, 468);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(786, 103);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 34);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(668, 103);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(550, 103);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 34);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(432, 103);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(314, 103);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(196, 103);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtKhoiLop
            // 
            this.txtKhoiLop.Location = new System.Drawing.Point(196, 61);
            this.txtKhoiLop.Name = "txtKhoiLop";
            this.txtKhoiLop.Size = new System.Drawing.Size(344, 27);
            this.txtKhoiLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khối Lớp";
            // 
            // gdDanhSach
            // 
            this.gdDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gdDanhSach.MainView = this.gvKhoiLop;
            this.gdDanhSach.Name = "gdDanhSach";
            this.gdDanhSach.Size = new System.Drawing.Size(1115, 311);
            this.gdDanhSach.TabIndex = 0;
            this.gdDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoiLop});
            // 
            // gvKhoiLop
            // 
            this.gvKhoiLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKL,
            this.colTenKL});
            this.gvKhoiLop.GridControl = this.gdDanhSach;
            this.gvKhoiLop.Name = "gvKhoiLop";
            this.gvKhoiLop.Click += new System.EventHandler(this.gvKhoiLop_Click);
            // 
            // colMaKL
            // 
            this.colMaKL.Caption = "Mã Khối Lớp";
            this.colMaKL.FieldName = "MaKL";
            this.colMaKL.MinWidth = 30;
            this.colMaKL.Name = "colMaKL";
            this.colMaKL.Visible = true;
            this.colMaKL.VisibleIndex = 0;
            this.colMaKL.Width = 112;
            // 
            // colTenKL
            // 
            this.colTenKL.Caption = "Tên Khối Lớp";
            this.colTenKL.FieldName = "TenKL";
            this.colTenKL.MinWidth = 30;
            this.colTenKL.Name = "colTenKL";
            this.colTenKL.Visible = true;
            this.colTenKL.VisibleIndex = 1;
            this.colTenKL.Width = 112;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // tbKhoiLopBindingSource
            // 
            this.tbKhoiLopBindingSource.DataSource = typeof(DataAccessLayer.tb_KhoiLop);
            // 
            // frmKhoiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 468);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmKhoiLop";
            this.Text = "Khối Lớp";
            this.Load += new System.EventHandler(this.frmKhoiLop_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKhoiLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private Button btnDong;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtKhoiLop;
        private Label label1;
        private DevExpress.XtraGrid.GridControl gdDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoiLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKL;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKL;
        private BindingSource tbKhoiLopBindingSource;
    }
}