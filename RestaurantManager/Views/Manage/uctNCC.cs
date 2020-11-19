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
    public partial class uctNCC : UserControl
    {
        List<NCC_ViewModel> lstNCC;
        public uctNCC()
        {
            InitializeComponent();
        }
        public static uctNCC uctDL = new uctNCC();


        private void uctNCC_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        #region Danh mục NCC
        private void LoadDataGrid()
        {
            LoadGrid();

        }


        #endregion

        #region Event
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtstk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
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
            txtidncc.Text = idncc.ToString();
            txttenncc.Text = tenncc.ToString();
            txtdiachi.Text = diachi.ToString();
            txtsdt.Text = sdt.ToString();
            txtstk.Text = stk.ToString();
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
                if (txtidncc.Text == "" && txttenncc.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (txttenncc.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenncc.Focus();
                    return;
                }
                int.TryParse(txtidncc.Text, out int idncc);
                var model = new NCC_ViewModel
                {
                    idncc = idncc,
                    tenncc = txttenncc.Text,
                    diachi = txtdiachi.Text,
                    sdt = txtsdt.Text,
                    stk = txtstk.Text,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog
                };
                var msg = new NCCBll().AddNCC(model);
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
            txtidncc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtstk.Text = "";

            txttenncc.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;
            txtstk.Enabled = true;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txttenncc.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;
            txtstk.Enabled = true;

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
                if (txtidncc.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn danh mục cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(txtidncc.Text, out int txtiddmuca);
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
            lstNCC = await Task.Run(() => new NCCBll().GetListNCC());
            gridControl1.DataSource = lstNCC;
            //txtiddmuc.Text = lstDANHMUC.LastOrDefault().iddmuc+1.ToString();
        }
        private void ClearDisplay()
        {
            txtidncc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtstk.Text = "";

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }
        #endregion

        
    }
}
