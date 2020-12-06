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
    public partial class uctCreate_PYC : UserControl
    {
        List<NLIEU> lstNLIEU;
        List<PYC_ViewModel> lstPYC;
        List<D_PYC_ViewModel> lstD_PYC = new List<D_PYC_ViewModel>();
        public uctCreate_PYC()
        {
            InitializeComponent();
            lstNLIEU = new NLIEUBll().GetListNLIEU();
            LoadGrid();
        }
        public static uctCreate_PYC uctDL = new uctCreate_PYC();
        private void uctCreate_PYC_Load(object sender, EventArgs e)
        {
            loadNLIEU();
        }

        #region Nguyên liêu

        #endregion
        #region Event
        private void gcPYC_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gvPYC_DoubleClick;
        }
        private void gvPYC_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idyc = (sender as GridView).GetRowCellValue(RowHandle, "idyc");
            object ngayyc = (sender as GridView).GetRowCellValue(RowHandle, "ngayyc");
            txtid.Text = idyc.ToString();
            dtpnyc.Value = (DateTime)ngayyc;


            LoadGridDetails((int)idyc);


            btnSavePYC.Enabled = false;

            btnAddDetails.Enabled = true;
            lueNLieu.Enabled = true;
            txtsldukien.Enabled = true;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Determine row in event handler  
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idhang = (sender as GridView).GetRowCellValue(RowHandle, "idhang");
            object tenhang = (sender as GridView).GetRowCellValue(RowHandle, "tenhang");
            object slton = (sender as GridView).GetRowCellValue(RowHandle, "slton");
            object nguong = (sender as GridView).GetRowCellValue(RowHandle, "nguong");
            object sldukien = (sender as GridView).GetRowCellValue(RowHandle, "sldukien");

            lueNLieu.EditValue = idhang;
            txtslton.EditValue = slton;
            txtnguong.EditValue = nguong;
            txtsldukien.EditValue = sldukien;

            btnUpdateDetails.Enabled = true;
            btnAddDetails.Enabled = false;
            btnDeleteDetails.Enabled = true;
        }

        private void gridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick;
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm phiếu yêu cầu?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var ngayyc = dtpnyc.Value;
                var pyc = new PYC
                {
                    ngayyc = ngayyc,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now
                };
                var resultObj = new PYCBll().AddPYC(pyc);
                if (resultObj != null)
                {
                    XtraMessageBox.Show("Tạo phiếu yêu cầu không thành công, vui lòng thêm hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtid.Text = resultObj.idyc.ToString();
                    dtpnyc.Value = resultObj.ngayyc;
                    dtpnyc.Enabled = false;
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Tạo phiếu yêu cầu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnDeletddde_Click(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearDisplay();
        }
        #endregion

        #region Function
        async public void LoadGrid()
        {
            lstPYC = await Task.Run(() => new PYCBll().GetListPYC());
            gcPYC.DataSource = lstPYC;
        }
        private void loadNLIEU()
        {
            lueNLieu.Properties.DataSource = lstNLIEU
                .Select(item => new
                {
                    item.idhang,
                    item.tenhang,
                    item.slton,
                    item.nguong
                }).ToList();
            lueNLieu.Properties.ValueMember = "idhang";
            lueNLieu.Properties.DisplayMember = "tenhang";
        }
        private void ClearDisplay()
        {
            txtid.Text = "";
            dtpnyc.Value = DateTime.Now;
            dtpnyc.Enabled = true;
            btnSavePYC.Enabled = true;
            gcPYCDetails.DataSource = null;
            LoadGrid();
        }

        #endregion

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            var s_idyc = txtid.Text;
            int.TryParse(s_idyc, out int idyc);

            if (lueNLieu.Text == "" || lueNLieu.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtsldukien.Text == "" || txtsldukien.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập số lượng dự kiến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtslton.Text == "" || txtslton.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập số lượng tồn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtnguong.Text == "" || txtnguong.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập ngưỡng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(lueNLieu.EditValue.ToString(), out int idhang);

            int.TryParse(txtsldukien.EditValue.ToString(), out int sldukien);
            int.TryParse(txtslton.EditValue.ToString(), out int slton);
            int.TryParse(txtnguong.EditValue.ToString(), out int nguong);

            if (sldukien <= 0)
            {
                XtraMessageBox.Show("Số lương dự kiến phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstD_PYC.Find(x => x.idhang == idhang) != null)
            {
                XtraMessageBox.Show("Hàng hóa này đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var ngayyc = dtpnyc.Value;
                var d_pyc = new D_PYC_ViewModel
                {
                    idyc = idyc,
                    idhang = idhang,
                    tenhang = lueNLieu.Text,
                    sldukien = sldukien,
                    slton = slton,
                    nguong = nguong,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now
                };
                //
                lstD_PYC.Add(d_pyc);
            }
            gcPYCDetails.DataSource = lstD_PYC;
            gvPYCDetails.RefreshData();
            ClearDetails();
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            var s_idyc = txtid.Text;
            int.TryParse(s_idyc, out int idyc);
            int.TryParse(lueNLieu.EditValue.ToString(), out int idhang);
            int.TryParse(txtsldukien.EditValue.ToString(), out int sldukien);
            int.TryParse(txtslton.EditValue.ToString(), out int slton);
            int.TryParse(txtnguong.EditValue.ToString(), out int nguong);
            if (lueNLieu.Text == null || idhang <= 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sldukien <= 0)
            {
                XtraMessageBox.Show("Số lương dự kiến phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var item = lstD_PYC.FirstOrDefault(x => x.idhang == idhang);
            if (item != null)
            {
                var result = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    item.sldukien = sldukien;
                    item.slton = slton;
                    item.nguong = nguong;
                }
            }
            gcPYCDetails.DataSource = lstD_PYC;
            gvPYCDetails.RefreshData();
            ClearDetails();
        }

        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                XtraMessageBox.Show("Bạn phải chọn phiếu yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }
            if (lueNLieu.EditValue == null)
            {
                XtraMessageBox.Show("Bạn phải chọn nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }

            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int.TryParse(txtid.Text, out int id);
                var idhang = lueNLieu.EditValue;
                var msg = new PYCBll().DeleteD_PYC(id, (int)idhang);
                LoadGrid();
                XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void lueNLieu_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit editor = sender as LookUpEdit;
            object idhang = editor.GetColumnValue("idhang");
            object tenhang = editor.GetColumnValue("tenhang");
            object slton = editor.GetColumnValue("slton");
            object nguong = editor.GetColumnValue("nguong");
            txtslton.EditValue = slton;
            txtnguong.EditValue = nguong;
        }

        async public void LoadGridDetails(int idyc)
        {
            lstD_PYC = await Task.Run(() => new PYCBll().GetListD_PYC(idyc));
            gcPYCDetails.DataSource = lstD_PYC;
        }

        private void btnClearDetails_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }
        public void ClearDetails()
        {
            btnUpdateDetails.Enabled = true;
            btnAddDetails.Enabled = true;
            btnDeleteDetails.Enabled = true;
            lueNLieu.EditValue = null;
            txtsldukien.EditValue = 0;
            txtnguong.EditValue = 0;
            txtsldukien.EditValue = 0;
        }

        private void btnSavePYC_Click(object sender, EventArgs e)
        {
            if (lstD_PYC.Count <= 0)
            {
                XtraMessageBox.Show("Bạn phải thêm nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn thêm phiếu yêu cầu?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var ngayyc = dtpnyc.Value;
                var pyc = new PYC
                {
                    ngayyc = ngayyc,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now
                };

                var resultObj = new PYCBll().SavePYC(pyc, lstD_PYC, Properties.Settings.Default.NameLog);
                if (resultObj == "success")
                {
                    XtraMessageBox.Show("Tạo phiếu yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Tạo phiếu yêu cầu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
