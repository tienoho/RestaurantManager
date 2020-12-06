using DevExpress.XtraEditors;

namespace RestaurantManager
{
    partial class uctNLIEU
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
            this.txtSLT = new DevExpress.XtraEditors.TextEdit();
            this.txtNguong = new DevExpress.XtraEditors.TextEdit();
            this.nudDonGia2 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIDAgency = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcdongianl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbAgency.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "THÔNG TIN NGUYÊN LIỆU";
            // 
            // grbAgency
            // 
            this.grbAgency.Controls.Add(this.panel2);
            this.grbAgency.Location = new System.Drawing.Point(3, 40);
            this.grbAgency.Name = "grbAgency";
            this.grbAgency.Size = new System.Drawing.Size(439, 312);
            this.grbAgency.TabIndex = 14;
            this.grbAgency.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtSLT);
            this.panel2.Controls.Add(this.txtNguong);
            this.panel2.Controls.Add(this.nudDonGia2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txttenhang);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbIDAgency);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 293);
            this.panel2.TabIndex = 2;
            // 
            // txtSLT
            // 
            this.txtSLT.Enabled = false;
            this.txtSLT.Location = new System.Drawing.Point(150, 104);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSLT.Properties.Appearance.Options.UseFont = true;
            this.txtSLT.Properties.DisplayFormat.FormatString = "#,###";
            this.txtSLT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSLT.Properties.Mask.EditMask = "n0";
            this.txtSLT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSLT.Properties.MaxLength = 9;
            this.txtSLT.Properties.NullText = "0";
            this.txtSLT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSLT.Size = new System.Drawing.Size(146, 20);
            this.txtSLT.TabIndex = 29;
            // 
            // txtNguong
            // 
            this.txtNguong.Enabled = false;
            this.txtNguong.Location = new System.Drawing.Point(150, 142);
            this.txtNguong.Name = "txtNguong";
            this.txtNguong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNguong.Properties.Appearance.Options.UseFont = true;
            this.txtNguong.Properties.DisplayFormat.FormatString = "#,###";
            this.txtNguong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtNguong.Properties.EditFormat.FormatString = "n0";
            this.txtNguong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtNguong.Properties.Mask.EditMask = "n0";
            this.txtNguong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNguong.Properties.MaxLength = 9;
            this.txtNguong.Properties.NullText = "0";
            this.txtNguong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNguong.Size = new System.Drawing.Size(146, 20);
            this.txtNguong.TabIndex = 28;
            // 
            // nudDonGia2
            // 
            this.nudDonGia2.Enabled = false;
            this.nudDonGia2.Location = new System.Drawing.Point(150, 178);
            this.nudDonGia2.Name = "nudDonGia2";
            this.nudDonGia2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nudDonGia2.Properties.Appearance.Options.UseFont = true;
            this.nudDonGia2.Properties.DisplayFormat.FormatString = "#,###";
            this.nudDonGia2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.nudDonGia2.Properties.Mask.EditMask = "n0";
            this.nudDonGia2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.nudDonGia2.Properties.MaxLength = 12;
            this.nudDonGia2.Properties.NullText = "0";
            this.nudDonGia2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudDonGia2.Size = new System.Drawing.Size(146, 20);
            this.nudDonGia2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngưỡng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng tồn";
            // 
            // txttenhang
            // 
            this.txttenhang.Enabled = false;
            this.txttenhang.Location = new System.Drawing.Point(152, 65);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(146, 21);
            this.txttenhang.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(152, 26);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(144, 21);
            this.txtid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hàng";
            // 
            // lbIDAgency
            // 
            this.lbIDAgency.AutoSize = true;
            this.lbIDAgency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDAgency.Location = new System.Drawing.Point(22, 26);
            this.lbIDAgency.Name = "lbIDAgency";
            this.lbIDAgency.Size = new System.Drawing.Size(63, 16);
            this.lbIDAgency.TabIndex = 0;
            this.lbIDAgency.Text = "Mã hàng";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(6, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 28);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Làm mới";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::RestaurantManager.Properties.Resources.delete_3;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(273, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 28);
            this.btnDelete.TabIndex = 16;
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
            this.btnUpdate.Location = new System.Drawing.Point(197, 363);
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
            this.btnAdd.Location = new System.Drawing.Point(99, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 28);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(451, 44);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(833, 312);
            this.panelControl1.TabIndex = 20;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(829, 308);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhang,
            this.gctenhang,
            this.gcslton,
            this.gcnguong,
            this.gcdongianl,
            this.gcCreateBy,
            this.gcCreateDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            this.gcslton.DisplayFormat.FormatString = "#,###";
            this.gcslton.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcslton.FieldName = "slton";
            this.gcslton.Name = "gcslton";
            this.gcslton.Visible = true;
            this.gcslton.VisibleIndex = 2;
            // 
            // gcnguong
            // 
            this.gcnguong.Caption = "Ngưỡng";
            this.gcnguong.DisplayFormat.FormatString = "#,###";
            this.gcnguong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.gcCreateDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gcCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcCreateDate.FieldName = "CreateDate";
            this.gcCreateDate.Name = "gcCreateDate";
            this.gcCreateDate.Visible = true;
            this.gcCreateDate.VisibleIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::RestaurantManager.Properties.Resources.icons8_save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(353, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 28);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uctNLIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbAgency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "uctNLIEU";
            this.Size = new System.Drawing.Size(1284, 525);
            this.Load += new System.EventHandler(this.uctNLIEU_Load);
            this.grbAgency.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbAgency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIDAgency;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhang;
        private DevExpress.XtraGrid.Columns.GridColumn gctenhang;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateBy;
        private DevExpress.XtraGrid.Columns.GridColumn gcCreateDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn gcslton;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguong;
        private DevExpress.XtraGrid.Columns.GridColumn gcdongianl;
        private TextEdit nudDonGia2;
        private TextEdit txtSLT;
        private TextEdit txtNguong;
    }
}
