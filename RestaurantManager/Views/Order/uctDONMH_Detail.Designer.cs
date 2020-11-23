using DevExpress.XtraEditors;

namespace RestaurantManager
{
    partial class uctDONMH_Detail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbAgency = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpnyc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcPYCDetails = new DevExpress.XtraGrid.GridControl();
            this.gvPYCDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcdongianl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsldukien = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lueNLieu = new DevExpress.XtraEditors.LookUpEdit();
            this.txtslton = new DevExpress.XtraEditors.TextEdit();
            this.btnClearDetails = new System.Windows.Forms.Button();
            this.txtnguong = new DevExpress.XtraEditors.TextEdit();
            this.btnDeleteDetails = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcPYC = new DevExpress.XtraGrid.GridControl();
            this.gvPYC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidyc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcngayyc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grbAgency.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPYCDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPYCDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsldukien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtslton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPYC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPYC)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(139, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "TẠO ĐƠN MUA HÀNG";
            // 
            // grbAgency
            // 
            this.grbAgency.Controls.Add(this.panel2);
            this.grbAgency.Location = new System.Drawing.Point(3, 40);
            this.grbAgency.Name = "grbAgency";
            this.grbAgency.Size = new System.Drawing.Size(439, 184);
            this.grbAgency.TabIndex = 14;
            this.grbAgency.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtpnyc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 165);
            this.panel2.TabIndex = 2;
            // 
            // dtpnyc
            // 
            this.dtpnyc.CustomFormat = "hh:mm dd/MM/yyyy";
            this.dtpnyc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpnyc.Location = new System.Drawing.Point(154, 55);
            this.dtpnyc.Name = "dtpnyc";
            this.dtpnyc.Size = new System.Drawing.Size(252, 21);
            this.dtpnyc.TabIndex = 23;
            this.dtpnyc.Value = new System.DateTime(2020, 11, 21, 19, 10, 58, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày tạo";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::RestaurantManager.Properties.Resources.icons8_save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(154, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 28);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(154, 24);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(252, 21);
            this.txtid.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(154, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 29);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Làm mới";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::RestaurantManager.Properties.Resources.add_2;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(245, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 28);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm phiếu yêu cầu";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã mua hàng";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gcPYCDetails);
            this.panelControl1.Location = new System.Drawing.Point(451, 163);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(830, 341);
            this.panelControl1.TabIndex = 20;
            // 
            // gcPYCDetails
            // 
            this.gcPYCDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPYCDetails.Location = new System.Drawing.Point(2, 2);
            this.gcPYCDetails.MainView = this.gvPYCDetails;
            this.gcPYCDetails.Name = "gcPYCDetails";
            this.gcPYCDetails.Size = new System.Drawing.Size(826, 337);
            this.gcPYCDetails.TabIndex = 0;
            this.gcPYCDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPYCDetails});
            this.gcPYCDetails.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gvPYCDetails
            // 
            this.gvPYCDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhang,
            this.gctenhang,
            this.gcslton,
            this.gcnguong,
            this.gcdongianl,
            this.gcCreateBy,
            this.gcCreateDate});
            this.gvPYCDetails.GridControl = this.gcPYCDetails;
            this.gvPYCDetails.Name = "gvPYCDetails";
            this.gvPYCDetails.OptionsBehavior.Editable = false;
            this.gvPYCDetails.OptionsBehavior.ReadOnly = true;
            this.gvPYCDetails.OptionsFind.AlwaysVisible = true;
            this.gvPYCDetails.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gcidhang
            // 
            this.gcidhang.Caption = "Mã hàng";
            this.gcidhang.FieldName = "idhang";
            this.gcidhang.Name = "gcidhang";
            this.gcidhang.Visible = true;
            this.gcidhang.VisibleIndex = 0;
            this.gcidhang.Width = 35;
            // 
            // gctenhang
            // 
            this.gctenhang.Caption = "Tên hàng";
            this.gctenhang.FieldName = "tenhang";
            this.gctenhang.Name = "gctenhang";
            this.gctenhang.Visible = true;
            this.gctenhang.VisibleIndex = 1;
            // 
            // gcslton
            // 
            this.gcslton.Caption = "Số lượng tồn";
            this.gcslton.FieldName = "slton";
            this.gcslton.Name = "gcslton";
            this.gcslton.Visible = true;
            this.gcslton.VisibleIndex = 2;
            // 
            // gcnguong
            // 
            this.gcnguong.Caption = "Ngưỡng";
            this.gcnguong.FieldName = "nguong";
            this.gcnguong.Name = "gcnguong";
            this.gcnguong.Visible = true;
            this.gcnguong.VisibleIndex = 3;
            // 
            // gcdongianl
            // 
            this.gcdongianl.Caption = "Đơn giá";
            this.gcdongianl.DisplayFormat.FormatString = "#,###";
            this.gcdongianl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcdongianl.FieldName = "dongianl";
            this.gcdongianl.Name = "gcdongianl";
            this.gcdongianl.Visible = true;
            this.gcdongianl.VisibleIndex = 4;
            // 
            // gcCreateBy
            // 
            this.gcCreateBy.Caption = "Người tạo";
            this.gcCreateBy.FieldName = "CreateBy";
            this.gcCreateBy.Name = "gcCreateBy";
            this.gcCreateBy.Visible = true;
            this.gcCreateBy.VisibleIndex = 5;
            // 
            // gcCreateDate
            // 
            this.gcCreateDate.Caption = "Ngày tạo";
            this.gcCreateDate.FieldName = "CreateDate";
            this.gcCreateDate.Name = "gcCreateDate";
            this.gcCreateDate.Visible = true;
            this.gcCreateDate.VisibleIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(451, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 119);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtsldukien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lueNLieu);
            this.panel1.Controls.Add(this.txtslton);
            this.panel1.Controls.Add(this.btnClearDetails);
            this.panel1.Controls.Add(this.txtnguong);
            this.panel1.Controls.Add(this.btnDeleteDetails);
            this.panel1.Controls.Add(this.btnUpdateDetails);
            this.panel1.Controls.Add(this.btnAddDetails);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenHang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 100);
            this.panel1.TabIndex = 2;
            // 
            // txtsldukien
            // 
            this.txtsldukien.Enabled = false;
            this.txtsldukien.Location = new System.Drawing.Point(448, 6);
            this.txtsldukien.Name = "txtsldukien";
            this.txtsldukien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtsldukien.Properties.Appearance.Options.UseFont = true;
            this.txtsldukien.Properties.DisplayFormat.FormatString = "#,###";
            this.txtsldukien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsldukien.Properties.Mask.EditMask = "n0";
            this.txtsldukien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtsldukien.Properties.MaxLength = 9;
            this.txtsldukien.Properties.NullText = "0";
            this.txtsldukien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsldukien.Size = new System.Drawing.Size(146, 20);
            this.txtsldukien.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số lượng dự kiến";
            // 
            // lueNLieu
            // 
            this.lueNLieu.Enabled = false;
            this.lueNLieu.Location = new System.Drawing.Point(96, 6);
            this.lueNLieu.Name = "lueNLieu";
            this.lueNLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNLieu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idhang", "Mã hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenhang", "Tên hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("slton", "Số lượng tồn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nguong", "Ngưỡng")});
            this.lueNLieu.Properties.NullText = "";
            this.lueNLieu.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueNLieu.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueNLieu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueNLieu.Size = new System.Drawing.Size(228, 20);
            this.lueNLieu.TabIndex = 31;
            this.lueNLieu.EditValueChanged += new System.EventHandler(this.lueNLieu_EditValueChanged);
            // 
            // txtslton
            // 
            this.txtslton.Enabled = false;
            this.txtslton.Location = new System.Drawing.Point(448, 36);
            this.txtslton.Name = "txtslton";
            this.txtslton.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtslton.Properties.Appearance.Options.UseFont = true;
            this.txtslton.Properties.DisplayFormat.FormatString = "#,###";
            this.txtslton.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtslton.Properties.Mask.EditMask = "n0";
            this.txtslton.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtslton.Properties.MaxLength = 9;
            this.txtslton.Properties.NullText = "0";
            this.txtslton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtslton.Size = new System.Drawing.Size(146, 20);
            this.txtslton.TabIndex = 29;
            // 
            // btnClearDetails
            // 
            this.btnClearDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDetails.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClearDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDetails.Location = new System.Drawing.Point(5, 66);
            this.btnClearDetails.Name = "btnClearDetails";
            this.btnClearDetails.Size = new System.Drawing.Size(87, 28);
            this.btnClearDetails.TabIndex = 19;
            this.btnClearDetails.Text = "Làm mới";
            this.btnClearDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearDetails.UseVisualStyleBackColor = true;
            // 
            // txtnguong
            // 
            this.txtnguong.Enabled = false;
            this.txtnguong.Location = new System.Drawing.Point(663, 6);
            this.txtnguong.Name = "txtnguong";
            this.txtnguong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtnguong.Properties.Appearance.Options.UseFont = true;
            this.txtnguong.Properties.DisplayFormat.FormatString = "#,###";
            this.txtnguong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnguong.Properties.EditFormat.FormatString = "n0";
            this.txtnguong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnguong.Properties.Mask.EditMask = "n0";
            this.txtnguong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtnguong.Properties.MaxLength = 9;
            this.txtnguong.Properties.NullText = "0";
            this.txtnguong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnguong.Size = new System.Drawing.Size(146, 20);
            this.txtnguong.TabIndex = 28;
            // 
            // btnDeleteDetails
            // 
            this.btnDeleteDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetails.Image = global::RestaurantManager.Properties.Resources.delete_3;
            this.btnDeleteDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDetails.Location = new System.Drawing.Point(261, 66);
            this.btnDeleteDetails.Name = "btnDeleteDetails";
            this.btnDeleteDetails.Size = new System.Drawing.Size(63, 28);
            this.btnDeleteDetails.TabIndex = 16;
            this.btnDeleteDetails.Text = "Xóa";
            this.btnDeleteDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteDetails.UseVisualStyleBackColor = false;
            this.btnDeleteDetails.Click += new System.EventHandler(this.btnDeleteDetails_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdateDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.Image = global::RestaurantManager.Properties.Resources.update_5;
            this.btnUpdateDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDetails.Location = new System.Drawing.Point(194, 66);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(63, 28);
            this.btnUpdateDetails.TabIndex = 17;
            this.btnUpdateDetails.Text = "Sửa";
            this.btnUpdateDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateDetails.UseVisualStyleBackColor = false;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetails.ForeColor = System.Drawing.Color.Black;
            this.btnAddDetails.Image = global::RestaurantManager.Properties.Resources.add_2;
            this.btnAddDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDetails.Location = new System.Drawing.Point(96, 66);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(92, 28);
            this.btnAddDetails.TabIndex = 18;
            this.btnAddDetails.Text = "Thêm mới";
            this.btnAddDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDetails.UseVisualStyleBackColor = false;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngưỡng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng tồn";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Location = new System.Drawing.Point(96, 34);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(228, 21);
            this.txtTenHang.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã hàng";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcPYC);
            this.panelControl2.Location = new System.Drawing.Point(3, 227);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(439, 277);
            this.panelControl2.TabIndex = 22;
            // 
            // gcPYC
            // 
            this.gcPYC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPYC.Location = new System.Drawing.Point(2, 2);
            this.gcPYC.MainView = this.gvPYC;
            this.gcPYC.Name = "gcPYC";
            this.gcPYC.Size = new System.Drawing.Size(435, 273);
            this.gcPYC.TabIndex = 0;
            this.gcPYC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPYC});
            this.gcPYC.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gcPYC_ViewRegistered);
            // 
            // gvPYC
            // 
            this.gvPYC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidyc,
            this.gcngayyc,
            this.gridColumn1});
            this.gvPYC.GridControl = this.gcPYC;
            this.gvPYC.Name = "gvPYC";
            this.gvPYC.OptionsBehavior.Editable = false;
            this.gvPYC.OptionsBehavior.ReadOnly = true;
            this.gvPYC.DoubleClick += new System.EventHandler(this.gvPYC_DoubleClick);
            // 
            // gcidyc
            // 
            this.gcidyc.Caption = "Mã yêu cầu";
            this.gcidyc.FieldName = "idyc";
            this.gcidyc.Name = "gcidyc";
            this.gcidyc.Visible = true;
            this.gcidyc.VisibleIndex = 0;
            this.gcidyc.Width = 65;
            // 
            // gcngayyc
            // 
            this.gcngayyc.Caption = "Ngày yêu cầu";
            this.gcngayyc.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gcngayyc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcngayyc.FieldName = "ngayyc";
            this.gcngayyc.Name = "gcngayyc";
            this.gcngayyc.Visible = true;
            this.gcngayyc.VisibleIndex = 1;
            this.gcngayyc.Width = 174;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Người tạo yêu cầu";
            this.gridColumn1.FieldName = "CreateBy";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 178;
            // 
            // uctDONMH_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grbAgency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "uctDONMH_Detail";
            this.Size = new System.Drawing.Size(1284, 525);
            this.Load += new System.EventHandler(this.uctCreate_PYC_Load);
            this.grbAgency.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPYCDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPYCDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsldukien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtslton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPYC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPYC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbAgency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcPYCDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPYCDetails;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhang;
        private DevExpress.XtraGrid.Columns.GridColumn gctenhang;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateBy;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcslton;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguong;
        private DevExpress.XtraGrid.Columns.GridColumn gcdongianl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private LookUpEdit lueNLieu;
        private TextEdit txtslton;
        private System.Windows.Forms.Button btnClearDetails;
        private TextEdit txtnguong;
        private System.Windows.Forms.Button btnDeleteDetails;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private TextEdit txtsldukien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpnyc;
        private PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcPYC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPYC;
        private DevExpress.XtraGrid.Columns.GridColumn gcidyc;
        private DevExpress.XtraGrid.Columns.GridColumn gcngayyc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Button btnAdd;
    }
}