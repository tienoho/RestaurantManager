using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RestaurantManager.Database;
using RestaurantManager.Bussiness;
using DevExpress.XtraGrid.Views.Tile;
using RestaurantManager.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using RestaurantManager.Views.Order;

namespace RestaurantManager
{
    public partial class uctDONDATDA : UserControl
    {
        #region 
        Color colorPanelReady = Color.FromArgb(58, 166, 101);
        Color colorPanelSold = Color.FromArgb(158, 158, 158);
        Color colorCaptionReady = Color.FromArgb(193, 222, 204);
        Color colorCaptionSold = Color.FromArgb(219, 219, 219);
        BarButtonItem btnWaitOrder;
        #endregion


        List<MONAN_ViewModel> ListMONAN;//danh sachs món ăn
        List<D_DONDATDA_ViewModel> ListD_DONDATDA = new List<D_DONDATDA_ViewModel>();//danh sách
        List<KHACHHANG> ListKHACHHANG;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public uctDONDATDA()
        {
            InitializeComponent();
            ListMONAN = new MONANBll().GetListMONAN_OutLeft();
            InitData(ListMONAN);
            SetupView2();
            rgViewType.SelectedIndexChanged += RgViewType_SelectedIndexChanged;
            tileView2.OptionsBehavior.AllowSmoothScrolling = true;
        }
        public static uctDONDATDA uctDL = new uctDONDATDA();

        public void fillCaption(BarButtonItem btn)
        {
            btnWaitOrder = btn;
            changeCaption();
        }
        public void changeCaption()
        {
            try
            {
                var list = new DONDATDABll().GetOuterOrder();
                btnWaitOrder.Caption = String.Format("Chờ thanh toán ({0})", list.Count());
            }
            catch
            {

            }
            
        }
        private void uctDONDATDA_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            LoadData();
        }



