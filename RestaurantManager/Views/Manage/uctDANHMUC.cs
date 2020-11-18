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

namespace RestaurantManager
{
    public partial class uctDANHMUC : UserControl
    {
        List<DANHMUC> lstDANHMUC;
        public uctDANHMUC()
        {
            InitializeComponent();
        }
        public static uctDANHMUC uctDL = new uctDANHMUC();


        private void uctDANHMUC_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        #region Danh mục
        private void LoadDataGrid()
        {
            LoadGrid();

        }
        private void btnUpdateAgency_Click(object sender, EventArgs e)
        {
            try
            {

                //DaiLi_DTO daili = new DaiLi_DTO();
                //daili.MaDL = dtgvAgencyInfoList.CurrentRow.Cells["MaDL"].Value.ToString();
                //daili.TenDL = txtNameAgency.Text;
                //daili.DiaChi = txtAddressOfAgency.Text;
                //daili.SoDT = txtNumberPhone.Text;
                //daili.TongNo = Convert.ToDouble(txtTotalDebtOfAgency.Text);
                //if (txtIDAgency.Text == "" || txtNameAgency.Text == "" || txtAddressOfAgency.Text == "" || txtNumberPhone.Text == "")
                //{
                //    XtraMessageBox.Show("Bạn phải chọn Đại lí cần sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    ClearDisplay();
                //    return;
                //}
                //if (DaiLi_BUS.SuaDaiLi(daili))
                //{
                //    XtraMessageBox.Show("Cập nhật Thông tin Đại lí thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    LoadListDaiLi();
                //    ClearDisplay();
                //    return;
                //}
            }
            catch
            {
                XtraMessageBox.Show("Cập nhật Thông tin Đại lí thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object iddmuc = (sender as GridView).GetRowCellValue(RowHandle, "iddmuc");
            object tendmuc = (sender as GridView).GetRowCellValue(RowHandle, "tendmuc");
            txtiddmuc.Text = iddmuc.ToString();
            txttendmuc.Text = tendmuc.ToString();
        }

        private void gridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtiddmuc.Text == "" && txttendmuc.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (txtiddmuc.Text == "" && txttendmuc.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(txtiddmuc.Text, out int txtiddmuca);
                var model = new DANHMUC_ViewModel
                {
                    iddmuc = txtiddmuca,
                    tendmuc = txttendmuc.Text,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog
                };
                var msg = new DANHMUCBll().AddDANHMUC(model);
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
            catch
            {
                XtraMessageBox.Show("", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txttendmuc.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txttendmuc.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var  result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtiddmuc.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn danh mục cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(txtiddmuc.Text, out int txtiddmuca);
                var msg = new DANHMUCBll().DeleteDANHMUC(txtiddmuca);
                LoadGrid();
                XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }
        #endregion

        #region Function
        async public void LoadGrid()
        {
            lstDANHMUC = await Task.Run(() => new DANHMUCBll().GetListDANHMUC());
            gridControl1.DataSource = lstDANHMUC;
            //txtiddmuc.Text = lstDANHMUC.LastOrDefault().iddmuc+1.ToString();
        }
        private void ClearDisplay()
        {
            txtiddmuc.Text = "";
            txttendmuc.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }
        #endregion
    }
}
