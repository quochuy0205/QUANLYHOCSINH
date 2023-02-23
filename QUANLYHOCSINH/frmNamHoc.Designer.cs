namespace QUANLYHOCSINH
{
    partial class frmNamHoc
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
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txttennamhoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdDanhSach = new DevExpress.XtraGrid.GridControl();
            this.tbNamHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvNamHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNamHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNamHoc = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbNamHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNamHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
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
            this.splitContainer1.Panel1.Controls.Add(this.btnIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.txttennamhoc);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gdDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1353, 440);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(962, 119);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(112, 34);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(844, 119);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 34);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(726, 119);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(608, 119);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 34);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(489, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(371, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(253, 119);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txttennamhoc
            // 
            this.txttennamhoc.Location = new System.Drawing.Point(333, 63);
            this.txttennamhoc.Name = "txttennamhoc";
            this.txttennamhoc.Size = new System.Drawing.Size(150, 27);
            this.txttennamhoc.TabIndex = 1;
            this.txttennamhoc.Text = "2021-2022";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nam Hoc";
            // 
            // gdDanhSach
            // 
            this.gdDanhSach.DataSource = this.tbNamHocBindingSource;
            this.gdDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gdDanhSach.MainView = this.gvNamHoc;
            this.gdDanhSach.Name = "gdDanhSach";
            this.gdDanhSach.Size = new System.Drawing.Size(1353, 264);
            this.gdDanhSach.TabIndex = 0;
            this.gdDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNamHoc});
            this.gdDanhSach.Click += new System.EventHandler(this.gdDanhSach_Click);
            // 
            // tbNamHocBindingSource
            // 
            this.tbNamHocBindingSource.DataSource = typeof(DataAccessLayer.tb_NamHoc);
            // 
            // gvNamHoc
            // 
            this.gvNamHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNamHoc,
            this.colTenNamHoc,
            this.colCreated_By,
            this.colCreated_Date,
            this.colUpdated_By,
            this.colUpdated_Date,
            this.colDeleted_By,
            this.colDeleted_Date});
            this.gvNamHoc.GridControl = this.gdDanhSach;
            this.gvNamHoc.Name = "gvNamHoc";
            // 
            // colMaNamHoc
            // 
            this.colMaNamHoc.FieldName = "MaNamHoc";
            this.colMaNamHoc.MinWidth = 30;
            this.colMaNamHoc.Name = "colMaNamHoc";
            this.colMaNamHoc.Visible = true;
            this.colMaNamHoc.VisibleIndex = 0;
            this.colMaNamHoc.Width = 112;
            // 
            // colTenNamHoc
            // 
            this.colTenNamHoc.FieldName = "TenNamHoc";
            this.colTenNamHoc.MinWidth = 30;
            this.colTenNamHoc.Name = "colTenNamHoc";
            this.colTenNamHoc.Visible = true;
            this.colTenNamHoc.VisibleIndex = 1;
            this.colTenNamHoc.Width = 112;
            // 
            // colCreated_By
            // 
            this.colCreated_By.FieldName = "Created_By";
            this.colCreated_By.MinWidth = 30;
            this.colCreated_By.Name = "colCreated_By";
            this.colCreated_By.Visible = true;
            this.colCreated_By.VisibleIndex = 2;
            this.colCreated_By.Width = 112;
            // 
            // colCreated_Date
            // 
            this.colCreated_Date.FieldName = "Created_Date";
            this.colCreated_Date.MinWidth = 30;
            this.colCreated_Date.Name = "colCreated_Date";
            this.colCreated_Date.Visible = true;
            this.colCreated_Date.VisibleIndex = 3;
            this.colCreated_Date.Width = 112;
            // 
            // colUpdated_By
            // 
            this.colUpdated_By.FieldName = "Updated_By";
            this.colUpdated_By.MinWidth = 30;
            this.colUpdated_By.Name = "colUpdated_By";
            this.colUpdated_By.Visible = true;
            this.colUpdated_By.VisibleIndex = 4;
            this.colUpdated_By.Width = 112;
            // 
            // colUpdated_Date
            // 
            this.colUpdated_Date.FieldName = "Updated_Date";
            this.colUpdated_Date.MinWidth = 30;
            this.colUpdated_Date.Name = "colUpdated_Date";
            this.colUpdated_Date.Visible = true;
            this.colUpdated_Date.VisibleIndex = 5;
            this.colUpdated_Date.Width = 112;
            // 
            // colDeleted_By
            // 
            this.colDeleted_By.FieldName = "Deleted_By";
            this.colDeleted_By.MinWidth = 30;
            this.colDeleted_By.Name = "colDeleted_By";
            this.colDeleted_By.Visible = true;
            this.colDeleted_By.VisibleIndex = 6;
            this.colDeleted_By.Width = 112;
            // 
            // colDeleted_Date
            // 
            this.colDeleted_Date.FieldName = "Deleted_Date";
            this.colDeleted_Date.MinWidth = 30;
            this.colDeleted_Date.Name = "colDeleted_Date";
            this.colDeleted_Date.Visible = true;
            this.colDeleted_Date.VisibleIndex = 7;
            this.colDeleted_Date.Width = 112;
            // 
            // frmNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 440);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNamHoc";
            this.Text = "frmNamHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNamHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNamHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNamHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private SplitContainer splitContainer1;
        private TextBox txttennamhoc;
        private Label label1;
        private Button btnDong;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DevExpress.XtraGrid.GridControl gdDanhSach;
        private BindingSource tbNamHocBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNamHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNamHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNamHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_By;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_Date;
        private Button btnIn;
    }
}