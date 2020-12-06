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
    public partial class frmPYC_Detail : Form
    {
        List<NLIEU> lstNLIEU;
        PYC objPYC;
        List<D_PYC_ViewModel> lstD_PYC = new List<D_PYC_ViewModel>();
        int idpyc = 0;
        string saveMessage = "Bạn có chắc chắn muốn thêm phiếu yêu cầu?";
        string nofMessage = "Tạo phiếu yêu cầu thành công";
        string errorMessage = "Tạo phiếu yêu cầu không thành công !";

        public frmPYC_Detail(int idpyc = 0)
        {
            InitializeComponent();
            lstNLIEU = new NLIEUBll().GetListNLIEU();
            loadNLIEU();
            this.idpyc = idpyc;
            if (this.idpyc > 0)
            {
                LoadPYC(idpyc);
                saveMessage = "Bạn có chắc chắn muốn cập nhật phiếu yêu cầu?";
                nofMessage = "Cập nhật phiếu yêu cầu thành công";
                errorMessage = "Cập nhật phiếu yêu cầu không thành công !";
            }
            //LoadGrid();
        }
        public void LoadPYC(int idpyc)
        {
            objPYC = new PYCBll().GetPYC(idpyc);
            dtpnyc.Value = objPYC.ngayyc;
            txtid.Text = objPYC.idyc.ToString();
            LoadGridDetails(idpyc);
        }
       public void LoadGridDetails(int idyc)
        {
            lstD_PYC = new PYCBll().GetListD_PYC(idyc);
            gcPYCDetails.DataSource = lstD_PYC;
            gvPYCDetails.RefreshData();
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
            // btnSavePYC.Enabled = true;
            gcPYCDetails.DataSource = null;
            //LoadGrid();
        }
        public void ClearDetails()
        {
            btnUpdateDetails.Enabled = true;
            btnAddDetails.Enabled = true;
            btnDeleteDetails.Enabled = true;
            lueNLieu.EditValue = null;
            txtslton.EditValue = 0;
            txtsldukien.EditValue = 0;
            txtnguong.EditValue = 0;
            txtsldukien.EditValue = 0;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstD_PYC.Count <= 0)
            {
                XtraMessageBox.Show("Bạn phải thêm nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = XtraMessageBox.Show(saveMessage, "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var ngayyc = dtpnyc.Value;
                var pyc = new PYC
                {
                    idyc = this.idpyc,
                    ngayyc = ngayyc,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now
                };

                var resultObj = new PYCBll().SavePYC(pyc, lstD_PYC, Properties.Settings.Default.NameLog);
                if (resultObj == "success")
                {
                    XtraMessageBox.Show(nofMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    this.Close();
                    return;
                }
                else
                {
                    XtraMessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

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

        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            
            if (lueNLieu.EditValue == null)
            {
                XtraMessageBox.Show("Bạn phải chọn nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay();
                return;
            }

            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //int.TryParse(txtid.Text, out int id);
                var idhang = (int)lueNLieu.EditValue;
                lstD_PYC.Remove(lstD_PYC.Find(x => x.idhang == idhang));
                gcPYCDetails.DataSource = lstD_PYC;
                gvPYCDetails.RefreshData();

                //var msg = new PYCBll().DeleteD_PYC(id, (int)idhang);
                // LoadGrid();
                //XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
                var result = XtraMessageBox.Show("Bạn có chắc chắn muốn cập nhật ?", "Xác nhận", MessageBoxButtons.YesNo);
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

        private void btnClearDetails_Click(object sender, EventArgs e)
        {

        }

        private void gvPYCDetails_DoubleClick(object sender, EventArgs e)
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

        private void gcPYCDetails_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;
            (e.View as GridView).DoubleClick += gvPYCDetails_DoubleClick;
        }

        private void lueNLieu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}