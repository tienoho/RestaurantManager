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
using RestaurantManager.Views.Print;

namespace RestaurantManager
{
    public partial class uctPNHAP : UserControl
    {
        List<PNHAP> lstPNHAP;
        List<D_PNHAP_ViewModel> lstDPNHAP;
        public uctPNHAP()
        {
            InitializeComponent();
        }
        public static uctPNHAP uctDL = new uctPNHAP();
        private void uctPNHAP_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        #region Đơn mua hàng
        private void LoadDataGrid()
        {
            LoadGrid();
        }

        #endregion
        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotalDebtOfAgency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #region Event

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idpnhap = (sender as GridView).GetRowCellValue(RowHandle, "idpnhap");
            LoadGridDetails((int)idpnhap);
        }

        private void gridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPNhap frm = new frmPNhap();
            var result = frm.ShowDialog();
            if (result == DialogResult.Cancel)
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
            lstPNHAP = new PNHAPBll().GetListPNHAP();
            gridControl1.DataSource = lstPNHAP;
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
        public void LoadGridDetails(int idpnhap)
        {
            lstDPNHAP = new PNHAPBll().GetListDNHAP(idpnhap);
            gcD_DONMH.DataSource = lstDPNHAP;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            var selects = gridView1.GetSelectedRows();
            var row = gridView1.GetRow(selects[0]);
            if (selects == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn phiếu nhập để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var select = (PNHAP)row;
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var res = new PNHAPBll().DeletePNHAP(select.idpnhap);
            }
        }

        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Right) return;
                var rowH = gridView2.FocusedRowHandle;
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

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var row = gridView1.FocusedRowHandle;

                var obj = gridView1.GetFocusedRow();
                if (obj == null) return;
                var objData = (PNHAP)obj;
                var master = new PNHAPBll().GetPNHAPById(objData.idpnhap);
                using (frmPrint frm = new frmPrint())
                {
                    frm.PrintPNHAP(master, master.lstDetail);
                    frm.ShowDialog();
                }
            }
            catch
            {

            }
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Right) return;
                var rowH = gridView1.FocusedRowHandle;
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