namespace QUANLYHOCSINH
{
    partial class frmMonHoc
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
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.spinHeSo = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spinSoTiet = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.tbMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTiet = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.spinHeSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.btnIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.spinHeSo);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.spinSoTiet);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenMonHoc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcdanhsach);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 509);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(995, 63);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 34);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(877, 62);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(112, 34);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(759, 64);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(639, 66);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 32);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(518, 64);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(403, 63);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(285, 63);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // spinHeSo
            // 
            this.spinHeSo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinHeSo.Location = new System.Drawing.Point(742, 35);
            this.spinHeSo.Margin = new System.Windows.Forms.Padding(4);
            this.spinHeSo.Name = "spinHeSo";
            this.spinHeSo.Properties.IsFloatValue = false;
            this.spinHeSo.Properties.MaskSettings.Set("mask", "N00");
            this.spinHeSo.Size = new System.Drawing.Size(150, 26);
            this.spinHeSo.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(692, 39);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hệ Số";
            // 
            // spinSoTiet
            // 
            this.spinSoTiet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSoTiet.Location = new System.Drawing.Point(518, 35);
            this.spinSoTiet.Margin = new System.Windows.Forms.Padding(4);
            this.spinSoTiet.Name = "spinSoTiet";
            this.spinSoTiet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoTiet.Properties.IsFloatValue = false;
            this.spinSoTiet.Properties.MaskSettings.Set("mask", "N00");
            this.spinSoTiet.Size = new System.Drawing.Size(150, 28);
            this.spinSoTiet.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(459, 39);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Số Tiết";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(285, 35);
            this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(150, 26);
            this.txtTenMonHoc.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(182, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Môn Học";
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.DataSource = this.tbMonHocBindingSource;
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 0);
            this.gcdanhsach.MainView = this.gvDanhSach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(1126, 368);
            this.gcdanhsach.TabIndex = 0;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcdanhsach.Click += new System.EventHandler(this.gcdanhsach_Click);
            // 
            // tbMonHocBindingSource
            // 
            this.tbMonHocBindingSource.DataSource = typeof(DataAccessLayer.tb_MonHoc);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colHeSo,
            this.colSoTiet,
            this.colCreated_By,
            this.colCreated_Date,
            this.colUpdated_By,
            this.colUpdated_Date,
            this.colDeleted_By,
            this.colDeleted_Date});
            this.gvDanhSach.GridControl = this.gcdanhsach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMaMH, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMaMH
            // 
            this.colMaMH.Caption = "Mã Môn Học";
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.MinWidth = 30;
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 0;
            this.colMaMH.Width = 112;
            // 
            // colTenMH
            // 
            this.colTenMH.Caption = "Tên Môn Học";
            this.colTenMH.FieldName = "TenMH";
            this.colTenMH.MinWidth = 30;
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.Visible = true;
            this.colTenMH.VisibleIndex = 1;
            this.colTenMH.Width = 112;
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
            // colSoTiet
            // 
            this.colSoTiet.Caption = "Số Tiết";
            this.colSoTiet.FieldName = "SoTiet";
            this.colSoTiet.MinWidth = 30;
            this.colSoTiet.Name = "colSoTiet";
            this.colSoTiet.Visible = true;
            this.colSoTiet.VisibleIndex = 3;
            this.colSoTiet.Width = 112;
            // 
            // colCreated_By
            // 
            this.colCreated_By.FieldName = "Created_By";
            this.colCreated_By.MinWidth = 30;
            this.colCreated_By.Name = "colCreated_By";
            this.colCreated_By.Visible = true;
            this.colCreated_By.VisibleIndex = 4;
            this.colCreated_By.Width = 112;
            // 
            // colCreated_Date
            // 
            this.colCreated_Date.FieldName = "Created_Date";
            this.colCreated_Date.MinWidth = 30;
            this.colCreated_Date.Name = "colCreated_Date";
            this.colCreated_Date.Visible = true;
            this.colCreated_Date.VisibleIndex = 5;
            this.colCreated_Date.Width = 112;
            // 
            // colUpdated_By
            // 
            this.colUpdated_By.FieldName = "Updated_By";
            this.colUpdated_By.MinWidth = 30;
            this.colUpdated_By.Name = "colUpdated_By";
            this.colUpdated_By.Visible = true;
            this.colUpdated_By.VisibleIndex = 6;
            this.colUpdated_By.Width = 112;
            // 
            // colUpdated_Date
            // 
            this.colUpdated_Date.FieldName = "Updated_Date";
            this.colUpdated_Date.MinWidth = 30;
            this.colUpdated_Date.Name = "colUpdated_Date";
            this.colUpdated_Date.Visible = true;
            this.colUpdated_Date.VisibleIndex = 7;
            this.colUpdated_Date.Width = 112;
            // 
            // colDeleted_By
            // 
            this.colDeleted_By.FieldName = "Deleted_By";
            this.colDeleted_By.MinWidth = 30;
            this.colDeleted_By.Name = "colDeleted_By";
            this.colDeleted_By.Visible = true;
            this.colDeleted_By.VisibleIndex = 8;
            this.colDeleted_By.Width = 112;
            // 
            // colDeleted_Date
            // 
            this.colDeleted_Date.FieldName = "Deleted_Date";
            this.colDeleted_Date.MinWidth = 30;
            this.colDeleted_Date.Name = "colDeleted_Date";
            this.colDeleted_Date.Visible = true;
            this.colDeleted_Date.VisibleIndex = 9;
            this.colDeleted_Date.Width = 112;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 509);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMonHoc";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinHeSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenMonHoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spinSoTiet;
        private BindingSource tbMonHocBindingSource;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMH;
        private DevExpress.XtraGrid.Columns.GridColumn colHeSo;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_By;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_Date;
        private DevExpress.XtraEditors.SpinEdit spinHeSo;
        private Button btnIn;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnDong;
    }
}