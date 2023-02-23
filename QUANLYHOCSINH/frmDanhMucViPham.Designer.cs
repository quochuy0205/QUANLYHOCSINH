namespace QUANLYHOCSINH
{
    partial class frmDanhMucViPham
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.spindiem = new DevExpress.XtraEditors.SpinEdit();
            this.txtghichu = new DevExpress.XtraEditors.TextEdit();
            this.txttenvp = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gdDanhSach = new DevExpress.XtraGrid.GridControl();
            this.tbDanhMucLoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvViPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIEMTRONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPDATED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDELETED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spindiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenvp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDanhMucLoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvViPham)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.Controls.Add(this.btnExcel);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.spindiem);
            this.splitContainer1.Panel1.Controls.Add(this.txtghichu);
            this.splitContainer1.Panel1.Controls.Add(this.txttenvp);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDong);
            this.splitContainer1.Panel1.Controls.Add(this.btnIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gdDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 416);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(861, 77);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(112, 34);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Import Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(705, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 23);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Nghiêm Trọng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // spindiem
            // 
            this.spindiem.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spindiem.Location = new System.Drawing.Point(757, 24);
            this.spindiem.Name = "spindiem";
            this.spindiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spindiem.Size = new System.Drawing.Size(225, 28);
            this.spindiem.TabIndex = 12;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(285, 81);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(409, 26);
            this.txtghichu.TabIndex = 11;
            // 
            // txttenvp
            // 
            this.txttenvp.Location = new System.Drawing.Point(285, 25);
            this.txttenvp.Name = "txttenvp";
            this.txttenvp.Size = new System.Drawing.Size(409, 26);
            this.txttenvp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ghi Chu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Vi Phạm";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(936, 133);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 34);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(818, 132);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(112, 34);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(700, 132);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(582, 133);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 34);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(464, 133);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(346, 133);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(228, 133);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gdDanhSach
            // 
            this.gdDanhSach.DataSource = this.tbDanhMucLoiBindingSource;
            this.gdDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gdDanhSach.MainView = this.gvViPham;
            this.gdDanhSach.Name = "gdDanhSach";
            this.gdDanhSach.Size = new System.Drawing.Size(1128, 243);
            this.gdDanhSach.TabIndex = 0;
            this.gdDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvViPham});
            this.gdDanhSach.Click += new System.EventHandler(this.gdDanhSach_Click);
            // 
            // tbDanhMucLoiBindingSource
            // 
            this.tbDanhMucLoiBindingSource.DataSource = typeof(DataAccessLayer.tb_DanhMucLoi);
            // 
            // gvViPham
            // 
            this.gvViPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVP,
            this.colTENVP,
            this.colDIEM,
            this.colGHICHU,
            this.colNGHIEMTRONG,
            this.colCREATED_BY,
            this.colCREATED_DATE,
            this.colUPDATED_BY,
            this.colUPDATED_DATE,
            this.colDELETED_BY,
            this.colDELETED_DATE});
            this.gvViPham.GridControl = this.gdDanhSach;
            this.gvViPham.Name = "gvViPham";
            // 
            // colMAVP
            // 
            this.colMAVP.FieldName = "MAVP";
            this.colMAVP.MinWidth = 30;
            this.colMAVP.Name = "colMAVP";
            this.colMAVP.Visible = true;
            this.colMAVP.VisibleIndex = 0;
            this.colMAVP.Width = 112;
            // 
            // colTENVP
            // 
            this.colTENVP.FieldName = "TENVP";
            this.colTENVP.MinWidth = 30;
            this.colTENVP.Name = "colTENVP";
            this.colTENVP.Visible = true;
            this.colTENVP.VisibleIndex = 1;
            this.colTENVP.Width = 112;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 30;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            this.colDIEM.Width = 112;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.MinWidth = 30;
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 3;
            this.colGHICHU.Width = 112;
            // 
            // colNGHIEMTRONG
            // 
            this.colNGHIEMTRONG.FieldName = "NGHIEMTRONG";
            this.colNGHIEMTRONG.MinWidth = 30;
            this.colNGHIEMTRONG.Name = "colNGHIEMTRONG";
            this.colNGHIEMTRONG.Visible = true;
            this.colNGHIEMTRONG.VisibleIndex = 4;
            this.colNGHIEMTRONG.Width = 112;
            // 
            // colCREATED_BY
            // 
            this.colCREATED_BY.FieldName = "CREATED_BY";
            this.colCREATED_BY.MinWidth = 30;
            this.colCREATED_BY.Name = "colCREATED_BY";
            this.colCREATED_BY.Visible = true;
            this.colCREATED_BY.VisibleIndex = 5;
            this.colCREATED_BY.Width = 112;
            // 
            // colCREATED_DATE
            // 
            this.colCREATED_DATE.FieldName = "CREATED_DATE";
            this.colCREATED_DATE.MinWidth = 30;
            this.colCREATED_DATE.Name = "colCREATED_DATE";
            this.colCREATED_DATE.Visible = true;
            this.colCREATED_DATE.VisibleIndex = 6;
            this.colCREATED_DATE.Width = 112;
            // 
            // colUPDATED_BY
            // 
            this.colUPDATED_BY.FieldName = "UPDATED_BY";
            this.colUPDATED_BY.MinWidth = 30;
            this.colUPDATED_BY.Name = "colUPDATED_BY";
            this.colUPDATED_BY.Visible = true;
            this.colUPDATED_BY.VisibleIndex = 7;
            this.colUPDATED_BY.Width = 112;
            // 
            // colUPDATED_DATE
            // 
            this.colUPDATED_DATE.FieldName = "UPDATED_DATE";
            this.colUPDATED_DATE.MinWidth = 30;
            this.colUPDATED_DATE.Name = "colUPDATED_DATE";
            this.colUPDATED_DATE.Visible = true;
            this.colUPDATED_DATE.VisibleIndex = 8;
            this.colUPDATED_DATE.Width = 112;
            // 
            // colDELETED_BY
            // 
            this.colDELETED_BY.FieldName = "DELETED_BY";
            this.colDELETED_BY.MinWidth = 30;
            this.colDELETED_BY.Name = "colDELETED_BY";
            this.colDELETED_BY.Visible = true;
            this.colDELETED_BY.VisibleIndex = 9;
            this.colDELETED_BY.Width = 112;
            // 
            // colDELETED_DATE
            // 
            this.colDELETED_DATE.FieldName = "DELETED_DATE";
            this.colDELETED_DATE.MinWidth = 30;
            this.colDELETED_DATE.Name = "colDELETED_DATE";
            this.colDELETED_DATE.Visible = true;
            this.colDELETED_DATE.VisibleIndex = 10;
            this.colDELETED_DATE.Width = 112;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(979, 77);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 34);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmDanhMucViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 416);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDanhMucViPham";
            this.Text = "frmDanhMucViPham";
            this.Load += new System.EventHandler(this.frmDanhMucViPham_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spindiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenvp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDanhMucLoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvViPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIn;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnDong;
        private Label label1;
        private Label label2;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txttenvp;
        private DevExpress.XtraEditors.TextEdit txtghichu;
        private CheckBox checkBox1;
        private DevExpress.XtraEditors.SpinEdit spindiem;
        private DevExpress.XtraGrid.GridControl gdDanhSach;
        private BindingSource tbDanhMucLoiBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvViPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVP;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIEMTRONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATED_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colUPDATED_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colDELETED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colDELETED_DATE;
        private Button btnExcel;
        private Button btnExport;
    }
}