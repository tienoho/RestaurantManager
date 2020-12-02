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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using RestaurantManager.Model;
using DevExpress.XtraBars;
using RestaurantManager.Views.Print;

namespace RestaurantManager
{
    public partial class uctHOADONTT : UserControl
    {
        BarButtonItem btnWaitOrder;
        List<DONDATDA_ViewModel> lstDONDATDA;
        List<D_DONDATDA_ViewModel> lstD_DONDATDA;
        List<KHACHHANG> ListKHACHHANG;
        public uctHOADONTT()
        {
            InitializeComponent();
        }
        public static uctHOADONTT uctDL = new uctHOADONTT();


        private void uctHOADONTT_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadData();
        }

        #region Event

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gvWaitOrder.GetDataRow(gvWaitOrder.GetSelectedRows()[0]);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object iddondat = (sender as GridView).GetRowCellValue(RowHandle, "iddondat");
            object idkh = (sender as GridView).GetRowCellValue(RowHandle, "idkh");
            object ban = (sender as GridView).GetRowCellValue(RowHandle, "ban");
            object ngaydat = (sender as GridView).GetRowCellValue(RowHandle, "ngaydat");

            txtiddondat.EditValue = iddondat;
            lueKhachHang.EditValue = idkh;
            //txtban.EditValue = ban;
            dtpngaydat.Value = (DateTime)ngaydat;

            if (txtiddondat.Text != null)
            {
                CalculateAmount((int)iddondat);
            }
        }

        private void gridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }
        private void txtCustomerPay_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTotalAmount.Text != "" && txtCustomerPay.Text != "")
            {
                double.TryParse(txtTotalAmount.EditValue.ToString(), out double TotalAmount);
                double.TryParse(txtCustomerPay.EditValue.ToString(), out double CustomerPay);

                double total = CustomerPay - TotalAmount;

                txtReturnPay.EditValue = total;
            }
        }

        private void btnAddHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtiddondat.Text == "" || txtiddondat.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn phải chọn đơn đặt đồ ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int.TryParse(txtiddondat.EditValue.ToString(), out int iddondat);
                if (iddondat <= 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn đơn đặt đồ ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtCustomerPay.Text == "" || txtCustomerPay.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn chưa nhập tiền khách đưa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double.TryParse(txtCustomerPay.EditValue.ToString(), out double CustomerPay);
                double.TryParse(txtTotalAmount.EditValue.ToString(), out double TotalAmount);

                int.TryParse(lueKhachHang.EditValue.ToString(), out int idkh);
                if (CustomerPay <= 0)
                {
                    XtraMessageBox.Show("Tiền khách đưa phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CustomerPay < TotalAmount)
                {
                    XtraMessageBox.Show("Tiền khách đưa phải lớn hơn hoặc bằng tổng tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var model = new HOADONTT_ViewModel
                {
                    iddondat = iddondat,
                    ngayhd = dtpngaydat.Value,
                    thoigian = DateTime.Now,
                    idkh = idkh,
                    //D_HOADONTT= lstD_DONDATDA,
                    thungan = Properties.Settings.Default.NameLog,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog
                };
                List<D_HOADONTT_ViewModel> lstD_HOADONTT = new List<D_HOADONTT_ViewModel>();
                foreach (D_DONDATDA_ViewModel item in lstD_DONDATDA)
                {
                    var D_HOADONTT = new D_HOADONTT_ViewModel
                    {
                        idmon = item.idmon,
                        slban = item.sldat,
                        tenmon = item.tenmon,
                        dongiaban = item.dongiamon,
                        CreateBy = Properties.Settings.Default.NameLog,
                        ModifyBy = Properties.Settings.Default.NameLog,
                    };
                    lstD_HOADONTT.Add(D_HOADONTT);
                }
                if (lstD_HOADONTT.Count() <= 0)
                {
                    XtraMessageBox.Show("Không có món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.D_HOADONTT = lstD_HOADONTT;

                var resultData = new HOADONTTBll().AddHOADONTT(model);
                if (resultData != null)
                {
                    LoadGrid();

                    var HOADONTT = new HOADONTTBll().GetHOADONTT(resultData.idhoadontt);
                    var D_HOADONTT = new HOADONTTBll().GetListD_HOADONTT(resultData.idhoadontt);

                    XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                    args.Caption = "Thông báo";
                    args.Text ="Thanh toán thành công!\n Bạn có muốn in hóa đơn ?";
                    args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
                    args.Showing += Args_Showing;

                    var result = XtraMessageBox.Show(args);
                    if (result == DialogResult.OK)
                    {
                        using (frmPrint frm = new frmPrint())
                        {
                            frm.PrintHOADONTT(model, lstD_HOADONTT);
                            frm.ShowDialog();
                        }
                        return;
                    }
                    ClearDisplay();
                    return;
                }
                XtraMessageBox.Show("Thanh toán không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        #region Function
        async public void LoadGrid()
        {
            lstDONDATDA = await Task.Run(() => new DONDATDABll().GetOuterOrder());
            gcWaitOrder.DataSource = lstDONDATDA;
        }
        async public void LoadData()
        {
            ListKHACHHANG = await Task.Run(() => new KHACHHANGBll().GetListKHACHHANG());
            lueKhachHang.Properties.DataSource = ListKHACHHANG
                .Select(item => new { idkh = item.idkh, tenkh = item.tenkh, sdt = item.sdt }).ToList();
            lueKhachHang.Properties.ValueMember = "idkh";
            lueKhachHang.Properties.DisplayMember = "tenkh";
        }
        private void ClearDisplay()
        {
            txtiddondat.Text = "";
            txtReturnPay.EditValue = 0;
            txtTotalAmount.EditValue = 0;
            txtCustomerPay.EditValue = 0;
            lueKhachHang.EditValue = 0;
            dtpngaydat.Value = DateTime.Now;
            lstD_DONDATDA = null;
            gcSelectItems.DataSource = lstD_DONDATDA;
            gridView1.RefreshData();

            changeCaption();

            //btnAdd.Enabled = true;
        }

        #endregion

        private void gvWaitOrder_Click(object sender, EventArgs e)
        {

        }
        private void CalculateAmount(int iddondat)
        {
            lstD_DONDATDA = new DONDATDABll().GetListD_DONDATDA(iddondat);
            gcSelectItems.DataSource = lstD_DONDATDA;
            var sum = lstD_DONDATDA.Sum(x => x.TotalAmount);
            txtTotalAmount.EditValue = sum;
        }


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

        private void txtCustomerPay_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClearHoDon_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            foreach (var control in e.Form.Controls)
            {
                SimpleButton button = control as SimpleButton;
                if (button != null)
                {
                    button.ImageOptions.SvgImageSize = new Size(16, 16);
                    switch (button.DialogResult.ToString())
                    {
                        case ("OK"):
                            button.ImageOptions.SvgImage = svgImageCollection1[0];
                            break;
                        case ("Cancel"):
                            button.ImageOptions.SvgImage = svgImageCollection1[1];
                            break;
                    }
                }
            }
        }

        private void btnUpdateDon_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void gvWaitOrder_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Right) return;
                var rowH = gvWaitOrder.FocusedRowHandle;
                if (rowH >= 0)
                {
                    popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
                }
                else
                {
                    popupMenu1.HidePopup();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
