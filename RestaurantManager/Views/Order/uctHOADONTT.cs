﻿using System;
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
                if (txtCustomerPay.Text == "" || txtCustomerPay.EditValue==null)
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
                        dongiaban = item.dongiamon,
                        CreateBy = Properties.Settings.Default.NameLog,
                        ModifyBy = Properties.Settings.Default.NameLog,
                    };
                    lstD_HOADONTT.Add(D_HOADONTT);
                }
                if (lstD_HOADONTT.Count()<=0)
                {
                    XtraMessageBox.Show("Không có món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                model.D_HOADONTT = lstD_HOADONTT;

                var msg = new HOADONTTBll().AddHOADONTT(model);
                if (msg != null && msg != "")
                {
                    LoadGrid();
                    XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
                XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}