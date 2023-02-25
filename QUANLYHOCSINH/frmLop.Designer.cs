namespace QUANLYHOCSINH
{
    partial class frmLop
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
            this.cbKhoiLop = new System.Windows.Forms.ComboBox();
            this.cbTruong = new System.Windows.Forms.ComboBox();
            this.txtsapxep = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gdDanhSach = new DevExpress.XtraGrid.GridControl();
            this.tbLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSapXep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKL = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.cbKhoiLop);
            this.splitContainer1.Panel1.Controls.Add(this.cbTruong);
            this.splitContainer1.Panel1.Controls.Add(this.txtsapxep);
            this.splitContainer1.Panel1.Controls.Add(this.txtghichu);
            this.splitContainer1.Panel1.Controls.Add(this.txttenlop);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gdDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1339, 471);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(832, 165);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 34);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(714, 165);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(596, 165);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 34);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(478, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(360, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(242, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbKhoiLop
            // 
            this.cbKhoiLop.FormattingEnabled = true;
            this.cbKhoiLop.Location = new System.Drawing.Point(588, 81);
            this.cbKhoiLop.Name = "cbKhoiLop";
            this.cbKhoiLop.Size = new System.Drawing.Size(182, 27);
            this.cbKhoiLop.TabIndex = 9;
            // 
            // cbTruong
            // 
            this.cbTruong.FormattingEnabled = true;
            this.cbTruong.Location = new System.Drawing.Point(588, 24);
            this.cbTruong.Name = "cbTruong";
            this.cbTruong.Size = new System.Drawing.Size(182, 27);
            this.cbTruong.TabIndex = 8;
            // 
            // txtsapxep
            // 
            this.txtsapxep.Location = new System.Drawing.Point(242, 132);
            this.txtsapxep.Name = "txtsapxep";
            this.txtsapxep.Size = new System.Drawing.Size(230, 27);
            this.txtsapxep.TabIndex = 7;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(242, 81);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(230, 27);
            this.txtghichu.TabIndex = 6;
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(242, 24);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(230, 27);
            this.txttenlop.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khối Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sắp Xếp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ghi Chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Lớp";
            // 
            // gdDanhSach
            // 
            this.gdDanhSach.DataSource = this.tbLopBindingSource;
            this.gdDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gdDanhSach.MainView = this.gvLop;
            this.gdDanhSach.Name = "gdDanhSach";
            this.gdDanhSach.Size = new System.Drawing.Size(1339, 255);
            this.gdDanhSach.TabIndex = 0;
            this.gdDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLop});
            // 
            // tbLopBindingSource
            // 
            this.tbLopBindingSource.DataSource = typeof(DataAccessLayer.tb_Lop);
            // 
            // gvLop
            // 
            this.gvLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLop,
            this.colTenLop,
            this.colGhiChu,
            this.colSapXep,
            this.colMaTruong,
            this.colMaKL,
            this.colCreated_By,
            this.colCreated_Date,
            this.colUpdated_By,
            this.colUpdated_Date,
            this.colDeleted_By,
            this.colDeleted_Date});
            this.gvLop.GridControl = this.gdDanhSach;
            this.gvLop.Name = "gvLop";
            this.gvLop.Click += new System.EventHandler(this.gvLop_Click);
            // 
            // colMaLop
            // 
            this.colMaLop.Caption = "Mã Lớp";
            this.colMaLop.FieldName = "MaLop";
            this.colMaLop.MinWidth = 30;
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Visible = true;
            this.colMaLop.VisibleIndex = 0;
            this.colMaLop.Width = 112;
            // 
            // colTenLop
            // 
            this.colTenLop.Caption = "Tên Lớp";
            this.colTenLop.FieldName = "TenLop";
            this.colTenLop.MinWidth = 30;
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.Visible = true;
            this.colTenLop.VisibleIndex = 1;
            this.colTenLop.Width = 112;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 30;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            this.colGhiChu.Width = 112;
            // 
            // colSapXep
            // 
            this.colSapXep.Caption = "Sắp Xếp";
            this.colSapXep.FieldName = "SapXep";
            this.colSapXep.MinWidth = 30;
            this.colSapXep.Name = "colSapXep";
            this.colSapXep.Visible = true;
            this.colSapXep.VisibleIndex = 3;
            this.colSapXep.Width = 112;
            // 
            // colMaTruong
            // 
            this.colMaTruong.Caption = "Mã Trường";
            this.colMaTruong.FieldName = "MaTruong";
            this.colMaTruong.MinWidth = 30;
            this.colMaTruong.Name = "colMaTruong";
            this.colMaTruong.Visible = true;
            this.colMaTruong.VisibleIndex = 4;
            this.colMaTruong.Width = 112;
            // 
            // colMaKL
            // 
            this.colMaKL.FieldName = "MaKL";
            this.colMaKL.MinWidth = 30;
            this.colMaKL.Name = "colMaKL";
            this.colMaKL.Visible = true;
            this.colMaKL.VisibleIndex = 5;
            this.colMaKL.Width = 112;
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
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 471);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtsapxep;
        private TextBox txtghichu;
        private TextBox txttenlop;
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
        private ComboBox cbKhoiLop;
        private ComboBox cbTruong;
        private DevExpress.XtraGrid.GridControl gdDanhSach;
        private BindingSource tbLopBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLop;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLop;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colSapXep;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTruong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKL;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_By;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_By;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted_Date;
    }
}