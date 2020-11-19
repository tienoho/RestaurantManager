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
    public partial class uctPYC : UserControl
    {
        List<NLIEU> lstNLIEU;
        public uctPYC()
        {
            InitializeComponent();
        }
        public static uctPYC uctDL = new uctPYC();
        private void uctPYC_Load(object sender, EventArgs e)
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idhang = (sender as GridView).GetRowCellValue(RowHandle, "idhang");
            object tenhang = (sender as GridView).GetRowCellValue(RowHandle, "tenhang");
            object slton = (sender as GridView).GetRowCellValue(RowHandle, "slton");
            object nguong = (sender as GridView).GetRowCellValue(RowHandle, "nguong");
            object dongianl = (sender as GridView).GetRowCellValue(RowHandle, "dongianl");
            txtid.Text = idhang.ToString();
            txttenhang.Text = tenhang.ToString();
            txtSLT.EditValue = slton;
            txtNguong.EditValue = nguong;
            nudDonGia2.EditValue = dongianl;
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
                    return;
                }
                if (txttenhang.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenhang.Focus();
                    return;
                }
                if (txtSLT.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập số lượng nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSLT.Focus();
                    return;
                }
                if (txtNguong.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập ngưỡng nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNguong.Focus();
                    return;
                }
                if (nudDonGia2.Text == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập đơn giá nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudDonGia2.Focus();
                    return;
                }
                int.TryParse(txtid.Text, out int id);
                int.TryParse(txtSLT.EditValue.ToString(), out int SLT);
                int.TryParse(txtNguong.EditValue.ToString(), out int Nguong);
                double.TryParse(nudDonGia2.EditValue.ToString(), out double DonGia);
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
            txtNguong.Enabled = true;
            nudDonGia2.Enabled = true;
            txtSLT.Enabled = true;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txttenhang.Enabled = true;
            txtNguong.Enabled = true;
            nudDonGia2.Enabled = true;
            txtSLT.Enabled = true;

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
            txtNguong.EditValue = 0;
            nudDonGia2.EditValue = 0;
            txtSLT.EditValue = 0;

            txttenhang.Enabled = false;
            txtNguong.Enabled = false;
            nudDonGia2.Enabled = false;
            txtSLT.Enabled = false;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }
        #endregion
    }
}
