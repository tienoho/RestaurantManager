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
using RestaurantManager.Views.Order;

namespace RestaurantManager
{
    public partial class uctGIAOHANG : UserControl
    {
        List<GIAOHANG_ViewModel> lstGIAOHANG;
        List<D_GIAOHANG_ViewModel> lstD_GIAOHANG;
        public uctGIAOHANG()
        {
            InitializeComponent();
        }
        public static uctGIAOHANG uctDL = new uctGIAOHANG();
        private void uctGIAOHANG_Load(object sender, EventArgs e)
        {
            LoadGrid();

        }
        #region Event

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idpgiao = (sender as GridView).GetRowCellValue(RowHandle, "idpgiao");
            LoadGridDetails((int)idpgiao);
        }

        private void gridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmGIAOHANG_Detail frm = new frmGIAOHANG_Detail();
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //txttenhang.Enabled = true;
            //txtNguong.Enabled = true;
            //nudDonGia2.Enabled = true;
            //txtSLT.Enabled = true;

            //btnAdd.Enabled = false;
            //btnUpdate.Enabled = false;
            //btnDelete.Enabled = false;
            //btnSave.Enabled = true;
        }


        #endregion

        #region Function
        public void LoadGrid()
        {
            lstGIAOHANG = new GIAOHANGBll().GetListGIAOHANG();
            gcGIAOHANG.DataSource = lstGIAOHANG;
            gvGIAOHANG.RefreshData();
        }
        private void ClearDisplay()
        {
            //txtid.Text = "";
            //txttenhang.Text = "";
            //txtNguong.EditValue = 0;
            //nudDonGia2.EditValue = 0;
            //txtSLT.EditValue = 0;

            //txttenhang.Enabled = false;
            //txtNguong.Enabled = false;
            //nudDonGia2.Enabled = false;
            //txtSLT.Enabled = false;

            //btnAdd.Enabled = true;
            //btnUpdate.Enabled = true;
            //btnDelete.Enabled = true;
            //btnSave.Enabled = false;
        }
        #endregion

        #region Chi tiết
        async public void LoadGridDetails(int id)
        {
            lstD_GIAOHANG = await Task.Run(() => new GIAOHANGBll().GetListD_GIAOHANG(id));
            gcD_GIAOHANG.DataSource = lstD_GIAOHANG;
        }
        #endregion

        private void btnDeleteRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var row = gvGIAOHANG.FocusedRowHandle;
            gvGIAOHANG.DeleteRow(row);
        }

        private void gvGIAOHANG_MouseUp(object sender, MouseEventArgs e)
        {
            try {
                if (e.Button != MouseButtons.Right) return;
                var rowH = gvGIAOHANG.FocusedRowHandle;
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
            catch(Exception ex)
            {

            }
            
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}