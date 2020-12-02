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
using RestaurantManager.Views.Print;

namespace RestaurantManager
{
    public partial class uctListHOADONM : UserControl
    {
        List<HOADONTT_ViewModel> lstHOADONTT;
        List<KHACHHANG> ListKHACHHANG;
        DateTime fromDate;
        DateTime toDate;
        public uctListHOADONM()
        {
            InitializeComponent();
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            fromDate = month;
            toDate = month.AddMonths(1).AddDays(-1);
            dtpFromDate.Value = fromDate;
            dtpToDate.Value = toDate;
        }
        public static uctListHOADONM uctDL = new uctListHOADONM();


        private void uctListHOADONM_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadData();
        }

        #region Event

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gvHOADONTT.GetDataRow(gvHOADONTT.GetSelectedRows()[0]);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idncc = (sender as GridView).GetRowCellValue(RowHandle, "idncc");
            object tenncc = (sender as GridView).GetRowCellValue(RowHandle, "tenncc");
            object diachi = (sender as GridView).GetRowCellValue(RowHandle, "diachi");
            object sdt = (sender as GridView).GetRowCellValue(RowHandle, "sdt");
            object stk = (sender as GridView).GetRowCellValue(RowHandle, "stk");
        }

        private void gridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
        }

        #endregion

        #region Function
        async public void LoadGrid()
        {
            lstHOADONTT = await Task.Run(() => new HOADONTTBll().GetListHOADONTT(0, fromDate, toDate));
            gcHOADONTT.DataSource = lstHOADONTT;
            gvHOADONTT.RefreshData();
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

        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFromDate.Value;
            var toDate = dtpToDate.Value;
            int idkh = 0;
            if (lueKhachHang.Text == "" || lueKhachHang.EditValue == null)
            {
                idkh = 0;
            }
            else
            {
                int.TryParse(lueKhachHang.EditValue.ToString(), out idkh);
            }

            lstHOADONTT = new HOADONTTBll().GetListHOADONTT(idkh, fromDate, toDate);
            gcHOADONTT.DataSource = lstHOADONTT;
            gvHOADONTT.RefreshData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var row = gvHOADONTT.FocusedRowHandle;

                var obj = gvHOADONTT.GetFocusedRow();
                if (obj == null) return;
                var objData = (HOADONTT_ViewModel)obj;
                var HOADONTT = new HOADONTTBll().GetHOADONTT(objData.idhoadontt);
                var D_HOADONTT = new HOADONTTBll().GetListD_HOADONTT(objData.idhoadontt);
                using (frmPrint frm = new frmPrint())
                {
                    frm.PrintHOADONTT(HOADONTT, D_HOADONTT);
                    frm.ShowDialog();
                }
            }
            catch
            {

            }
        }

        private void gvHOADONTT_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Right) return;
                var rowH = gvHOADONTT.FocusedRowHandle;
                //var focusedRowView = (DataRowView)gvGIAOHANG.GetFocusedRow();
                //if (focusedRowView == null || focusedRowView.IsNew) return;
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
