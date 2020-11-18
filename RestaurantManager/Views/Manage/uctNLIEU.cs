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
    public partial class uctNLIEU : UserControl
    {
        List<NLIEU> lstNLIEU;
        public uctNLIEU()
        {
            InitializeComponent();
        }
        public static uctNLIEU uctDL = new uctNLIEU();
        private void uctNLIEU_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        #region Nguyên liêu
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
            txtid.Text = iddmuc.ToString();
            txttenhang.Text = tendmuc.ToString();
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
                if (txtid.Text == "" && txttenhang.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (txtid.Text == "" && txttenhang.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(txtid.Text, out int id);
                int.TryParse(nudSLT.Text, out int SLT);
                int.TryParse(nudNguong.Text, out int Nguong);
                double.TryParse(nudDonGia.Text, out double DonGia);
                var model = new NLIEU_ViewModel
                {
                    idhang = id,
                    tenhang = txttenhang.Text,
                    slton = SLT,
                    nguong = Nguong,
                    dongianl = DonGia,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog
                };
                var msg = new NLIEUBll().AddNLIEU(model);
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
            txttenhang.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txttenhang.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn nguyên liệu cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(txtid.Text, out int id);
                var msg = new NLIEUBll().DeleteNLIEU(id);
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
            lstNLIEU = await Task.Run(() => new NLIEUBll().GetListNLIEU());
            gridControl1.DataSource = lstNLIEU;
            //txtiddmuc.Text = lstDANHMUC.LastOrDefault().iddmuc+1.ToString();
        }
        private void ClearDisplay()
        {
            txtid.Text = "";
            txttenhang.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }
        #endregion
    }
}
