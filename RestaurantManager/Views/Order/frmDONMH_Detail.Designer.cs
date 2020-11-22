namespace RestaurantManager.Views.Order
{
    partial class frmDONMH_Detail
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcD_DONMH = new DevExpress.XtraGrid.GridControl();
            this.gvD_DONMH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslmh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcdongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctotalamount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luencc = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nslmh = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.luenlieu = new DevExpress.XtraEditors.LookUpEdit();
            this.ndongiamh = new DevExpress.XtraEditors.TextEdit();
            this.btnClearDetails = new System.Windows.Forms.Button();
            this.btnDeleteDetails = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtngaydonmh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcD_DONMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvD_DONMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luencc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nslmh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luenlieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndongiamh.Properties)).BeginInit();
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Controls.Add(this.luencc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtngaydonmh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 577);
            this.panel2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::RestaurantManager.Properties.Resources.x2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(841, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
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
            this.button2.Location = new System.Drawing.Point(745, 61);
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
            this.panelControl1.Location = new System.Drawing.Point(10, 220);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(922, 345);
            this.panelControl1.TabIndex = 21;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // gcD_DONMH
            // 
            this.gcD_DONMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcD_DONMH.Location = new System.Drawing.Point(2, 2);
            this.gcD_DONMH.MainView = this.gvD_DONMH;
            this.gcD_DONMH.Name = "gcD_DONMH";
            this.gcD_DONMH.Size = new System.Drawing.Size(918, 341);
            this.gcD_DONMH.TabIndex = 0;
            this.gcD_DONMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvD_DONMH});
            this.gcD_DONMH.Click += new System.EventHandler(this.gcD_DONMH_Click);
            // 
            // gvD_DONMH
            // 
            this.gvD_DONMH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhang,
            this.gctenhang,
            this.gcslmh,
            this.gcdongia,
            this.gctotalamount});
            this.gvD_DONMH.GridControl = this.gcD_DONMH;
            this.gvD_DONMH.Name = "gvD_DONMH";
            this.gvD_DONMH.OptionsBehavior.Editable = false;
            this.gvD_DONMH.OptionsBehavior.ReadOnly = true;
            this.gvD_DONMH.OptionsCustomization.AllowFilter = false;
            this.gvD_DONMH.OptionsCustomization.AllowGroup = false;
            this.gvD_DONMH.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.True;
            this.gvD_DONMH.OptionsFind.AllowFindPanel = false;
            // 
            // gcidhang
            // 
            this.gcidhang.Caption = "Mã hàng";
            this.gcidhang.FieldName = "idhang";
            this.gcidhang.Name = "gcidhang";
            this.gcidhang.Visible = true;
            this.gcidhang.VisibleIndex = 0;
            this.gcidhang.Width = 94;
            // 
            // gctenhang
            // 
            this.gctenhang.Caption = "Tên hàng";
            this.gctenhang.FieldName = "tenhang";
            this.gctenhang.Name = "gctenhang";
            this.gctenhang.Visible = true;
            this.gctenhang.VisibleIndex = 1;
            this.gctenhang.Width = 201;
            // 
            // gcslmh
            // 
            this.gcslmh.Caption = "Số lượng ";
            this.gcslmh.FieldName = "slmh";
            this.gcslmh.Name = "gcslmh";
            this.gcslmh.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "slmh", "SL: {0:0.##}")});
            this.gcslmh.Visible = true;
            this.gcslmh.VisibleIndex = 2;
            this.gcslmh.Width = 104;
            // 
            // gcdongia
            // 
            this.gcdongia.Caption = "Đơn giá";
            this.gcdongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcdongia.FieldName = "dongiamh";
            this.gcdongia.Name = "gcdongia";
            this.gcdongia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dongiamh", "ĐG: {0:0.##}")});
            this.gcdongia.Visible = true;
            this.gcdongia.VisibleIndex = 3;
            this.gcdongia.Width = 249;
            // 
            // gctotalamount
            // 
            this.gctotalamount.Caption = "Thành tiền";
            this.gctotalamount.FieldName = "totalamount";
            this.gctotalamount.Name = "gctotalamount";
            this.gctotalamount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totalamount", "Tổng cộng : {0:0.##}")});
            this.gctotalamount.Visible = true;
            this.gctotalamount.VisibleIndex = 4;
            this.gctotalamount.Width = 252;
            // 
            // luencc
            // 
            this.luencc.Enabled = false;
            this.luencc.Location = new System.Drawing.Point(121, 72);
            this.luencc.Name = "luencc";
            this.luencc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luencc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idncc", "Mã NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenncc", "Tên NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("sdt", "Số điện thoại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("diachi", "Địa chỉ")});
            this.luencc.Properties.NullText = "";
            this.luencc.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.luencc.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.luencc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luencc.Size = new System.Drawing.Size(416, 20);
            this.luencc.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nhà cung cấp:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Location = new System.Drawing.Point(10, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(922, 350);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Danh sách hàng hóa";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nslmh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.luenlieu);
            this.panel1.Controls.Add(this.ndongiamh);
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
            this.panel1.Size = new System.Drawing.Size(918, 328);
            this.panel1.TabIndex = 3;
            // 
            // nslmh
            // 
            this.nslmh.Enabled = false;
            this.nslmh.Location = new System.Drawing.Point(448, 6);
            this.nslmh.Name = "nslmh";
            this.nslmh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nslmh.Properties.Appearance.Options.UseFont = true;
            this.nslmh.Properties.DisplayFormat.FormatString = "#,###";
            this.nslmh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.nslmh.Properties.Mask.EditMask = "n0";
            this.nslmh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.nslmh.Properties.MaxLength = 9;
            this.nslmh.Properties.NullText = "0";
            this.nslmh.Properties.UseReadOnlyAppearance = false;
            this.nslmh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nslmh.Size = new System.Drawing.Size(75, 20);
            this.nslmh.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số lượng:";
            // 
            // luenlieu
            // 
            this.luenlieu.Enabled = false;
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
            // ndongiamh
            // 
            this.ndongiamh.Enabled = false;
            this.ndongiamh.Location = new System.Drawing.Point(448, 36);
            this.ndongiamh.Name = "ndongiamh";
            this.ndongiamh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ndongiamh.Properties.Appearance.Options.UseFont = true;
            this.ndongiamh.Properties.DisplayFormat.FormatString = "#,###";
            this.ndongiamh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ndongiamh.Properties.Mask.EditMask = "n0";
            this.ndongiamh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ndongiamh.Properties.MaxLength = 9;
            this.ndongiamh.Properties.NullText = "0";
            this.ndongiamh.Properties.UseReadOnlyAppearance = false;
            this.ndongiamh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ndongiamh.Size = new System.Drawing.Size(146, 20);
            this.ndongiamh.TabIndex = 29;
            // 
            // btnClearDetails
            // 
            this.btnClearDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDetails.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClearDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDetails.Location = new System.Drawing.Point(5, 66);
            this.btnClearDetails.Name = "btnClearDetails";
            this.btnClearDetails.Size = new System.Drawing.Size(73, 28);
            this.btnClearDetails.TabIndex = 19;
            this.btnClearDetails.Text = "Clear";
            this.btnClearDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearDetails.UseVisualStyleBackColor = true;
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
            this.btnDeleteDetails.Location = new System.Drawing.Point(228, 66);
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
            this.btnUpdateDetails.Location = new System.Drawing.Point(159, 66);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(63, 28);
            this.btnUpdateDetails.TabIndex = 17;
            this.btnUpdateDetails.Text = "Sửa";
            this.btnUpdateDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateDetails.UseVisualStyleBackColor = false;
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
            this.btnAddDetails.Location = new System.Drawing.Point(84, 66);
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
            this.label7.Location = new System.Drawing.Point(330, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Đơn giá:";
            // 
            // txttenhang
            // 
            this.txttenhang.Enabled = false;
            this.txttenhang.Location = new System.Drawing.Point(96, 34);
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
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = " ĐƠN MUA HÀNG";
            // 
            // dtngaydonmh
            // 
            this.dtngaydonmh.CustomFormat = "hh:mm dd/MM/yyyy";
            this.dtngaydonmh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaydonmh.Location = new System.Drawing.Point(372, 44);
            this.dtngaydonmh.Name = "dtngaydonmh";
            this.dtngaydonmh.Size = new System.Drawing.Size(165, 21);
            this.dtngaydonmh.TabIndex = 23;
            this.dtngaydonmh.Value = new System.DateTime(2020, 11, 21, 19, 10, 58, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày tạo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(121, 44);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(116, 21);
            this.txtid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã mua hàng:";
            // 
            // frmDONMH_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Name = "frmDONMH_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới đơn mua hàng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcD_DONMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvD_DONMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luencc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nslmh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luenlieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndongiamh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtngaydonmh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit luencc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcD_DONMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit luenlieu;
        private DevExpress.XtraEditors.TextEdit ndongiamh;
        private System.Windows.Forms.Button btnClearDetails;
        private System.Windows.Forms.Button btnDeleteDetails;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.Views.Grid.GridView gvD_DONMH;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhang;
        private DevExpress.XtraGrid.Columns.GridColumn gctenhang;
        private DevExpress.XtraGrid.Columns.GridColumn gcslmh;
        private DevExpress.XtraGrid.Columns.GridColumn gcdongia;
        private DevExpress.XtraGrid.Columns.GridColumn gctotalamount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public DevExpress.XtraEditors.TextEdit nslmh;
    }
}