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
    public partial class uctHOADONM : UserControl
    {
        BarButtonItem btnWaitOrder;
        List<PNHAP_ViewModel> lstPNHAP;
        List<D_PNHAP_ViewModel> lstD_PNHAP;

        public uctHOADONM()
        {
            InitializeComponent();
        }
        public static uctHOADONM uctDL = new uctHOADONM();


        private void uctHOADONM_Load(object sender, EventArgs e)
        {
            LoadGrid();
            //LoadData();
        }

        #region Event

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gvPNHAP.GetDataRow(gvPNHAP.GetSelectedRows()[0]);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idpnhap = (sender as GridView).GetRowCellValue(RowHandle, "idpnhap");
            //object idkh = (sender as GridView).GetRowCellValue(RowHandle, "idkh");
            //object ban = (sender as GridView).GetRowCellValue(RowHandle, "ban");
            //object ngaydat = (sender as GridView).GetRowCellValue(RowHandle, "ngaydat");

            txtidpnhap.EditValue = idpnhap;

            if (txtidpnhap.Text != null)
            {
                GetD_PNHAP((int)idpnhap);
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

        private void btnAddHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidpnhap.Text == "" || txtidpnhap.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn phải chọn phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int.TryParse(txtidpnhap.EditValue.ToString(), out int idpnhap);
                if (idpnhap <= 0)
                {
                    XtraMessageBox.Show("Bạn phải chọn phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double.TryParse(txtTotalAmount.EditValue.ToString(), out double TotalAmount);
                var ngaymua = dtpngaydat.Value;

                var model = new HOADONM
                {
                    idpnhap = idpnhap,
                    ngaymua = ngaymua
                };
                List<D_HOADONM> lstD_HOADONM = new List<D_HOADONM>();

                foreach (D_PNHAP_ViewModel item in lstD_PNHAP)
                {
                    var details = new D_HOADONM
                    {
                        idhang = item.idhang,
                        slmua = item.idpnhap,
                        dongiamua = item.dongiamh,
                    };
                    lstD_HOADONM.Add(details);
                }
                if (lstD_HOADONM.Count() <= 0)
                {
                    XtraMessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var resultData = new HOADONMBll().AddHOADONM(model, lstD_HOADONM, Properties.Settings.Default.NameLog);
                if (resultData != null)
                {
                    LoadGrid();

                    XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                    args.Caption = "Thông báo";
                    args.Text = "Xuất hóa đơn thành công!\n Bạn có muốn in hóa đơn ?";
                    args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
                    args.Showing += Args_Showing;

                    var result = XtraMessageBox.Show(args);
                    if (result == DialogResult.OK)
                    {
                        using (frmPrint frm = new frmPrint())
                        {
                            //frm.PrintHOADONM(resultData, lstD_HOADONM);
                            // frm.ShowDialog();
                        }
                        return;
                    }

                    //XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
                // XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                lstPNHAP = await Task.Run(() => new PNHAPBll().GetListPNHAPFull());
                gcPNHAP.DataSource = lstPNHAP;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //async public void LoadData()
        //{
        //   // lstPNHAP = await Task.Run(() => new PNHAPBll().GetListPNHAPFull());

        //    lueKhachHang.Properties.DataSource = ListKHACHHANG
        //        .Select(item => new { idkh = item.idkh, tenkh = item.tenkh, sdt = item.sdt }).ToList();
        //    lueKhachHang.Properties.ValueMember = "idkh";
        //    lueKhachHang.Properties.DisplayMember = "tenkh";
        //}
        private void ClearDisplay()
        {
            txtidpnhap.Text = "";
            dtpngaydat.Value = DateTime.Now;
            txtTotalAmount.EditValue = 0;
            lstD_PNHAP = null;
            gcSelectItems.DataSource = lstD_PNHAP;
            gvSelectItems.RefreshData();

        }
        private void CalculateAmount(List<D_PNHAP_ViewModel> lstD_PNHAP)
        {
            var sum = lstD_PNHAP.Sum(x => x.TotalAmount);
            txtTotalAmount.EditValue = sum;
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
        #endregion

        private void gvWaitOrder_Click(object sender, EventArgs e)
        {

        }
        private void GetD_PNHAP(int idpnhap)
        {
            try
            {
                lstD_PNHAP = new PNHAPBll().GetListD_PNHAP_Full(idpnhap);
                CalculateAmount(lstD_PNHAP);
                gcSelectItems.DataSource = lstD_PNHAP;
                gvSelectItems.RefreshData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
