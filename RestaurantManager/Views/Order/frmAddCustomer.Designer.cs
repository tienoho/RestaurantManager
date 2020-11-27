namespace RestaurantManager.Views.Order
{
    partial class frmAddCustomer
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
            this.btnSave = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenkh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbAgency = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtidkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIDAgency = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grbAgency.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::RestaurantManager.Properties.Resources.icons8_save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(152, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 28);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(6, 217);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(436, 268);
            this.panelControl1.TabIndex = 29;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(432, 264);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidkh,
            this.gctenkh,
            this.gcsdt,
            this.gcCreateBy,
            this.gcCreateDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gcidkh
            // 
            this.gcidkh.Caption = "Mã khách hàng";
            this.gcidkh.FieldName = "idkh";
            this.gcidkh.Name = "gcidkh";
            this.gcidkh.Visible = true;
            this.gcidkh.VisibleIndex = 0;
            this.gcidkh.Width = 35;
            // 
            // gctenkh
            // 
            this.gctenkh.Caption = "Tên khách hàng";
            this.gctenkh.FieldName = "tenkh";
            this.gctenkh.Name = "gctenkh";
            this.gctenkh.Visible = true;
            this.gctenkh.VisibleIndex = 1;
            // 
            // gcsdt
            // 
            this.gcsdt.Caption = "Số điện thoại";
            this.gcsdt.FieldName = "sdt";
            this.gcsdt.Name = "gcsdt";
            this.gcsdt.Visible = true;
            this.gcsdt.VisibleIndex = 2;
            // 
            // gcCreateBy
            // 
            this.gcCreateBy.Caption = "Người tạo";
            this.gcCreateBy.FieldName = "CreateBy";
            this.gcCreateBy.Name = "gcCreateBy";
            this.gcCreateBy.Visible = true;
            this.gcCreateBy.VisibleIndex = 3;
            // 
            // gcCreateDate
            // 
            this.gcCreateDate.Caption = "Ngày tạo";
            this.gcCreateDate.FieldName = "CreateDate";
            this.gcCreateDate.Name = "gcCreateDate";
            this.gcCreateDate.Visible = true;
            this.gcCreateDate.VisibleIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(-135, 451);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 28);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Làm mới";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::RestaurantManager.Properties.Resources.delete_3;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(247, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 28);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::RestaurantManager.Properties.Resources.update_5;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(247, 83);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 28);
            this.btnUpdate.TabIndex = 26;
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
            this.btnAdd.Location = new System.Drawing.Point(152, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 28);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbAgency
            // 
            this.grbAgency.Controls.Add(this.panel2);
            this.grbAgency.Location = new System.Drawing.Point(3, 26);
            this.grbAgency.Name = "grbAgency";
            this.grbAgency.Size = new System.Drawing.Size(442, 167);
            this.grbAgency.TabIndex = 24;
            this.grbAgency.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnClearDetails);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtsdt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txttenkh);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtidkh);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbIDAgency);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 148);
            this.panel2.TabIndex = 2;
            // 
            // txtsdt
            // 
            this.txtsdt.Enabled = false;
            this.txtsdt.Location = new System.Drawing.Point(152, 56);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(245, 21);
            this.txtsdt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số điện thoại";
            // 
            // txttenkh
            // 
            this.txttenkh.Enabled = false;
            this.txttenkh.Location = new System.Drawing.Point(152, 31);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(245, 21);
            this.txttenkh.TabIndex = 2;
            // 
            // txtidkh
            // 
            this.txtidkh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtidkh.Enabled = false;
            this.txtidkh.Location = new System.Drawing.Point(152, 6);
            this.txtidkh.Name = "txtidkh";
            this.txtidkh.ReadOnly = true;
            this.txtidkh.Size = new System.Drawing.Size(245, 21);
            this.txtidkh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // lbIDAgency
            // 
            this.lbIDAgency.AutoSize = true;
            this.lbIDAgency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDAgency.Location = new System.Drawing.Point(22, 6);
            this.lbIDAgency.Name = "lbIDAgency";
            this.lbIDAgency.Size = new System.Drawing.Size(105, 16);
            this.lbIDAgency.TabIndex = 0;
            this.lbIDAgency.Text = "Mã khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "THÊM NHANH KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "DANH SÁCH KHACH HÀNG";
            // 
            // btnClearDetails
            // 
            this.btnClearDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDetails.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClearDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDetails.Location = new System.Drawing.Point(323, 115);
            this.btnClearDetails.Name = "btnClearDetails";
            this.btnClearDetails.Size = new System.Drawing.Size(88, 28);
            this.btnClearDetails.TabIndex = 31;
            this.btnClearDetails.Text = "Làm mới";
            this.btnClearDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearDetails.UseVisualStyleBackColor = true;
            this.btnClearDetails.Visible = false;
            this.btnClearDetails.Click += new System.EventHandler(this.btnClearDetails_Click_1);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 487);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbAgency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhanh khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddCustomer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grbAgency.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcidkh;
        private DevExpress.XtraGrid.Columns.GridColumn gctenkh;
        private DevExpress.XtraGrid.Columns.GridColumn gcsdt;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateBy;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbAgency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtidkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIDAgency;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearDetails;
    }
}