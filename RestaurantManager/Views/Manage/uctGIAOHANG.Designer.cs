using DevExpress.XtraEditors;

namespace RestaurantManager
{
    partial class uctGIAOHANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctGIAOHANG));
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcGIAOHANG = new DevExpress.XtraGrid.GridControl();
            this.gvGIAOHANG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidpgiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gciddonmh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcidncc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcncc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcngaydonmh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcngaygiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguoigiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguoinhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguoilapphieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gccuahang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcdiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcD_GIAOHANG = new DevExpress.XtraGrid.GridControl();
            this.gvD_GIAOHANG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslgiaohang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslnhanhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnDeleteRow = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGIAOHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGIAOHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcD_GIAOHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvD_GIAOHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH PHIẾU GIAO HÀNG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(985, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "THÔNG TIN CHI TIẾT";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::RestaurantManager.Properties.Resources.update_5;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(140, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 28);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 28);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Tạo phiếu giao hàng";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcGIAOHANG);
            this.panelControl1.Location = new System.Drawing.Point(3, 67);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(892, 458);
            this.panelControl1.TabIndex = 20;
            // 
            // gcGIAOHANG
            // 
            this.gcGIAOHANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGIAOHANG.Location = new System.Drawing.Point(2, 2);
            this.gcGIAOHANG.MainView = this.gvGIAOHANG;
            this.gcGIAOHANG.Name = "gcGIAOHANG";
            this.gcGIAOHANG.Size = new System.Drawing.Size(888, 454);
            this.gcGIAOHANG.TabIndex = 0;
            this.gcGIAOHANG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGIAOHANG});
            this.gcGIAOHANG.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gvGIAOHANG
            // 
            this.gvGIAOHANG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidpgiao,
            this.gciddonmh,
            this.gcidncc,
            this.gcncc,
            this.gcngaydonmh,
            this.gcngaygiao,
            this.gcnguoigiao,
            this.gcnguoinhan,
            this.gcnguoilapphieu,
            this.gccuahang,
            this.gcdiachi,
            this.gcCreateBy});
            this.gvGIAOHANG.GridControl = this.gcGIAOHANG;
            this.gvGIAOHANG.Name = "gvGIAOHANG";
            this.gvGIAOHANG.OptionsBehavior.Editable = false;
            this.gvGIAOHANG.OptionsBehavior.ReadOnly = true;
            this.gvGIAOHANG.OptionsFind.AlwaysVisible = true;
            this.gvGIAOHANG.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.gvGIAOHANG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvGIAOHANG_MouseUp);
            this.gvGIAOHANG.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gcidpgiao
            // 
            this.gcidpgiao.Caption = "Mã phiếu";
            this.gcidpgiao.FieldName = "idpgiao";
            this.gcidpgiao.Name = "gcidpgiao";
            this.gcidpgiao.Visible = true;
            this.gcidpgiao.VisibleIndex = 0;
            this.gcidpgiao.Width = 58;
            // 
            // gciddonmh
            // 
            this.gciddonmh.Caption = "Mã đơn mua";
            this.gciddonmh.FieldName = "iddonmh";
            this.gciddonmh.Name = "gciddonmh";
            this.gciddonmh.Visible = true;
            this.gciddonmh.VisibleIndex = 1;
            this.gciddonmh.Width = 68;
            // 
            // gcidncc
            // 
            this.gcidncc.Caption = "Mã NCC";
            this.gcidncc.FieldName = "idncc";
            this.gcidncc.Name = "gcidncc";
            this.gcidncc.Visible = true;
            this.gcidncc.VisibleIndex = 2;
            this.gcidncc.Width = 49;
            // 
            // gcncc
            // 
            this.gcncc.Caption = "Nhà cung cấp";
            this.gcncc.FieldName = "tenncc";
            this.gcncc.Name = "gcncc";
            this.gcncc.Visible = true;
            this.gcncc.VisibleIndex = 3;
            this.gcncc.Width = 77;
            // 
            // gcngaydonmh
            // 
            this.gcngaydonmh.Caption = "Ngày tạo";
            this.gcngaydonmh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gcngaydonmh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcngaydonmh.FieldName = "ngaydonmh";
            this.gcngaydonmh.Name = "gcngaydonmh";
            this.gcngaydonmh.Visible = true;
            this.gcngaydonmh.VisibleIndex = 10;
            this.gcngaydonmh.Width = 50;
            // 
            // gcngaygiao
            // 
            this.gcngaygiao.Caption = "Ngày giao";
            this.gcngaygiao.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gcngaygiao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcngaygiao.FieldName = "ngaygiao";
            this.gcngaygiao.Name = "gcngaygiao";
            this.gcngaygiao.Visible = true;
            this.gcngaygiao.VisibleIndex = 4;
            this.gcngaygiao.Width = 64;
            // 
            // gcnguoigiao
            // 
            this.gcnguoigiao.Caption = "Người giao";
            this.gcnguoigiao.FieldName = "nguoigiao";
            this.gcnguoigiao.Name = "gcnguoigiao";
            this.gcnguoigiao.Visible = true;
            this.gcnguoigiao.VisibleIndex = 7;
            this.gcnguoigiao.Width = 83;
            // 
            // gcnguoinhan
            // 
            this.gcnguoinhan.Caption = "Người nhận";
            this.gcnguoinhan.FieldName = "nguoinhan";
            this.gcnguoinhan.Name = "gcnguoinhan";
            this.gcnguoinhan.Visible = true;
            this.gcnguoinhan.VisibleIndex = 5;
            this.gcnguoinhan.Width = 79;
            // 
            // gcnguoilapphieu
            // 
            this.gcnguoilapphieu.Caption = "Người lập phiếu";
            this.gcnguoilapphieu.FieldName = "nguoilapphieu";
            this.gcnguoilapphieu.Name = "gcnguoilapphieu";
            this.gcnguoilapphieu.Visible = true;
            this.gcnguoilapphieu.VisibleIndex = 6;
            this.gcnguoilapphieu.Width = 83;
            // 
            // gccuahang
            // 
            this.gccuahang.Caption = "Cửa hàng";
            this.gccuahang.FieldName = "cuahang";
            this.gccuahang.Name = "gccuahang";
            this.gccuahang.Visible = true;
            this.gccuahang.VisibleIndex = 8;
            this.gccuahang.Width = 87;
            // 
            // gcdiachi
            // 
            this.gcdiachi.Caption = "Địa chỉ";
            this.gcdiachi.FieldName = "diachi";
            this.gcdiachi.Name = "gcdiachi";
            this.gcdiachi.Visible = true;
            this.gcdiachi.VisibleIndex = 9;
            this.gcdiachi.Width = 101;
            // 
            // gcCreateBy
            // 
            this.gcCreateBy.Caption = "Người tạo";
            this.gcCreateBy.FieldName = "CreateBy";
            this.gcCreateBy.Name = "gcCreateBy";
            this.gcCreateBy.Width = 108;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.gcD_GIAOHANG);
            this.panelControl2.Location = new System.Drawing.Point(899, 67);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(382, 458);
            this.panelControl2.TabIndex = 22;
            // 
            // gcD_GIAOHANG
            // 
            this.gcD_GIAOHANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcD_GIAOHANG.Location = new System.Drawing.Point(2, 2);
            this.gcD_GIAOHANG.MainView = this.gvD_GIAOHANG;
            this.gcD_GIAOHANG.Name = "gcD_GIAOHANG";
            this.gcD_GIAOHANG.Size = new System.Drawing.Size(378, 454);
            this.gcD_GIAOHANG.TabIndex = 1;
            this.gcD_GIAOHANG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvD_GIAOHANG});
            // 
            // gvD_GIAOHANG
            // 
            this.gvD_GIAOHANG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhang,
            this.gctenhang,
            this.gcslgiaohang,
            this.gcslnhanhang});
            this.gvD_GIAOHANG.GridControl = this.gcD_GIAOHANG;
            this.gvD_GIAOHANG.Name = "gvD_GIAOHANG";
            this.gvD_GIAOHANG.OptionsBehavior.Editable = false;
            this.gvD_GIAOHANG.OptionsBehavior.ReadOnly = true;
            this.gvD_GIAOHANG.OptionsFind.AlwaysVisible = true;
            // 
            // gcidhang
            // 
            this.gcidhang.Caption = "Mã hàng";
            this.gcidhang.FieldName = "idhang";
            this.gcidhang.Name = "gcidhang";
            this.gcidhang.Visible = true;
            this.gcidhang.VisibleIndex = 0;
            this.gcidhang.Width = 51;
            // 
            // gctenhang
            // 
            this.gctenhang.Caption = "Tên hàng";
            this.gctenhang.FieldName = "tenhang";
            this.gctenhang.Name = "gctenhang";
            this.gctenhang.Visible = true;
            this.gctenhang.VisibleIndex = 1;
            this.gctenhang.Width = 160;
            // 
            // gcslgiaohang
            // 
            this.gcslgiaohang.Caption = "Số lượng giao";
            this.gcslgiaohang.FieldName = "slgiaohang";
            this.gcslgiaohang.Name = "gcslgiaohang";
            this.gcslgiaohang.Visible = true;
            this.gcslgiaohang.VisibleIndex = 2;
            this.gcslgiaohang.Width = 73;
            // 
            // gcslnhanhang
            // 
            this.gcslnhanhang.Caption = "Số lượng nhận";
            this.gcslnhanhang.FieldName = "slnhanhang";
            this.gcslnhanhang.Name = "gcslnhanhang";
            this.gcslnhanhang.Visible = true;
            this.gcslnhanhang.VisibleIndex = 3;
            this.gcslnhanhang.Width = 76;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Caption = "Xóa";
            this.btnDeleteRow.Id = 0;
            this.btnDeleteRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.ImageOptions.Image")));
            this.btnDeleteRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.ImageOptions.LargeImage")));
            this.btnDeleteRow.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDeleteRow.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteRow_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In phiếu";
            this.btnPrint.Id = 2;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.LargeImage")));
            this.btnPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPrint.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F);
            this.btnPrint.ItemInMenuAppearance.Normal.Options.UseFont = true;
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
            this.btnDeleteRow,
            this.btnPrint});
            this.barManager1.MaxItemId = 3;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 525);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1284, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 525);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1284, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 525);
            // 
            // uctGIAOHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uctGIAOHANG";
            this.Size = new System.Drawing.Size(1284, 525);
            this.Load += new System.EventHandler(this.uctGIAOHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGIAOHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGIAOHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcD_GIAOHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvD_GIAOHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcGIAOHANG;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGIAOHANG;
        private DevExpress.XtraGrid.Columns.GridColumn gciddonmh;
        private DevExpress.XtraGrid.Columns.GridColumn gcngaydonmh;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateBy;
        private PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcD_GIAOHANG;
        private DevExpress.XtraGrid.Views.Grid.GridView gvD_GIAOHANG;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhang;
        private DevExpress.XtraGrid.Columns.GridColumn gctenhang;
        private DevExpress.XtraGrid.Columns.GridColumn gcslgiaohang;
        private DevExpress.XtraGrid.Columns.GridColumn gcncc;
        private DevExpress.XtraGrid.Columns.GridColumn gcidpgiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcidncc;
        private DevExpress.XtraGrid.Columns.GridColumn gcngaygiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguoigiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguoinhan;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguoilapphieu;
        private DevExpress.XtraGrid.Columns.GridColumn gccuahang;
        private DevExpress.XtraGrid.Columns.GridColumn gcdiachi;
        private DevExpress.XtraGrid.Columns.GridColumn gcslnhanhang;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnDeleteRow;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
    }
}