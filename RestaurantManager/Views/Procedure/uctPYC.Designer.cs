using DevExpress.XtraEditors;

namespace RestaurantManager
{
    partial class uctPYC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctPYC));
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidyc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcngayyc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcD_PYC = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcsldukien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbtPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDeleteRow = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcD_PYC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH PHIẾU YÊU CẦU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(766, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "THÔNG TIN CHI TIẾT";
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
            this.btnAdd.Size = new System.Drawing.Size(119, 28);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Tạo yêu cầu";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 67);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(546, 458);
            this.panelControl1.TabIndex = 20;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(542, 454);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidyc,
            this.gcngayyc,
            this.gcCreateBy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseUp);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gcidyc
            // 
            this.gcidyc.Caption = "Mã yêu cầu";
            this.gcidyc.FieldName = "idyc";
            this.gcidyc.Name = "gcidyc";
            this.gcidyc.Visible = true;
            this.gcidyc.VisibleIndex = 0;
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
            this.gcngayyc.Width = 223;
            // 
            // gcCreateBy
            // 
            this.gcCreateBy.Caption = "Người tạo yêu cầu";
            this.gcCreateBy.FieldName = "CreateBy";
            this.gcCreateBy.Name = "gcCreateBy";
            this.gcCreateBy.Visible = true;
            this.gcCreateBy.VisibleIndex = 2;
            this.gcCreateBy.Width = 226;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.gcD_PYC);
            this.panelControl2.Location = new System.Drawing.Point(555, 67);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(726, 458);
            this.panelControl2.TabIndex = 22;
            // 
            // gcD_PYC
            // 
            this.gcD_PYC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcD_PYC.Location = new System.Drawing.Point(2, 2);
            this.gcD_PYC.MainView = this.gridView2;
            this.gcD_PYC.Name = "gcD_PYC";
            this.gcD_PYC.Size = new System.Drawing.Size(722, 454);
            this.gcD_PYC.TabIndex = 1;
            this.gcD_PYC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhang,
            this.gctenhang,
            this.gcsldukien,
            this.gcslton,
            this.gcnguong});
            this.gridView2.GridControl = this.gcD_PYC;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
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
            // gcsldukien
            // 
            this.gcsldukien.Caption = "Số lượng dự kiến";
            this.gcsldukien.DisplayFormat.FormatString = "#,###";
            this.gcsldukien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcsldukien.FieldName = "sldukien";
            this.gcsldukien.Name = "gcsldukien";
            this.gcsldukien.Visible = true;
            this.gcsldukien.VisibleIndex = 2;
            // 
            // gcslton
            // 
            this.gcslton.Caption = "Số lượng tồn";
            this.gcslton.DisplayFormat.FormatString = "#,###";
            this.gcslton.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcslton.FieldName = "slton";
            this.gcslton.Name = "gcslton";
            this.gcslton.Visible = true;
            this.gcslton.VisibleIndex = 3;
            // 
            // gcnguong
            // 
            this.gcnguong.Caption = "Ngưỡng";
            this.gcnguong.DisplayFormat.FormatString = "#,###";
            this.gcnguong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcnguong.FieldName = "nguong";
            this.gcnguong.Name = "gcnguong";
            this.gcnguong.Visible = true;
            this.gcnguong.VisibleIndex = 4;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnEdit)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bbtPrint
            // 
            this.bbtPrint.Caption = "In phiếu";
            this.bbtPrint.Id = 2;
            this.bbtPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtPrint.ImageOptions.Image")));
            this.bbtPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtPrint.ImageOptions.LargeImage")));
            this.bbtPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.bbtPrint.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F);
            this.bbtPrint.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bbtPrint.Name = "bbtPrint";
            this.bbtPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtPrint_ItemClick);
            // 
            // bbtnEdit
            // 
            this.bbtnEdit.Caption = "Sửa";
            this.bbtnEdit.Id = 3;
            this.bbtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnEdit.ImageOptions.Image")));
            this.bbtnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnEdit.ImageOptions.LargeImage")));
            this.bbtnEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Arial", 8.25F);
            this.bbtnEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbtnEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.bbtnEdit.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Arial", 8.25F);
            this.bbtnEdit.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.bbtnEdit.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Arial", 9.25F);
            this.bbtnEdit.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bbtnEdit.Name = "bbtnEdit";
            this.bbtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnEdit_ItemClick);
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
            this.bbtPrint,
            this.bbtnEdit});
            this.barManager1.MaxItemId = 4;
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
            // btnDeleteRow
            // 
            this.btnDeleteRow.Caption = "Xóa";
            this.btnDeleteRow.Id = 0;
            this.btnDeleteRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.ImageOptions.Image")));
            this.btnDeleteRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.ImageOptions.LargeImage")));
            this.btnDeleteRow.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDeleteRow.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnDeleteRow.Name = "btnDeleteRow";
            // 
            // uctPYC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uctPYC";
            this.Size = new System.Drawing.Size(1284, 525);
            this.Load += new System.EventHandler(this.uctPYC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcD_PYC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcidyc;
        private DevExpress.XtraGrid.Columns.GridColumn gcngayyc;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateBy;
        private PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcD_PYC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhang;
        private DevExpress.XtraGrid.Columns.GridColumn gctenhang;
        private DevExpress.XtraGrid.Columns.GridColumn gcsldukien;
        private DevExpress.XtraGrid.Columns.GridColumn gcslton;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguong;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbtPrint;
        private DevExpress.XtraBars.BarButtonItem bbtnEdit;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDeleteRow;
    }
}
