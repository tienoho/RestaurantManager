using DevExpress.XtraEditors;

namespace RestaurantManager
{
    partial class uctHOADONTT
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcWaitOrder = new DevExpress.XtraGrid.GridControl();
            this.gvWaitOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gciddondat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcidkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcngaydat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txtiddondat = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcSelectItems = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gctenmon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcdongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcsldat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerPay = new DevExpress.XtraEditors.TextEdit();
            this.txtReturnPay = new DevExpress.XtraEditors.TextEdit();
            this.btnClearHoDon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpngaydat = new System.Windows.Forms.DateTimePicker();
            this.btnAddHoaDon = new System.Windows.Forms.Button();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lueKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcWaitOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWaitOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtiddondat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnPay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(340, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "DANH SÁCH ĐƠN ĐẶT CHƯA THANH TOÁN";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcWaitOrder);
            this.panelControl1.Location = new System.Drawing.Point(3, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(469, 445);
            this.panelControl1.TabIndex = 20;
            // 
            // gcWaitOrder
            // 
            this.gcWaitOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcWaitOrder.Location = new System.Drawing.Point(2, 2);
            this.gcWaitOrder.MainView = this.gvWaitOrder;
            this.gcWaitOrder.Name = "gcWaitOrder";
            this.gcWaitOrder.Size = new System.Drawing.Size(465, 441);
            this.gcWaitOrder.TabIndex = 0;
            this.gcWaitOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWaitOrder});
            this.gcWaitOrder.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gvWaitOrder
            // 
            this.gvWaitOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gciddondat,
            this.gcidkh,
            this.gctenkh,
            this.gcban,
            this.gcngaydat});
            this.gvWaitOrder.GridControl = this.gcWaitOrder;
            this.gvWaitOrder.Name = "gvWaitOrder";
            this.gvWaitOrder.OptionsBehavior.Editable = false;
            this.gvWaitOrder.OptionsBehavior.ReadOnly = true;
            this.gvWaitOrder.OptionsFind.AlwaysVisible = true;
            this.gvWaitOrder.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gvWaitOrder.Click += new System.EventHandler(this.gvWaitOrder_Click);
            this.gvWaitOrder.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gciddondat
            // 
            this.gciddondat.Caption = "Mã đơn";
            this.gciddondat.FieldName = "iddondat";
            this.gciddondat.Name = "gciddondat";
            this.gciddondat.Visible = true;
            this.gciddondat.VisibleIndex = 0;
            this.gciddondat.Width = 35;
            // 
            // gcidkh
            // 
            this.gcidkh.Caption = "Mã kh";
            this.gcidkh.FieldName = "idkh";
            this.gcidkh.Name = "gcidkh";
            // 
            // gctenkh
            // 
            this.gctenkh.Caption = "Khách hàng";
            this.gctenkh.FieldName = "tenkh";
            this.gctenkh.Name = "gctenkh";
            this.gctenkh.Visible = true;
            this.gctenkh.VisibleIndex = 3;
            // 
            // gcban
            // 
            this.gcban.Caption = "Bàn";
            this.gcban.FieldName = "ban";
            this.gcban.Name = "gcban";
            this.gcban.Visible = true;
            this.gcban.VisibleIndex = 2;
            // 
            // gcngaydat
            // 
            this.gcngaydat.Caption = "Ngày đặt";
            this.gcngaydat.FieldName = "ngaydat";
            this.gcngaydat.Name = "gcngaydat";
            this.gcngaydat.Visible = true;
            this.gcngaydat.VisibleIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panelControl6);
            this.panelControl2.Location = new System.Drawing.Point(476, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(808, 443);
            this.panelControl2.TabIndex = 22;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.txtiddondat);
            this.panelControl4.Controls.Add(this.label4);
            this.panelControl4.Controls.Add(this.label3);
            this.panelControl4.Location = new System.Drawing.Point(0, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(529, 57);
            this.panelControl4.TabIndex = 22;
            // 
            // txtiddondat
            // 
            this.txtiddondat.EditValue = "";
            this.txtiddondat.Location = new System.Drawing.Point(92, 8);
            this.txtiddondat.Name = "txtiddondat";
            this.txtiddondat.Properties.MaxLength = 60;
            this.txtiddondat.Properties.NullText = "0";
            this.txtiddondat.Properties.ReadOnly = true;
            this.txtiddondat.Size = new System.Drawing.Size(74, 20);
            this.txtiddondat.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mã đơn đặt";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcSelectItems);
            this.panelControl3.Location = new System.Drawing.Point(0, 60);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(529, 378);
            this.panelControl3.TabIndex = 21;
            // 
            // gcSelectItems
            // 
            this.gcSelectItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSelectItems.Location = new System.Drawing.Point(2, 2);
            this.gcSelectItems.MainView = this.gridView1;
            this.gcSelectItems.Name = "gcSelectItems";
            this.gcSelectItems.Size = new System.Drawing.Size(525, 374);
            this.gcSelectItems.TabIndex = 5;
            this.gcSelectItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gctenmon,
            this.gcdongia,
            this.gcsldat,
            this.gcTotalAmount});
            this.gridView1.GridControl = this.gcSelectItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // gctenmon
            // 
            this.gctenmon.Caption = "Món ăn";
            this.gctenmon.FieldName = "tenmon";
            this.gctenmon.Name = "gctenmon";
            this.gctenmon.Visible = true;
            this.gctenmon.VisibleIndex = 0;
            this.gctenmon.Width = 120;
            // 
            // gcdongia
            // 
            this.gcdongia.Caption = "Đơn giá";
            this.gcdongia.DisplayFormat.FormatString = "#,###";
            this.gcdongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcdongia.FieldName = "dongiamon";
            this.gcdongia.Name = "gcdongia";
            this.gcdongia.Visible = true;
            this.gcdongia.VisibleIndex = 1;
            // 
            // gcsldat
            // 
            this.gcsldat.Caption = "Số lượng";
            this.gcsldat.DisplayFormat.FormatString = "#,###";
            this.gcsldat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcsldat.FieldName = "sldat";
            this.gcsldat.Name = "gcsldat";
            this.gcsldat.Visible = true;
            this.gcsldat.VisibleIndex = 2;
            // 
            // gcTotalAmount
            // 
            this.gcTotalAmount.Caption = "Thành tiền";
            this.gcTotalAmount.DisplayFormat.FormatString = "#,###";
            this.gcTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcTotalAmount.FieldName = "TotalAmount";
            this.gcTotalAmount.Name = "gcTotalAmount";
            this.gcTotalAmount.Visible = true;
            this.gcTotalAmount.VisibleIndex = 3;
            // 
            // panelControl6
            // 
            this.panelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl6.Controls.Add(this.label1);
            this.panelControl6.Controls.Add(this.txtCustomerPay);
            this.panelControl6.Controls.Add(this.txtReturnPay);
            this.panelControl6.Controls.Add(this.btnClearHoDon);
            this.panelControl6.Controls.Add(this.label8);
            this.panelControl6.Controls.Add(this.dtpngaydat);
            this.panelControl6.Controls.Add(this.btnAddHoaDon);
            this.panelControl6.Controls.Add(this.txtTotalAmount);
            this.panelControl6.Controls.Add(this.label10);
            this.panelControl6.Controls.Add(this.label11);
            this.panelControl6.Controls.Add(this.lueKhachHang);
            this.panelControl6.Controls.Add(this.label7);
            this.panelControl6.Controls.Add(this.label6);
            this.panelControl6.Location = new System.Drawing.Point(530, 2);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(276, 436);
            this.panelControl6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tổng tiền";
            // 
            // txtCustomerPay
            // 
            this.txtCustomerPay.Location = new System.Drawing.Point(91, 119);
            this.txtCustomerPay.Name = "txtCustomerPay";
            this.txtCustomerPay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCustomerPay.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerPay.Properties.DisplayFormat.FormatString = "#,###";
            this.txtCustomerPay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCustomerPay.Properties.Mask.EditMask = "n0";
            this.txtCustomerPay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCustomerPay.Properties.MaxLength = 12;
            this.txtCustomerPay.Properties.NullText = "0";
            this.txtCustomerPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCustomerPay.Size = new System.Drawing.Size(159, 20);
            this.txtCustomerPay.TabIndex = 54;
            this.txtCustomerPay.EditValueChanged += new System.EventHandler(this.txtCustomerPay_EditValueChanged);
            this.txtCustomerPay.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtCustomerPay_EditValueChanging);
            // 
            // txtReturnPay
            // 
            this.txtReturnPay.Location = new System.Drawing.Point(91, 145);
            this.txtReturnPay.Name = "txtReturnPay";
            this.txtReturnPay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtReturnPay.Properties.Appearance.Options.UseFont = true;
            this.txtReturnPay.Properties.DisplayFormat.FormatString = "#,###";
            this.txtReturnPay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtReturnPay.Properties.Mask.EditMask = "n0";
            this.txtReturnPay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReturnPay.Properties.MaxLength = 12;
            this.txtReturnPay.Properties.NullText = "0";
            this.txtReturnPay.Properties.ReadOnly = true;
            this.txtReturnPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReturnPay.Size = new System.Drawing.Size(159, 20);
            this.txtReturnPay.TabIndex = 53;
            // 
            // btnClearHoDon
            // 
            this.btnClearHoDon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnClearHoDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearHoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHoDon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHoDon.ForeColor = System.Drawing.Color.Black;
            this.btnClearHoDon.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClearHoDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearHoDon.Location = new System.Drawing.Point(92, 205);
            this.btnClearHoDon.Name = "btnClearHoDon";
            this.btnClearHoDon.Size = new System.Drawing.Size(158, 28);
            this.btnClearHoDon.TabIndex = 52;
            this.btnClearHoDon.Text = "Làm mới";
            this.btnClearHoDon.UseVisualStyleBackColor = false;
            this.btnClearHoDon.Click += new System.EventHandler(this.btnClearHoDon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Khách đưa";
            // 
            // dtpngaydat
            // 
            this.dtpngaydat.Enabled = false;
            this.dtpngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaydat.Location = new System.Drawing.Point(91, 66);
            this.dtpngaydat.Name = "dtpngaydat";
            this.dtpngaydat.Size = new System.Drawing.Size(159, 21);
            this.dtpngaydat.TabIndex = 49;
            // 
            // btnAddHoaDon
            // 
            this.btnAddHoaDon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHoaDon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnAddHoaDon.Image = global::RestaurantManager.Properties.Resources.order_24;
            this.btnAddHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHoaDon.Location = new System.Drawing.Point(91, 171);
            this.btnAddHoaDon.Name = "btnAddHoaDon";
            this.btnAddHoaDon.Size = new System.Drawing.Size(158, 28);
            this.btnAddHoaDon.TabIndex = 48;
            this.btnAddHoaDon.Text = "Thanh toán";
            this.btnAddHoaDon.UseVisualStyleBackColor = false;
            this.btnAddHoaDon.Click += new System.EventHandler(this.btnAddHoaDon_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(91, 93);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.txtTotalAmount.Properties.DisplayFormat.FormatString = "#,###";
            this.txtTotalAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalAmount.Properties.Mask.EditMask = "n0";
            this.txtTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmount.Properties.MaxLength = 12;
            this.txtTotalAmount.Properties.NullText = "0";
            this.txtTotalAmount.Properties.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalAmount.Size = new System.Drawing.Size(159, 20);
            this.txtTotalAmount.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "Thơi gian";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Trả khách";
            // 
            // lueKhachHang
            // 
            this.lueKhachHang.Location = new System.Drawing.Point(91, 40);
            this.lueKhachHang.Name = "lueKhachHang";
            this.lueKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKhachHang.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idkh", "Mã danh mục"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenkh", "Tên danh mục"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("sdt", "Số điện thoại")});
            this.lueKhachHang.Properties.NullText = "";
            this.lueKhachHang.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueKhachHang.Properties.ReadOnly = true;
            this.lueKhachHang.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueKhachHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueKhachHang.Size = new System.Drawing.Size(158, 20);
            this.lueKhachHang.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("print", "image://svgimages/print/print.svg");
            this.svgImageCollection1.Add("actions_forbid", "image://svgimages/icon builder/actions_forbid.svg");
            // 
            // uctHOADONTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.label9);
            this.Name = "uctHOADONTT";
            this.Size = new System.Drawing.Size(1284, 525);
            this.Load += new System.EventHandler(this.uctHOADONTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcWaitOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWaitOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtiddondat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnPay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcWaitOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWaitOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gciddondat;
        private DevExpress.XtraGrid.Columns.GridColumn gcngaydat;
        private DevExpress.XtraGrid.Columns.GridColumn gcban;
        private DevExpress.XtraGrid.Columns.GridColumn gcidkh;
        private PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gctenkh;
        private PanelControl panelControl6;
        private System.Windows.Forms.Button btnClearHoDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpngaydat;
        private System.Windows.Forms.Button btnAddHoaDon;
        private TextEdit txtTotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private LookUpEdit lueKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private TextEdit txtReturnPay;
        private System.Windows.Forms.Label label1;
        private TextEdit txtCustomerPay;
        private TextEdit txtiddondat;
        private PanelControl panelControl3;
        private PanelControl panelControl4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gcSelectItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gctenmon;
        private DevExpress.XtraGrid.Columns.GridColumn gcdongia;
        private DevExpress.XtraGrid.Columns.GridColumn gcsldat;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotalAmount;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}
