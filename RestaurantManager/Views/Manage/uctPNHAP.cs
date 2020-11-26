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
using RestaurantManager.Views.Order;

namespace RestaurantManager
{
    public partial class uctPNHAP : UserControl
    {
        List<DONMH_ViewModel> lstDONMH;
        List<D_DONMH_ViewModel> lstD_DONMH;
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
            object iddonmh = (sender as GridView).GetRowCellValue(RowHandle, "iddonmh");
            LoadGridDetails((int)iddonmh);
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
            frm.Show();
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
            lstDONMH = new DONMHBll().GetListDONMH();
            gridControl1.DataSource = lstDONMH;
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
        async public void LoadGridDetails(int iddonmh)
        {
            lstD_DONMH = await Task.Run(() => new DONMHBll().GetListD_DONMH(iddonmh));
            gcD_DONMH.DataSource = lstD_DONMH;
        }
        #endregion
    }
}