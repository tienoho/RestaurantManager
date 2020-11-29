using DevExpress.XtraEditors;

namespace RestaurantManager.Views.Order
{
    partial class frmPNhap
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNguoiGiao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lueDONGIAO = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcD_DONMH = new DevExpress.XtraGrid.GridControl();
            this.gvD_NHAP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslmh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslnhanhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueStorekeeper = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nslgiaohang = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.luenlieu = new DevExpress.XtraEditors.LookUpEdit();
            this.nslnhanhang = new DevExpress.XtraEditors.TextEdit();
            this.btnClearDetails = new System.Windows.Forms.Button();
            this.btnDeleteDetails = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDONGIAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcD_DONMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvD_NHAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStorekeeper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nslgiaohang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luenlieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nslnhanhang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(329, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "CHI TIẾT ĐƠN MUA HÀNG";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtNguoiNhan);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtNguoiGiao);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lueDONGIAO);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Controls.Add(this.lueStorekeeper);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtngaynhap);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 675);
            this.panel2.TabIndex = 15;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(369, 112);
            this.txtNguoiNhan.MaxLength = 50;
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(168, 22);
            this.txtNguoiNhan.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(278, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Người nhận:";
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.Location = new System.Drawing.Point(121, 112);
            this.txtNguoiGiao.MaxLength = 50;
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.ReadOnly = true;
            this.txtNguoiGiao.Size = new System.Drawing.Size(142, 22);
            this.txtNguoiGiao.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Người giao:";
            // 
            // lueDONGIAO
            // 
            this.lueDONGIAO.Location = new System.Drawing.Point(121, 67);
            this.lueDONGIAO.Name = "lueDONGIAO";
            this.lueDONGIAO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDONGIAO.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idpgiao", "Đơn giao hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ngaygiao", "Ngày giao"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nguoigiao", "Người giao"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nguoinhan", "Người nhận")});
            this.lueDONGIAO.Properties.NullText = "";
            this.lueDONGIAO.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueDONGIAO.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueDONGIAO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDONGIAO.Size = new System.Drawing.Size(416, 20);
            this.lueDONGIAO.TabIndex = 36;
            this.lueDONGIAO.EditValueChanged += new System.EventHandler(this.lueDONGIAO_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Đơn giao:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::RestaurantManager.Properties.Resources.x2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(578, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "Hủy bỏ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::RestaurantManager.Properties.Resources.icons8_save_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(578, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 34;
            this.button2.Text = "Lưu lại";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gcD_DONMH);
            this.panelControl1.Location = new System.Drawing.Point(10, 309);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(951, 364);
            this.panelControl1.TabIndex = 21;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // gcD_DONMH
            // 
            this.gcD_DONMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcD_DONMH.Location = new System.Drawing.Point(2, 2);
            this.gcD_DONMH.MainView = this.gvD_NHAP;
            this.gcD_DONMH.Name = "gcD_DONMH";
            this.gcD_DONMH.Size = new System.Drawing.Size(947, 360);
            this.gcD_DONMH.TabIndex = 0;
            this.gcD_DONMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvD_NHAP});
            this.gcD_DONMH.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gcD_DONMH_ViewRegistered);
            this.gcD_DONMH.Click += new System.EventHandler(this.gcD_DONMH_Click);
            // 
            // gvD_NHAP
            // 
            this.gvD_NHAP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhang,
            this.gctenhang,
            this.gcslmh,
            this.gcslnhanhang,
            this.gridColumn1});
            this.gvD_NHAP.GridControl = this.gcD_DONMH;
            this.gvD_NHAP.Name = "gvD_NHAP";
            this.gvD_NHAP.OptionsBehavior.Editable = false;
            this.gvD_NHAP.OptionsBehavior.ReadOnly = true;
            this.gvD_NHAP.OptionsCustomization.AllowFilter = false;
            this.gvD_NHAP.OptionsCustomization.AllowGroup = false;
            this.gvD_NHAP.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.True;
            this.gvD_NHAP.OptionsFind.AllowFindPanel = false;
            this.gvD_NHAP.DoubleClick += new System.EventHandler(this.gvD_DONMH_DoubleClick);
            // 
            // gcidhang
            // 
            this.gcidhang.Caption = "Mã hàng";
            this.gcidhang.FieldName = "idhang";
            this.gcidhang.Name = "gcidhang";
            this.gcidhang.Visible = true;
            this.gcidhang.VisibleIndex = 0;
            this.gcidhang.Width = 100;
            // 
            // gctenhang
            // 
            this.gctenhang.Caption = "Tên hàng";
            this.gctenhang.FieldName = "tenhang";
            this.gctenhang.Name = "gctenhang";
            this.gctenhang.Visible = true;
            this.gctenhang.VisibleIndex = 1;
            this.gctenhang.Width = 351;
            // 
            // gcslmh
            // 
            this.gcslmh.Caption = "Số lượng giao hàng";
            this.gcslmh.DisplayFormat.FormatString = "#,###";
            this.gcslmh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcslmh.FieldName = "slgiao";
            this.gcslmh.Name = "gcslmh";
            this.gcslmh.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "slmh", "SL: {0:0.##}")});
            this.gcslmh.Visible = true;
            this.gcslmh.VisibleIndex = 2;
            this.gcslmh.Width = 203;
            // 
            // gcslnhanhang
            // 
            this.gcslnhanhang.Caption = "Số lượng nhận hàng";
            this.gcslnhanhang.FieldName = "slnhanhang";
            this.gcslnhanhang.Name = "gcslnhanhang";
            this.gcslnhanhang.Width = 191;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số lượng nhập";
            this.gridColumn1.FieldName = "slnhan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 170;
            // 
            // lueStorekeeper
            // 
            this.lueStorekeeper.Location = new System.Drawing.Point(121, 89);
            this.lueStorekeeper.Name = "lueStorekeeper";
            this.lueStorekeeper.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStorekeeper.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Tên thủ kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChucVu", "Chức vụ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SoDT", "Điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiaChi", "Địa chỉ")});
            this.lueStorekeeper.Properties.NullText = "";
            this.lueStorekeeper.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueStorekeeper.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueStorekeeper.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueStorekeeper.Size = new System.Drawing.Size(416, 20);
            this.lueStorekeeper.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thủ kho:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Location = new System.Drawing.Point(10, 163);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(951, 142);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Danh sách hàng hóa";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nslgiaohang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.luenlieu);
            this.panel1.Controls.Add(this.nslnhanhang);
            this.panel1.Controls.Add(this.btnClearDetails);
            this.panel1.Controls.Add(this.btnDeleteDetails);
            this.panel1.Controls.Add(this.btnUpdateDetails);
            this.panel1.Controls.Add(this.btnAddDetails);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txttenhang);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 120);
            this.panel1.TabIndex = 3;
            // 
            // nslgiaohang
            // 
            this.nslgiaohang.Enabled = false;
            this.nslgiaohang.Location = new System.Drawing.Point(509, 6);
            this.nslgiaohang.Name = "nslgiaohang";
            this.nslgiaohang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nslgiaohang.Properties.Appearance.Options.UseFont = true;
            this.nslgiaohang.Properties.DisplayFormat.FormatString = "#,###";
            this.nslgiaohang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.nslgiaohang.Properties.Mask.EditMask = "n0";
            this.nslgiaohang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.nslgiaohang.Properties.MaxLength = 9;
            this.nslgiaohang.Properties.NullText = "0";
            this.nslgiaohang.Properties.UseReadOnlyAppearance = false;
            this.nslgiaohang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nslgiaohang.Size = new System.Drawing.Size(146, 20);
            this.nslgiaohang.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số lượng giao hàng:";
            // 
            // luenlieu
            // 
            this.luenlieu.Location = new System.Drawing.Point(96, 6);
            this.luenlieu.Name = "luenlieu";
            this.luenlieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luenlieu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idhang", "Mã hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenhang", "Tên hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("slton", "Số lượng tồn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nguong", "Ngưỡng")});
            this.luenlieu.Properties.NullText = "";
            this.luenlieu.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.luenlieu.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.luenlieu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luenlieu.Size = new System.Drawing.Size(228, 20);
            this.luenlieu.TabIndex = 31;
            this.luenlieu.EditValueChanged += new System.EventHandler(this.luenlieu_EditValueChanged_1);
            // 
            // nslnhanhang
            // 
            this.nslnhanhang.Location = new System.Drawing.Point(509, 38);
            this.nslnhanhang.Name = "nslnhanhang";
            this.nslnhanhang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nslnhanhang.Properties.Appearance.Options.UseFont = true;
            this.nslnhanhang.Properties.DisplayFormat.FormatString = "#,###";
            this.nslnhanhang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.nslnhanhang.Properties.Mask.EditMask = "n0";
            this.nslnhanhang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.nslnhanhang.Properties.MaxLength = 9;
            this.nslnhanhang.Properties.NullText = "0";
            this.nslnhanhang.Properties.UseReadOnlyAppearance = false;
            this.nslnhanhang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nslnhanhang.Size = new System.Drawing.Size(146, 20);
            this.nslnhanhang.TabIndex = 29;
            // 
            // btnClearDetails
            // 
            this.btnClearDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDetails.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClearDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDetails.Location = new System.Drawing.Point(226, 67);
            this.btnClearDetails.Name = "btnClearDetails";
            this.btnClearDetails.Size = new System.Drawing.Size(73, 28);
            this.btnClearDetails.TabIndex = 19;
            this.btnClearDetails.Text = "Clear";
            this.btnClearDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearDetails.UseVisualStyleBackColor = true;
            this.btnClearDetails.Visible = false;
            this.btnClearDetails.Click += new System.EventHandler(this.btnClearDetails_Click);
            // 
            // btnDeleteDetails
            // 
            this.btnDeleteDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetails.Image = global::RestaurantManager.Properties.Resources.delete_3;
            this.btnDeleteDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDetails.Location = new System.Drawing.Point(157, 66);
            this.btnDeleteDetails.Name = "btnDeleteDetails";
            this.btnDeleteDetails.Size = new System.Drawing.Size(63, 28);
            this.btnDeleteDetails.TabIndex = 16;
            this.btnDeleteDetails.Text = "Xóa";
            this.btnDeleteDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteDetails.UseVisualStyleBackColor = false;
            this.btnDeleteDetails.Visible = false;
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
            this.btnUpdateDetails.Location = new System.Drawing.Point(88, 66);
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
            this.btnAddDetails.Location = new System.Drawing.Point(13, 66);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(69, 28);
            this.btnAddDetails.TabIndex = 18;
            this.btnAddDetails.Text = "Thêm";
            this.btnAddDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDetails.UseVisualStyleBackColor = false;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng nhận hàng:";
            // 
            // txttenhang
            // 
            this.txttenhang.Enabled = false;
            this.txttenhang.Location = new System.Drawing.Point(96, 34);
            this.txttenhang.MaxLength = 50;
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(228, 21);
            this.txttenhang.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "PHIẾU NHẬP KHO";
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.CustomFormat = "hh:mm dd/MM/yyyy";
            this.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaynhap.Location = new System.Drawing.Point(372, 44);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(165, 22);
            this.dtngaynhap.TabIndex = 23;
            this.dtngaynhap.Value = new System.DateTime(2020, 11, 21, 19, 10, 58, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày nhập:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtid.Location = new System.Drawing.Point(121, 44);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(142, 22);
            this.txtid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phiếu:";
            // 
            // frmPNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Name = "frmPNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới phiếu nhập kho";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDONGIAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcD_DONMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvD_NHAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStorekeeper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nslgiaohang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luenlieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nslnhanhang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lueStorekeeper;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcD_DONMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit luenlieu;
        private DevExpress.XtraEditors.TextEdit nslnhanhang;
        private System.Windows.Forms.Button btnClearDetails;
        private System.Windows.Forms.Button btnDeleteDetails;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.Views.Grid.GridView gvD_NHAP;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhang;
        private DevExpress.XtraGrid.Columns.GridColumn gctenhang;
        private DevExpress.XtraGrid.Columns.GridColumn gcslmh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public DevExpress.XtraEditors.TextEdit nslgiaohang;
        private DevExpress.XtraEditors.LookUpEdit lueDONGIAO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNguoiGiao;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.Columns.GridColumn gcslnhanhang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}