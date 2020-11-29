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
    public partial class uctPYC : UserControl
    {
        List<PYC_ViewModel> lstPYC;
        List<D_PYC_ViewModel> lstD_PYC;
        int idyc = 0;
        public uctPYC()
        {
            InitializeComponent();
        }
        public static uctPYC uctDL = new uctPYC();
        private void uctPYC_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        #region PYC
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
            object idyc = (sender as GridView).GetRowCellValue(RowHandle, "idyc");

            this.idyc = (int)idyc;
            LoadGridDetails(this.idyc);
            btnPrint.Enabled = true;
            //object tenhang = (sender as GridView).GetRowCellValue(RowHandle, "tenhang");
            //object slton = (sender as GridView).GetRowCellValue(RowHandle, "slton");
            //object nguong = (sender as GridView).GetRowCellValue(RowHandle, "nguong");
            //object dongianl = (sender as GridView).GetRowCellValue(RowHandle, "dongianl");
        }

        private void gridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
        async public void LoadGrid()
        {
            lstPYC = await Task.Run(() => new PYCBll().GetListPYC());
            gridControl1.DataSource = lstPYC;
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
        async public void LoadGridDetails(int idyc)
        {
            lstD_PYC = await Task.Run(() => new PYCBll().GetListD_PYC(idyc));
            gcD_PYC.DataSource = lstD_PYC;
        }
        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //  var obj = lstD_PYC.Current as PYC;
            if (this.idyc > 0)
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var obj = db.PYCs.AsNoTracking().FirstOrDefault(x => x.idyc == this.idyc);
                    var details = new PYCBll().GetListD_PYC(this.idyc);
                    using (frmPrint frm = new frmPrint())
                    {
                        frm.PrintPYC(obj, details);
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
}
