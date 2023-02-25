namespace QUANLYHOCSINH
{
    partial class frmHocKy
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
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gdDanhSach = new DevExpress.XtraGrid.GridControl();
            this.tbHocKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvHocKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeSo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbHocKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocKy)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtHeSo);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenHocKy);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gdDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1325, 485);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(854, 138);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 34);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(736, 138);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(618, 138);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 34);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(500, 138);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(382, 138);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(264, 138);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHeSo
            // 
            this.txtHeSo.Location = new System.Drawing.Point(264, 105);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(348, 27);
            this.txtHeSo.TabIndex = 3;
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Location = new System.Drawing.Point(264, 46);
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(348, 27);
            this.txtTenHocKy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ Số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Học Kỳ";
            // 
            // gdDanhSach
            // 
            this.gdDanhSach.DataSource = this.tbHocKyBindingSource;
            this.gdDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gdDanhSach.MainView = this.gvHocKy;
            this.gdDanhSach.Name = "gdDanhSach";
            this.gdDanhSach.Size = new System.Drawing.Size(1325, 303);
            this.gdDanhSach.TabIndex = 0;
            this.gdDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHocKy});
            // 
            // tbHocKyBindingSource
            // 
            this.tbHocKyBindingSource.DataSource = typeof(DataAccessLayer.tb_HocKy);
            // 
            // gvHocKy
            // 
            this.gvHocKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHK,
            this.colTenHK,
            this.colHeSo,
            this.colCreated_By,
            this.colCreated_Date,
            this.colUpdated_By,
            this.colUpdated_Date,
            this.colDeleted_By,
            this.colDeleted_Date});
            this.gvHocKy.GridControl = this.gdDanhSach;
            this.gvHocKy.Name = "gvHocKy";
            this.gvHocKy.Click += new System.EventHandler(this.gvHocKy_Click);
            // 
            // colMaHK
            this.colMaHK.Caption = "Mã Học Kỳ";
            this.colMaHK.FieldName = "MaHK";
            this.colMaHK.MinWidth = 30;
            this.colMaHK.Name = "colMaHK";
            this.colMaHK.Visible = true;
            this.colMaHK.VisibleIndex = 0;
            this.colMaHK.Width = 112;
            // 
            // colTenHK
            // 
            this.colTenHK.Caption = "Tên Học Kỳ";
            this.colTenHK.FieldName = "TenHK";
            this.colTenHK.MinWidth = 30;
            this.colTenHK.Name = "colTenHK";
            this.colTenHK.Visible = true;
            this.colTenHK.VisibleIndex = 1;
            this.colTenHK.Width = 112;
            // 
            // colHeSo
            // 
            this.colHeSo.Caption = "Hệ Số";
            this.colHeSo.FieldName = "HeSo";
            this.colHeSo.MinWidth = 30;
            this.colHeSo.Name = "colHeSo";
            this.colHeSo.Visible = true;
            this.colHeSo.VisibleIndex = 2;
            this.colHeSo.Width = 112;
            // 
            // colCreated_By
            // 
            this.colCreated_By.FieldName = "Created_By";
            this.colCreated_By.MinWidth = 30;
            this.colCreated_By.Name = "colCreated_By";
            this.colCreated_By.Visible = true;
            this.colCreated_By.VisibleIndex = 3;
            this.colCreated_By.Width = 112;
            // 
            // colCreated_Date
            // 
            this.colCreated_Date.FieldName = "Created_Date";
            this.colCreated_Date.MinWidth = 30;
            this.colCreated_Date.Name = "colCreated_Date";
            this.colCreated_Date.Visible = true;
            this.colCreated_Date.VisibleIndex = 4;
            this.colCreated_Date.Width = 112;
            // 
            // colUpdated_By
            // 
            this.colUpdated_By.FieldName = "Updated_By";
            this.colUpdated_By.MinWidth = 30;
            this.colUpdated_By.Name = "colUpdated_By";
            this.colUpdated_By.Visible = true;
            this.colUpdated_By.VisibleIndex = 5;
            this.colUpdated_By.Width = 112;
            // 
            // colUpdated_Date
            // 
            this.colUpdated_Date.FieldName = "Updated_Date";
            this.colUpdated_Date.MinWidth = 30;
            this.colUpdated_Date.Name = "colUpdated_Date";
            this.colUpdated_Date.Visible = true;
            this.colUpdated_Date.VisibleIndex = 6;
            this.colUpdated_Date.Width = 112;
            // 
            // colDeleted_By
            // 
            this.colDeleted_By.FieldName = "Deleted_By";
            this.colDeleted_By.MinWidth = 30;
            this.colDeleted_By.Name = "colDeleted_By";
            this.colDeleted_By.Visible = true;
            this.colDeleted_By.VisibleIndex = 7;
            this.colDeleted_By.Width = 112;
            // 
            // colDeleted_Date
            // 
            this.colDeleted_Date.FieldName = "Deleted_Date";
            this.colDeleted_Date.MinWidth = 30;
            this.colDeleted_Date.Name = "colDeleted_Date";
            this.colDeleted_Date.Visible = true;
            this.colDeleted_Date.VisibleIndex = 8;
            this.colDeleted_Date.Width = 112;
            // 
            // frmHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 485);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHocKy";
            this.Text = "Học Kỳ";
            this.Load += new System.EventHandler(this.frmHocKy_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHocKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtHeSo;
        private TextBox txtTenHocKy;
        private Label label2;
        private Label label1;
        private Button btnDong;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DevExpress.XtraGrid.GridControl gdDanhSach;
        private BindingSource tbHocKyBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHocKy;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHK;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHK;
        private DevExpress.XtraGrid.Columns.GridColumn colHeSo;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_By;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_Date;
    }
}