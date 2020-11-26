using DevExpress.XtraEditors;

namespace RestaurantManager
{
    partial class uctPNHAP
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gciddonmh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcngaydonmh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcncc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcD_DONMH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcsldukien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcdongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctotalamount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcD_DONMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH PHIẾU NHẬP";
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::RestaurantManager.Properties.Resources.update_5;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(147, 4);
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
            this.btnAdd.Size = new System.Drawing.Size(136, 28);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Tạo phiếu nhập";
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
            this.gciddonmh,
            this.gcngaydonmh,
            this.gcCreateBy,
            this.gcncc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gciddonmh
            // 
            this.gciddonmh.Caption = "Mã đơn mua";
            this.gciddonmh.FieldName = "iddonmh";
            this.gciddonmh.Name = "gciddonmh";
            this.gciddonmh.Visible = true;
            this.gciddonmh.VisibleIndex = 0;
            this.gciddonmh.Width = 88;
            // 
            // gcngaydonmh
            // 
            this.gcngaydonmh.Caption = "Ngày tạo";
            this.gcngaydonmh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gcngaydonmh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcngaydonmh.FieldName = "ngaydonmh";
            this.gcngaydonmh.Name = "gcngaydonmh";
            this.gcngaydonmh.Visible = true;
            this.gcngaydonmh.VisibleIndex = 2;
            this.gcngaydonmh.Width = 108;
            // 
            // gcCreateBy
            // 
            this.gcCreateBy.Caption = "Người tạo";
            this.gcCreateBy.FieldName = "CreateBy";
            this.gcCreateBy.Name = "gcCreateBy";
            this.gcCreateBy.Visible = true;
            this.gcCreateBy.VisibleIndex = 3;
            this.gcCreateBy.Width = 108;
            // 
            // gcncc
            // 
            this.gcncc.Caption = "Nhà cung cấp";
            this.gcncc.FieldName = "tenncc";
            this.gcncc.Name = "gcncc";
            this.gcncc.Visible = true;
            this.gcncc.VisibleIndex = 1;
            this.gcncc.Width = 220;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcD_DONMH);
            this.panelControl2.Location = new System.Drawing.Point(555, 67);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(726, 458);
            this.panelControl2.TabIndex = 22;
            // 
            // gcD_DONMH
            // 
            this.gcD_DONMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcD_DONMH.Location = new System.Drawing.Point(2, 2);
            this.gcD_DONMH.MainView = this.gridView2;
            this.gcD_DONMH.Name = "gcD_DONMH";
            this.gcD_DONMH.Size = new System.Drawing.Size(722, 454);
            this.gcD_DONMH.TabIndex = 1;
            this.gcD_DONMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhang,
            this.gctenhang,
            this.gcsldukien,
            this.gcdongia,
            this.gctotalamount});
            this.gridView2.GridControl = this.gcD_DONMH;
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
            this.gcidhang.Width = 73;
            // 
            // gctenhang
            // 
            this.gctenhang.Caption = "Tên hàng";
            this.gctenhang.FieldName = "tenhang";
            this.gctenhang.Name = "gctenhang";
            this.gctenhang.Visible = true;
            this.gctenhang.VisibleIndex = 1;
            this.gctenhang.Width = 157;
            // 
            // gcsldukien
            // 
            this.gcsldukien.Caption = "Số lượng";
            this.gcsldukien.FieldName = "slmh";
            this.gcsldukien.Name = "gcsldukien";
            this.gcsldukien.Visible = true;
            this.gcsldukien.VisibleIndex = 2;
            this.gcsldukien.Width = 86;
            // 
            // gcdongia
            // 
            this.gcdongia.Caption = "Đơn giá";
            this.gcdongia.FieldName = "dongiamh";
            this.gcdongia.Name = "gcdongia";
            this.gcdongia.Visible = true;
            this.gcdongia.VisibleIndex = 3;
            this.gcdongia.Width = 126;
            // 
            // gctotalamount
            // 
            this.gctotalamount.Caption = "Thành tiền";
            this.gctotalamount.FieldName = "totalamount";
            this.gctotalamount.Name = "gctotalamount";
            this.gctotalamount.Visible = true;
            this.gctotalamount.VisibleIndex = 4;
            this.gctotalamount.Width = 262;
            // 
            // uctPNHAP
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
            this.Name = "uctPNHAP";
            this.Size = new System.Drawing.Size(1284, 525);
            this.Load += new System.EventHandler(this.uctPNHAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcD_DONMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gciddonmh;
        private DevExpress.XtraGrid.Columns.GridColumn gcngaydonmh;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateBy;
        private PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcD_DONMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhang;
        private DevExpress.XtraGrid.Columns.GridColumn gctenhang;
        private DevExpress.XtraGrid.Columns.GridColumn gcsldukien;
        private DevExpress.XtraGrid.Columns.GridColumn gcdongia;
        private DevExpress.XtraGrid.Columns.GridColumn gcncc;
        private DevExpress.XtraGrid.Columns.GridColumn gctotalamount;
    }
}