        #region Event
        private void tileView2_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            if (e.Item == null || e.Item.Elements.Count == 0)
                return;
            Color panelColor = colorPanelReady;
            Color captionColor = colorCaptionReady;
            panelColor = colorPanelSold;
            captionColor = colorCaptionSold;
            e.Item.Elements[0].Appearance.Normal.BackColor = panelColor;
            e.Item.Elements[2].Appearance.Normal.ForeColor = captionColor;
            e.Item.Elements[4].Appearance.Normal.ForeColor = captionColor;
        }
        private void panelControl6_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewMon();
        }
        private void tileView1_ItemCustomize_1(object sender, TileViewItemCustomizeEventArgs e)
        {
            if (e.Item == null || e.Item.Elements.Count == 0)
                return;
            //int slton = (int)tileView1.GetRowCellValue(e.RowHandle, tileView1.Columns["slton"]);
            Color panelColor = colorPanelReady;
            Color captionColor = colorCaptionReady;
            //if (slton > 0)
            //{
            panelColor = colorPanelSold;
            captionColor = colorCaptionSold;
            e.Item.Elements[6].Text = "Sold";
            //}
            e.Item.Elements[0].Appearance.Normal.BackColor = panelColor;
            e.Item.Elements[2].Appearance.Normal.ForeColor = captionColor;
            e.Item.Elements[4].Appearance.Normal.ForeColor = captionColor;
        }

        private void RgViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tileView2.OptionsTiles.Orientation = (Orientation)rgViewType.SelectedIndex;
        }

        private void ToggleSwitch1_EditValueChanged(object sender, EventArgs e)
        {
            //if (object.Equals(toggleSwitch1.EditValue, true))
            //    tileView1.ColumnSet.GroupColumn = tileView1.Columns["YearBuilt"];
            //else
            //    tileView1.ColumnSet.GroupColumn = null;
        }

        void repositoryItemZoomTrackBar1_EditValueChanged(object sender, EventArgs e)
        {
            int h = (int)(sender as BaseEdit).EditValue;
            int w = (int)(h * 1.78);
            tileView2.OptionsTiles.ItemSize = new Size(w, h);
        }
        #endregion
        #region Function
        void SetupView2()
        {
            try
            {
                // Setup tiles options
                tileView2.BeginUpdate();
                tileView2.OptionsTiles.RowCount = 3;
                tileView2.OptionsTiles.Padding = new Padding(20);
                tileView2.OptionsTiles.ItemPadding = new Padding(10);
                tileView2.OptionsTiles.IndentBetweenItems = 20;
                tileView2.OptionsTiles.ItemSize = new Size(240, 100);
                tileView2.Appearance.ItemNormal.ForeColor = Color.White;
                tileView2.Appearance.ItemNormal.BorderColor = Color.Transparent;
                //Setup tiles template
                TileViewItemElement leftPanel = new TileViewItemElement();
                TileViewItemElement splitLine = new TileViewItemElement();
                TileViewItemElement addressCaption = new TileViewItemElement();
                TileViewItemElement addressValue = new TileViewItemElement();
                TileViewItemElement yearBuiltCaption = new TileViewItemElement();
                TileViewItemElement yearBuiltValue = new TileViewItemElement();
                TileViewItemElement price = new TileViewItemElement();
                TileViewItemElement image = new TileViewItemElement();
                tileView2.TileTemplate.Add(leftPanel);
                tileView2.TileTemplate.Add(splitLine);
                tileView2.TileTemplate.Add(addressCaption);
                tileView2.TileTemplate.Add(addressValue);
                tileView2.TileTemplate.Add(yearBuiltCaption);
                tileView2.TileTemplate.Add(yearBuiltValue);
                tileView2.TileTemplate.Add(price);
                tileView2.TileTemplate.Add(image);
                //
                leftPanel.StretchVertical = true;
                leftPanel.Width = 122;
                leftPanel.TextLocation = new Point(-10, 0);
                leftPanel.Appearance.Normal.BackColor = Color.FromArgb(58, 166, 101);
                //
                splitLine.StretchVertical = true;
                splitLine.Width = 3;
                splitLine.TextAlignment = TileItemContentAlignment.Manual;
                splitLine.TextLocation = new Point(110, 0);
                splitLine.Appearance.Normal.BackColor = Color.White;
                //
                addressCaption.Text = "Tên món";
                addressCaption.TextAlignment = TileItemContentAlignment.TopLeft;
                addressCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                addressValue.Column = tileView2.Columns["temon"];
                addressValue.AnchorElement = addressCaption;
                addressValue.AnchorIndent = 2;
                addressValue.MaxWidth = 100;
                addressValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                yearBuiltCaption.Text = "Giá bán";
                yearBuiltCaption.AnchorElement = addressValue;
                yearBuiltCaption.AnchorIndent = 14;
                yearBuiltCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                yearBuiltValue.Column = tileView2.Columns["dongiamon"];
                yearBuiltValue.AnchorElement = yearBuiltCaption;
                yearBuiltValue.AnchorIndent = 2;
                yearBuiltValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //

                //
                image.Column = tileView2.Columns["Image"];
                image.ImageSize = new Size(240, 100);
                //image.ImageScaleMode = TileItemImageScaleMode.Stretch;
                image.ImageAlignment = TileItemContentAlignment.MiddleCenter;
                image.ImageScaleMode = TileItemImageScaleMode.ZoomInside;
                image.ImageLocation = new Point(10, 10);

            }
            finally
            {
                tileView2.EndUpdate();
            }
        }
        private void InitData(List<MONAN_ViewModel> listMonan)
        {
            try
            {
                var monAnTable = Utils.ToDataTable(listMonan);
                monAnTable.Columns.Add("Image", typeof(Image));
                foreach (DataRow row in monAnTable.Rows)
                {
                    var hinhanh = row["hinhanh"] as string;
                    var img = Image.FromFile(path + "\\images\\" + hinhanh);
                    row["Image"] = new Bitmap(img, new Size(240, 100));
                }
                gridControl1.DataSource = monAnTable;
            }
            catch { }
        }
        /// <summary>
        /// hàm load data
        /// </summary>
        async public void LoadData()
        {
            ListKHACHHANG = await Task.Run(() => new KHACHHANGBll().GetListKHACHHANG());
            lueKhachHang.Properties.DataSource = ListKHACHHANG
                .Select(item => new { idkh = item.idkh, tenkh = item.tenkh, sdt = item.sdt }).ToList();
            lueKhachHang.Properties.ValueMember = "idkh";
            lueKhachHang.Properties.DisplayMember = "tenkh";
        }
        private void LoadDataGrid()
        {

            //gridControl1.DataSource = ListMONAN;
        }
        private void ClearDisplay()
        {
            //txtIDAgency.Text = DataProvider.ExcuteScalar(string.Format("SELECT MaDL=dbo.fcGetMaDL()"));
            //txtNameAgency.Text = "";
            //txtAddressOfAgency.Text = "";
            //txtNumberPhone.Text = "";

        }
        #endregion

        private void gridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {

        }

        private void tileView2_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            // if (!IsEmptyItem(e.Item.RowHandle)) return;
            object idmon = tileView2.GetRowCellValue(e.Item.RowHandle, "idmon");
            object temon = tileView2.GetRowCellValue(e.Item.RowHandle, "temon");
            object dongiamon = tileView2.GetRowCellValue(e.Item.RowHandle, "dongiamon");

            txtidmon.EditValue = idmon;
            txttemon.EditValue = temon;
            txtdongia.EditValue = dongiamon;
        }
        bool IsEmptyItem(int rowHandle)
        {
            var row = tileView2.GetRow(rowHandle);
            if (row == null) return false;
            return (int)tileView2.GetRowCellValue(rowHandle, "idmon") < 0;
        }
        void AddNewMon()
        {
            if (txtidmon.EditValue == null || String.IsNullOrEmpty(txtidmon.EditValue.ToString())) return;
            var idmon = (int)txtidmon.EditValue;
            var temon = (string)txttemon.EditValue;
            var dongia = (double)txtdongia.EditValue;
            if (idmon <= 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(txtsoluong.EditValue.ToString(), out int soluong);
            if (soluong <= 0)
            {
                XtraMessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var item = new D_DONDATDA_ViewModel
            {
                idmon = idmon,
                tenmon = temon,
                dongiamon = dongia,
                sldat = soluong,
                TotalAmount = soluong * dongia,
                CreateBy = Properties.Settings.Default.NameLog,
                ModifyBy = Properties.Settings.Default.NameLog
            };
            var check = ListD_DONDATDA.Find(x => x.idmon == idmon);

            if (check == null)
            {
                ListD_DONDATDA.Add(item);
            }
            else
            {
                check.sldat = soluong;
                check.TotalAmount = soluong * dongia;
            }

            gcSelectItems.DataSource = ListD_DONDATDA;
            gcSelectItems.Refresh();
            gcSelectItems.Update();
            gridView1.RefreshData();
            ClearMon();
            CalculateAmount();
        }
        private void ClearMon()
        {
            txtidmon.EditValue = null;
            txttemon.EditValue = "";
            txtdongia.EditValue = null;
            txtsoluong.EditValue = 1;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idmon = (sender as GridView).GetRowCellValue(RowHandle, "idmon");
            object tenmon = (sender as GridView).GetRowCellValue(RowHandle, "tenmon");
            object dongiamon = (sender as GridView).GetRowCellValue(RowHandle, "dongiamon");
            object sldat = (sender as GridView).GetRowCellValue(RowHandle, "sldat");

            txtidmon.EditValue = idmon;
            txttemon.EditValue = tenmon;
            txtdongia.EditValue = dongiamon;
            txtsoluong.EditValue = sldat;
        }

        private void gcSelectItems_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtidmon.EditValue == null || String.IsNullOrEmpty(txtidmon.EditValue.ToString())) return;



            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtidmon.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải món cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                var idmon = (int)txtidmon.EditValue;
                ListD_DONDATDA.Remove(ListD_DONDATDA.Find(x => x.idmon == idmon));

                XtraMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gcSelectItems.Refresh();
                gcSelectItems.Update();
                gridView1.RefreshData();
                CalculateAmount();
                return;
            }
        }

        #region Lưu hóa đơn

        #endregion

        private void btnAddHoaDon_Click(object sender, EventArgs e)
        {
            CalculateAmount();
            var khachhang = lueKhachHang.EditValue;
            var resultDialog = XtraMessageBox.Show("Bạn có chắc chắn muốn lưu ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (resultDialog == DialogResult.Yes)
            {
                if (ListD_DONDATDA.Count <= 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (lueKhachHang.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtban.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập bàn ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var hoadon = new DONDATDA_ViewModel
                {
                    idkh = (int)khachhang,
                    ban = txtban.Text,
                    ngaydat = dtpngaydat.Value,
                    D_DONDATDA = ListD_DONDATDA,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog
                };
                var result = new DONDATDABll().AddDONDATDA(hoadon);
                changeCaption();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearHoaDon();
                return;
            }
        }

        private void btnClearHoDon_Click(object sender, EventArgs e)
        {

        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var frmAdd = new frmAddCustomer();
            var result = frmAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void CalculateAmount()
        {
            var sum = ListD_DONDATDA.Sum(x => x.TotalAmount);
            txtTotalAmount.EditValue = sum;
        }
        private void ClearHoaDon()
        {
            txtban.EditValue = null;
            dtpngaydat.Value = DateTime.Now;
            txtTotalAmount.EditValue = null;
            lueKhachHang.EditValue = null;
            ClearMon();
            gcSelectItems.DataSource = null;
            gridView1.RefreshData();
            ListD_DONDATDA = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var key = txtKey.Text;
            if (key != "")
            {
                var lst = ListMONAN.Where(x => x.temon.Contains(key) || x.tendmuc.Contains(key)).ToList();
                InitData(lst);
            }
            else
            {
                InitData(ListMONAN);
            }
        }
    }
}
