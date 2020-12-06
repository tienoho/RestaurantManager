using DevExpress.XtraEditors;

namespace RestaurantManager.Views.Order
{
    partial class frmPYC_Detail
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcPYCDetails = new DevExpress.XtraGrid.GridControl();
            this.gvPYCDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcidhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcsldukien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcslton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcnguong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsldukien = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lueNLieu = new DevExpress.XtraEditors.LookUpEdit();
            this.txtslton = new DevExpress.XtraEditors.TextEdit();
            this.btnClearDetails = new System.Windows.Forms.Button();
            this.txtnguong = new DevExpress.XtraEditors.TextEdit();
            this.btnDeleteDetails = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grbAgency = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpnyc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPYCDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPYCDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsldukien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtslton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguong.Properties)).BeginInit();
            this.grbAgency.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
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
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.grbAgency);
            this.panel2.Controls.Add(this.pictureEdit1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 577);
            this.panel2.TabIndex = 15;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gcPYCDetails);
            this.panelControl1.Location = new System.Drawing.Point(3, 259);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(927, 311);
            this.panelControl1.TabIndex = 47;
            // 
            // gcPYCDetails
            // 
            this.gcPYCDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPYCDetails.Location = new System.Drawing.Point(2, 2);
            this.gcPYCDetails.MainView = this.gvPYCDetails;
            this.gcPYCDetails.Name = "gcPYCDetails";
            this.gcPYCDetails.Size = new System.Drawing.Size(923, 307);
            this.gcPYCDetails.TabIndex = 0;
            this.gcPYCDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPYCDetails});
            this.gcPYCDetails.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gcPYCDetails_ViewRegistered);
            // 
            // gvPYCDetails
            // 
            this.gvPYCDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcidhang,
            this.gctenhang,
            this.gcsldukien,
            this.gcslton,
            this.gcnguong});
            this.gvPYCDetails.GridControl = this.gcPYCDetails;
            this.gvPYCDetails.Name = "gvPYCDetails";
            this.gvPYCDetails.OptionsBehavior.Editable = false;
            this.gvPYCDetails.OptionsBehavior.ReadOnly = true;
            this.gvPYCDetails.OptionsFind.AlwaysVisible = true;
            this.gvPYCDetails.DoubleClick += new System.EventHandler(this.gvPYCDetails_DoubleClick);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(5, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 90);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtsldukien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lueNLieu);
            this.panel1.Controls.Add(this.txtslton);
            this.panel1.Controls.Add(this.btnClearDetails);
            this.panel1.Controls.Add(this.txtnguong);
            this.panel1.Controls.Add(this.btnDeleteDetails);
            this.panel1.Controls.Add(this.btnUpdateDetails);
            this.panel1.Controls.Add(this.btnAddDetails);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 69);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtsldukien
            // 
            this.txtsldukien.Location = new System.Drawing.Point(145, 38);
            this.txtsldukien.Name = "txtsldukien";
            this.txtsldukien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtsldukien.Properties.Appearance.Options.UseFont = true;
            this.txtsldukien.Properties.DisplayFormat.FormatString = "#,###";
            this.txtsldukien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsldukien.Properties.Mask.EditMask = "n0";
            this.txtsldukien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtsldukien.Properties.MaxLength = 9;
            this.txtsldukien.Properties.NullText = "0";
            this.txtsldukien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsldukien.Size = new System.Drawing.Size(179, 20);
            this.txtsldukien.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số lượng dự kiến";
            // 
            // lueNLieu
            // 
            this.lueNLieu.Location = new System.Drawing.Point(96, 6);
            this.lueNLieu.Name = "lueNLieu";
            this.lueNLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNLieu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idhang", "Mã hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenhang", "Tên hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("slton", "Số lượng tồn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nguong", "Ngưỡng")});
            this.lueNLieu.Properties.NullText = "";
            this.lueNLieu.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueNLieu.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lueNLieu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueNLieu.Size = new System.Drawing.Size(228, 20);
            this.lueNLieu.TabIndex = 31;
            this.lueNLieu.EditValueChanged += new System.EventHandler(this.lueNLieu_EditValueChanged);
            // 
            // txtslton
            // 
            this.txtslton.Location = new System.Drawing.Point(426, 8);
            this.txtslton.Name = "txtslton";
            this.txtslton.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtslton.Properties.Appearance.Options.UseFont = true;
            this.txtslton.Properties.DisplayFormat.FormatString = "#,###";
            this.txtslton.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtslton.Properties.Mask.EditMask = "n0";
            this.txtslton.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtslton.Properties.MaxLength = 9;
            this.txtslton.Properties.NullText = "0";
            this.txtslton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtslton.Size = new System.Drawing.Size(146, 20);
            this.txtslton.TabIndex = 29;
            // 
            // btnClearDetails
            // 
            this.btnClearDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDetails.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClearDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDetails.Location = new System.Drawing.Point(674, 33);
            this.btnClearDetails.Name = "btnClearDetails";
            this.btnClearDetails.Size = new System.Drawing.Size(87, 28);
            this.btnClearDetails.TabIndex = 19;
            this.btnClearDetails.Text = "Làm mới";
            this.btnClearDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearDetails.UseVisualStyleBackColor = true;
            this.btnClearDetails.Click += new System.EventHandler(this.btnClearDetails_Click);
            // 
            // txtnguong
            // 
            this.txtnguong.Location = new System.Drawing.Point(426, 40);
            this.txtnguong.Name = "txtnguong";
            this.txtnguong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtnguong.Properties.Appearance.Options.UseFont = true;
            this.txtnguong.Properties.DisplayFormat.FormatString = "#,###";
            this.txtnguong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnguong.Properties.EditFormat.FormatString = "n0";
            this.txtnguong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtnguong.Properties.Mask.EditMask = "n0";
            this.txtnguong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtnguong.Properties.MaxLength = 9;
            this.txtnguong.Properties.NullText = "0";
            this.txtnguong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnguong.Size = new System.Drawing.Size(146, 20);
            this.txtnguong.TabIndex = 28;
            // 
            // btnDeleteDetails
            // 
            this.btnDeleteDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetails.Image = global::RestaurantManager.Properties.Resources.delete_3;
            this.btnDeleteDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDetails.Location = new System.Drawing.Point(674, 3);
            this.btnDeleteDetails.Name = "btnDeleteDetails";
            this.btnDeleteDetails.Size = new System.Drawing.Size(87, 28);
            this.btnDeleteDetails.TabIndex = 16;
            this.btnDeleteDetails.Text = "Xóa bỏ";
            this.btnDeleteDetails.UseVisualStyleBackColor = false;
            this.btnDeleteDetails.Click += new System.EventHandler(this.btnDeleteDetails_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUpdateDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateDetails.Enabled = false;
            this.btnUpdateDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetails.Image = global::RestaurantManager.Properties.Resources.update_5;
            this.btnUpdateDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDetails.Location = new System.Drawing.Point(578, 33);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(92, 28);
            this.btnUpdateDetails.TabIndex = 17;
            this.btnUpdateDetails.Text = "Cập nhật";
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
            this.btnAddDetails.Location = new System.Drawing.Point(578, 3);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(92, 28);
            this.btnAddDetails.TabIndex = 18;
            this.btnAddDetails.Text = "Thêm mới";
            this.btnAddDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDetails.UseVisualStyleBackColor = false;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngưỡng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng tồn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã hàng";
            // 
            // grbAgency
            // 
            this.grbAgency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAgency.Controls.Add(this.panel3);
            this.grbAgency.Location = new System.Drawing.Point(8, 29);
            this.grbAgency.Name = "grbAgency";
            this.grbAgency.Size = new System.Drawing.Size(684, 128);
            this.grbAgency.TabIndex = 46;
            this.grbAgency.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dtpnyc);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 107);
            this.panel3.TabIndex = 2;
            // 
            // dtpnyc
            // 
            this.dtpnyc.CustomFormat = "hh:mm dd/MM/yyyy";
            this.dtpnyc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpnyc.Location = new System.Drawing.Point(462, 6);
            this.dtpnyc.Name = "dtpnyc";
            this.dtpnyc.Size = new System.Drawing.Size(205, 21);
            this.dtpnyc.TabIndex = 23;
            this.dtpnyc.Value = new System.DateTime(2020, 11, 21, 19, 10, 58, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày yêu cầu";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::RestaurantManager.Properties.Resources.icons8_save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(96, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 28);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(96, 6);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(262, 21);
            this.txtid.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::RestaurantManager.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(196, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 29);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Làm mới";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã yêu cầu";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::RestaurantManager.Properties.Resources.giao_hang;
            this.pictureEdit1.Location = new System.Drawing.Point(705, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(225, 122);
            this.pictureEdit1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "PHIẾU YÊU CẦU";
            // 
            // frmPYC_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Name = "frmPYC_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu yêu cầu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPYCDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPYCDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsldukien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtslton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguong.Properties)).EndInit();
            this.grbAgency.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private PictureEdit pictureEdit1;
        private System.Windows.Forms.GroupBox grbAgency;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpnyc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private TextEdit txtsldukien;
        private System.Windows.Forms.Label label6;
        private LookUpEdit lueNLieu;
        private TextEdit txtslton;
        private System.Windows.Forms.Button btnClearDetails;
        private TextEdit txtnguong;
        private System.Windows.Forms.Button btnDeleteDetails;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcPYCDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPYCDetails;
        private DevExpress.XtraGrid.Columns.GridColumn gcidhang;
        private DevExpress.XtraGrid.Columns.GridColumn gctenhang;
        private DevExpress.XtraGrid.Columns.GridColumn gcsldukien;
        private DevExpress.XtraGrid.Columns.GridColumn gcslton;
        private DevExpress.XtraGrid.Columns.GridColumn gcnguong;
    }
}