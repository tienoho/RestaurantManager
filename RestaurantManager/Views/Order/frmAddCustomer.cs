using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using RestaurantManager.Bussiness;
using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.Views.Order
{
    public partial class frmAddCustomer : Form
    {
        List<KHACHHANG> lstKHACHHANG;
        public frmAddCustomer()
        {
            InitializeComponent();
            loadControls();
        }

        public void loadControls()
        {
            //Danh sách khách hàng
            lstKHACHHANG = new KHACHHANGBll().GetListKHACHHANG();
            gridControl1.DataSource = lstKHACHHANG;
            //txtid
            txtidkh.Text = Utils.getNewId("KHACHHANG").ToString();
            txtsdt.Text = "";
            txttenkh.Text = "";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
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
            LoadGrid();
        }
        #endregion

        private void gridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;
            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
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

        private void frmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnClearDetails_Click_1(object sender, EventArgs e)
        {
            ClearDisplay();
        }
    }
}