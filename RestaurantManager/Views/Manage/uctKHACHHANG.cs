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
    public partial class uctKHACHHANG : UserControl
    {
        List<KHACHHANG> lstKHACHHANG;
        public uctKHACHHANG()
        {
            InitializeComponent();
        }
        public static uctKHACHHANG uctDL = new uctKHACHHANG();


        private void uctKHACHHANG_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        #region Khách hàng
        private void LoadDataGrid()
        {
            LoadGrid();

        }

        #endregion

        #region Event
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idkh = (sender as GridView).GetRowCellValue(RowHandle, "idkh");
            object tenkh = (sender as GridView).GetRowCellValue(RowHandle, "tenkh");
            object sdt = (sender as GridView).GetRowCellValue(RowHandle, "sdt");
            txtidkh.Text = idkh.ToString();
            txttenkh.Text = tenkh.ToString();
            txtsdt.Text = sdt.ToString();
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
                if (txtidkh.Text == "" && txttenkh.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (txtidkh.Text == "" && txttenkh.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(txtidkh.Text, out int outidkh);
                var model = new KHACHHANG_ViewModel
                {
                    idkh = outidkh,
                    tenkh = txttenkh.Text,
                    sdt = txtsdt.Text,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog
                };
                var msg = new KHACHHANGBll().AddKHACHHANG(model);
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
            txttenkh.Enabled = true;
            txtsdt.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txttenkh.Enabled = true;
            txtsdt.Enabled = true;
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
                if (txtidkh.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn danh mục cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(txtidkh.Text, out int txtiddmuca);
                var msg = new KHACHHANGBll().DeleteKHACHHANG(txtiddmuca);
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
            lstKHACHHANG = await Task.Run(() => new KHACHHANGBll().GetListKHACHHANG());
            gridControl1.DataSource = lstKHACHHANG;
            //txtiddmuc.Text = lstDANHMUC.LastOrDefault().iddmuc+1.ToString();
        }
        private void ClearDisplay()
        {
            txtidkh.Text = "";
            txttenkh.Text = "";
            txtsdt.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }
        #endregion

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
