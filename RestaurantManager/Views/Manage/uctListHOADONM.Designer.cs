using DevExpress.XtraEditors;

namespace RestaurantManager
{
    partial class uctListHOADONM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctListHOADONM));
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcHOADONM = new DevExpress.XtraGrid.GridControl();
            this.gvHOADONM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidpnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcidhoadonm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcngaymua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcidpgiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gciddonmh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHOADONM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHOADONM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH HÓA ĐƠN MUA";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gcHOADONM);
            this.panelControl1.Location = new System.Drawing.Point(0, 83);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1284, 479);
            this.panelControl1.TabIndex = 20;
            // 
            // gcHOADONM
            // 
            this.gcHOADONM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHOADONM.Location = new System.Drawing.Point(2, 2);
            this.gcHOADONM.MainView = this.gvHOADONM;
            this.gcHOADONM.Name = "gcHOADONM";
            this.gcHOADONM.Size = new System.Drawing.Size(1280, 475);
            this.gcHOADONM.TabIndex = 0;
            this.gcHOADONM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHOADONM});
            this.gcHOADONM.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gvHOADONM
            // 
            this.gvHOADONM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhoadonm,
            this.gcngaymua,
            this.gcidpnhap,
            this.gcidpgiao,
            this.gciddonmh,
            this.gcTotalAmount});
            this.gvHOADONM.DetailHeight = 377;
            this.gvHOADONM.GridControl = this.gcHOADONM;
            this.gvHOADONM.Name = "gvHOADONM";
            this.gvHOADONM.OptionsBehavior.Editable = false;
            this.gvHOADONM.OptionsBehavior.ReadOnly = true;
            this.gvHOADONM.OptionsFind.AlwaysVisible = true;
            this.gvHOADONM.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gvHOADONM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvHOADONTT_MouseUp);
            this.gvHOADONM.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gcidpnhap
            // 
            this.gcidpnhap.Caption = "Mã phiếu nhập";
            this.gcidpnhap.FieldName = "idpnhap";
            this.gcidpnhap.Name = "gcidpnhap";
            this.gcidpnhap.Visible = true;
            this.gcidpnhap.VisibleIndex = 0;
            this.gcidpnhap.Width = 153;
            // 
            // gcidhoadonm
            // 
            this.gcidhoadonm.Caption = "Mã hóa đơn";
            this.gcidhoadonm.FieldName = "idhoadonm";
            this.gcidhoadonm.Name = "gcidhoadonm";
            this.gcidhoadonm.Visible = true;
            this.gcidhoadonm.VisibleIndex = 2;
            this.gcidhoadonm.Width = 188;
            // 
            // gcngaymua
            // 
            this.gcngaymua.Caption = "Ngày mua";
            this.gcngaymua.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gcngaymua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcngaymua.FieldName = "ngaymua";
            this.gcngaymua.Name = "gcngaymua";
            this.gcngaymua.Visible = true;
            this.gcngaymua.VisibleIndex = 1;
            this.gcngaymua.Width = 180;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(64, 58);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(102, 20);
            this.dtpFromDate.TabIndex = 21;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(244, 58);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(102, 20);
            this.dtpToDate.TabIndex = 22;
            this.dtpToDate.Value = new System.DateTime(2020, 11, 22, 23, 28, 56, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Đến ngày";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::RestaurantManager.Properties.Resources.Search_icon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(352, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 22);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(449, 58);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 22);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Bỏ tìm";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In hóa đơn";
            this.btnPrint.Id = 0;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.LargeImage")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnPrint});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1284, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 565);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1284, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 565);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1284, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 565);
            // 
            // gcidpgiao
            // 
            this.gcidpgiao.Caption = "Mã phiếu giao";
            this.gcidpgiao.FieldName = "idpgiao";
            this.gcidpgiao.Name = "gcidpgiao";
            this.gcidpgiao.Visible = true;
            this.gcidpgiao.VisibleIndex = 3;
            this.gcidpgiao.Width = 202;
            // 
            // gciddonmh
            // 
            this.gciddonmh.Caption = "Mã đơn mua";
            this.gciddonmh.FieldName = "iddonmh";
            this.gciddonmh.Name = "gciddonmh";
            this.gciddonmh.Visible = true;
            this.gciddonmh.VisibleIndex = 4;
            this.gciddonmh.Width = 215;
            // 
            // gcTotalAmount
            // 
            this.gcTotalAmount.Caption = "Tổng tiền";
            this.gcTotalAmount.DisplayFormat.FormatString = "#,###";
            this.gcTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcTotalAmount.FieldName = "TotalAmount";
            this.gcTotalAmount.Name = "gcTotalAmount";
            this.gcTotalAmount.Visible = true;
            this.gcTotalAmount.VisibleIndex = 5;
            this.gcTotalAmount.Width = 324;
            // 
            // uctListHOADONM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uctListHOADONM";
            this.Size = new System.Drawing.Size(1284, 565);
            this.Load += new System.EventHandler(this.uctListHOADONM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHOADONM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHOADONM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcHOADONM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHOADONM;
        private DevExpress.XtraGrid.Columns.GridColumn gcidpnhap;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhoadonm;
        private DevExpress.XtraGrid.Columns.GridColumn gcngaymua;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gcidpgiao;
        private DevExpress.XtraGrid.Columns.GridColumn gciddonmh;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotalAmount;
    }
}
