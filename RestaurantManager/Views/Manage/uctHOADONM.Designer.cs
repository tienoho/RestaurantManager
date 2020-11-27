using DevExpress.XtraEditors;

namespace RestaurantManager
{
    partial class uctHOADONM
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
            this.label9 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcPNHAP = new DevExpress.XtraGrid.GridControl();
            this.gvPNHAP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidpnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguoigiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguoilapphieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctennguoilapphieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcngaynhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcthukho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenthukho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcidpgiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txtidpnhap = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcSelectItems = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gctenmon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslgiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearHoDon = new System.Windows.Forms.Button();
            this.dtpngaydat = new System.Windows.Forms.DateTimePicker();
            this.btnAddHoaDon = new System.Windows.Forms.Button();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gcslnhan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPNHAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPNHAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidpnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcPNHAP);
            this.panelControl1.Location = new System.Drawing.Point(3, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(602, 445);
            this.panelControl1.TabIndex = 20;
            // 
            // gcPNHAP
            // 
            this.gcPNHAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPNHAP.Location = new System.Drawing.Point(2, 2);
            this.gcPNHAP.MainView = this.gvPNHAP;
            this.gcPNHAP.Name = "gcPNHAP";
            this.gcPNHAP.Size = new System.Drawing.Size(598, 441);
            this.gcPNHAP.TabIndex = 0;
            this.gcPNHAP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPNHAP});
            this.gcPNHAP.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gvPNHAP
            // 
            this.gvPNHAP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidpnhap,
            this.gcnguoigiao,
            this.gcnguoilapphieu,
            this.gctennguoilapphieu,
            this.gcngaynhap,
            this.gcthukho,
            this.gctenthukho,
            this.gcidpgiao});
            this.gvPNHAP.GridControl = this.gcPNHAP;
            this.gvPNHAP.Name = "gvPNHAP";
            this.gvPNHAP.OptionsBehavior.Editable = false;
            this.gvPNHAP.OptionsBehavior.ReadOnly = true;
            this.gvPNHAP.OptionsFind.AlwaysVisible = true;
            this.gvPNHAP.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gvPNHAP.Click += new System.EventHandler(this.gvWaitOrder_Click);
            this.gvPNHAP.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gcidpnhap
            // 
            this.gcidpnhap.Caption = "Mã phiếu nhập";
            this.gcidpnhap.FieldName = "idpnhap";
            this.gcidpnhap.Name = "gcidpnhap";
            this.gcidpnhap.Visible = true;
            this.gcidpnhap.VisibleIndex = 0;
            this.gcidpnhap.Width = 38;
            // 
            // gcnguoigiao
            // 
            this.gcnguoigiao.Caption = "Người giao";
            this.gcnguoigiao.FieldName = "nguoigiao";
            this.gcnguoigiao.Name = "gcnguoigiao";
            this.gcnguoigiao.Visible = true;
            this.gcnguoigiao.VisibleIndex = 1;
            this.gcnguoigiao.Width = 76;
            // 
            // gcnguoilapphieu
            // 
            this.gcnguoilapphieu.Caption = "Người lập phiếu";
            this.gcnguoilapphieu.FieldName = "nguoilapphieu";
            this.gcnguoilapphieu.Name = "gcnguoilapphieu";
            this.gcnguoilapphieu.Width = 98;
            // 
            // gctennguoilapphieu
            // 
            this.gctennguoilapphieu.Caption = "Người lập";
            this.gctennguoilapphieu.FieldName = "tennguoilapphieu";
            this.gctennguoilapphieu.Name = "gctennguoilapphieu";
            this.gctennguoilapphieu.Visible = true;
            this.gctennguoilapphieu.VisibleIndex = 4;
            // 
            // gcngaynhap
            // 
            this.gcngaynhap.Caption = "Ngày nhập";
            this.gcngaynhap.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gcngaynhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcngaynhap.FieldName = "ngaynhap";
            this.gcngaynhap.Name = "gcngaynhap";
            this.gcngaynhap.Visible = true;
            this.gcngaynhap.VisibleIndex = 2;
            this.gcngaynhap.Width = 76;
            // 
            // gcthukho
            // 
            this.gcthukho.Caption = "thukho";
            this.gcthukho.FieldName = "thukho";
            this.gcthukho.Name = "gcthukho";
            this.gcthukho.Width = 76;
            // 
            // gctenthukho
            // 
            this.gctenthukho.Caption = "Thủ kho";
            this.gctenthukho.FieldName = "tenthukho";
            this.gctenthukho.Name = "gctenthukho";
            this.gctenthukho.Visible = true;
            this.gctenthukho.VisibleIndex = 5;
            // 
            // gcidpgiao
            // 
            this.gcidpgiao.Caption = "Mã phiếu giao";
            this.gcidpgiao.FieldName = "idpgiao";
            this.gcidpgiao.Name = "gcidpgiao";
            this.gcidpgiao.Visible = true;
            this.gcidpgiao.VisibleIndex = 3;
            this.gcidpgiao.Width = 83;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panelControl6);
            this.panelControl2.Location = new System.Drawing.Point(609, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(675, 443);
            this.panelControl2.TabIndex = 22;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.txtidpnhap);
            this.panelControl4.Controls.Add(this.label4);
            this.panelControl4.Controls.Add(this.label3);
            this.panelControl4.Location = new System.Drawing.Point(0, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(410, 57);
            this.panelControl4.TabIndex = 22;
            // 
            // txtidpnhap
            // 
            this.txtidpnhap.EditValue = "";
            this.txtidpnhap.Location = new System.Drawing.Point(109, 6);
            this.txtidpnhap.Name = "txtidpnhap";
            this.txtidpnhap.Properties.MaxLength = 60;
            this.txtidpnhap.Properties.NullText = "0";
            this.txtidpnhap.Properties.ReadOnly = true;
            this.txtidpnhap.Size = new System.Drawing.Size(74, 20);
            this.txtidpnhap.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mã phiếu nhập";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcSelectItems);
            this.panelControl3.Location = new System.Drawing.Point(0, 60);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(410, 378);
            this.panelControl3.TabIndex = 21;
            // 
            // gcSelectItems
            // 
            this.gcSelectItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSelectItems.Location = new System.Drawing.Point(2, 2);
            this.gcSelectItems.MainView = this.gridView1;
            this.gcSelectItems.Name = "gcSelectItems";
            this.gcSelectItems.Size = new System.Drawing.Size(406, 374);
            this.gcSelectItems.TabIndex = 5;
            this.gcSelectItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gctenmon,
            this.gcslgiao,
            this.gcslnhan});
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
            // gcslgiao
            // 
            this.gcslgiao.Caption = "Số lượng giao";
            this.gcslgiao.DisplayFormat.FormatString = "#,###";
            this.gcslgiao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcslgiao.FieldName = "slgiao";
            this.gcslgiao.Name = "gcslgiao";
            this.gcslgiao.Visible = true;
            this.gcslgiao.VisibleIndex = 1;
            // 
            // panelControl6
            // 
            this.panelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl6.Controls.Add(this.label1);
            this.panelControl6.Controls.Add(this.btnClearHoDon);
            this.panelControl6.Controls.Add(this.dtpngaydat);
            this.panelControl6.Controls.Add(this.btnAddHoaDon);
            this.panelControl6.Controls.Add(this.txtTotalAmount);
            this.panelControl6.Controls.Add(this.label10);
            this.panelControl6.Controls.Add(this.label6);
            this.panelControl6.Location = new System.Drawing.Point(414, 2);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(258, 436);
            this.panelControl6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tổng tiền";
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
            this.btnClearHoDon.Location = new System.Drawing.Point(92, 153);
            this.btnClearHoDon.Name = "btnClearHoDon";
            this.btnClearHoDon.Size = new System.Drawing.Size(158, 28);
            this.btnClearHoDon.TabIndex = 52;
            this.btnClearHoDon.Text = "Làm mới";
            this.btnClearHoDon.UseVisualStyleBackColor = false;
            this.btnClearHoDon.Click += new System.EventHandler(this.btnClearHoDon_Click);
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
            this.btnAddHoaDon.Location = new System.Drawing.Point(91, 119);
            this.btnAddHoaDon.Name = "btnAddHoaDon";
            this.btnAddHoaDon.Size = new System.Drawing.Size(158, 28);
            this.btnAddHoaDon.TabIndex = 48;
            this.btnAddHoaDon.Text = "Lưu hóa đơn";
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
            this.label10.Location = new System.Drawing.Point(8, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "Thơi gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // gcslnhan
            // 
            this.gcslnhan.Caption = "Số lượng nhận";
            this.gcslnhan.FieldName = "slnhan";
            this.gcslnhan.Name = "gcslnhan";
            this.gcslnhan.Visible = true;
            this.gcslnhan.VisibleIndex = 2;
            // 
            // uctHOADONM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.label9);
            this.Name = "uctHOADONM";
            this.Size = new System.Drawing.Size(1284, 525);
            this.Load += new System.EventHandler(this.uctHOADONM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPNHAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPNHAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtidpnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcPNHAP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn gcidpnhap;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguoilapphieu;
        private PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguoigiao;
        private PanelControl panelControl6;
        private System.Windows.Forms.Button btnClearHoDon;
        private System.Windows.Forms.DateTimePicker dtpngaydat;
        private System.Windows.Forms.Button btnAddHoaDon;
        private TextEdit txtTotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private TextEdit txtidpnhap;
        private PanelControl panelControl3;
        private PanelControl panelControl4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gcSelectItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gctenmon;
        private DevExpress.XtraGrid.Columns.GridColumn gcslgiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcngaynhap;
        private DevExpress.XtraGrid.Columns.GridColumn gcthukho;
        private DevExpress.XtraGrid.Columns.GridColumn gcidpgiao;
        private DevExpress.XtraGrid.Columns.GridColumn gctennguoilapphieu;
        private DevExpress.XtraGrid.Columns.GridColumn gctenthukho;
        private DevExpress.XtraGrid.Columns.GridColumn gcslnhan;
    }
}
