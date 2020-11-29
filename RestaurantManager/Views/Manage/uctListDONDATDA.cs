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
    public partial class uctListDONDATDA : UserControl
    {
        List<DONDATDA_ViewModel> lstDONDATDA;
        List<KHACHHANG> ListKHACHHANG;
        DateTime fromDate;
        DateTime toDate;
        public uctListDONDATDA()
        {
            InitializeComponent();
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            fromDate = month;
            toDate = month.AddMonths(1).AddDays(-1);
            dtpFromDate.Value = fromDate;
            dtpToDate.Value = toDate;
        }
        public static uctListDONDATDA uctDL = new uctListDONDATDA();


        private void uctListDONDATDA_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadData();
        }

        #region Event

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gvDONDATDA.GetDataRow(gvDONDATDA.GetSelectedRows()[0]);
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
            lstDONDATDA = await Task.Run(() => new DONDATDABll().GetListDONDATDA(0, fromDate, toDate));
            gcDONDATDA.DataSource = lstDONDATDA;
            gvDONDATDA.RefreshData();
        }
        public void GetData(int id, DateTime fromDate,DateTime toDate)
        {
            lstDONDATDA =  new DONDATDABll().GetListDONDATDA(id, fromDate, toDate);
            gcDONDATDA.DataSource = lstDONDATDA;
            gvDONDATDA.RefreshData();
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
            GetData(idkh, fromDate, toDate);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lueKhachHang.EditValue = 0;
            LoadGrid();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var row = gvDONDATDA.FocusedRowHandle;

                var obj = gvDONDATDA.GetFocusedRow();
                if (obj == null) return;
                var objData = (DONDATDA_ViewModel)obj;
                var DONDATDA = new DONDATDABll().GetDONDATDA(objData.iddondat);
                var D_DONDATDA = new DONDATDABll().GetListD_DONDATDA(objData.iddondat);
                using (frmPrint frm = new frmPrint())
                {
                    frm.PrintDONDATDA(DONDATDA, D_DONDATDA);
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
                var rowH = gvDONDATDA.FocusedRowHandle;
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
