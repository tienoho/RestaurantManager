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
    public partial class frmPNhap : Form
    {
        List<NLIEU> lstnlieu;
        List<GIAOHANG_ViewModel> lstGIAOHANG_ViewModel;
        List<USER> lstUser_ViewModel;
        List<D_GIAOHANG_ViewModel> lstD_GIAOHANG_ViewModel = new List<D_GIAOHANG_ViewModel>();
        List<PNHAP_ViewModel> lstPNHAP_ViewModel = new List<PNHAP_ViewModel>();
        List<D_PNHAP_ViewModel> lstD_PNHAP_ViewModel = new List<D_PNHAP_ViewModel>();

        public frmPNhap()
        {
            InitializeComponent();
            luenlieu.Enabled = true;
            nslgiaohang.Enabled = true;
            nslnhanhang.Enabled = true;
            loadControls();
        }
        #region Function

        public void loadControls()
        {
            //hàng hóa
            lstnlieu = new NLIEUBll().GetListNLIEU();

            luenlieu.Properties.DataSource = lstnlieu
                 .Select(item => new
                 {
                     item.idhang,
                     item.tenhang,
                     item.slton,
                     item.nguong
                 }).ToList();
            luenlieu.Properties.ValueMember = "idhang";
            luenlieu.Properties.DisplayMember = "tenhang";

            //Load giaohang
            lstGIAOHANG_ViewModel = new GIAOHANGBll().GetListGIAOHANG();
            lueDONGIAO.Properties.DataSource = lstGIAOHANG_ViewModel
                 .Select(item => new
                 {
                     item.idpgiao,
                     item.ngaygiao,
                     item.nguoigiao,
                     item.nguoinhan,
                     item.diachi,
                 }).ToList();
            lueDONGIAO.Properties.ValueMember = "idpgiao";
            lueDONGIAO.Properties.DisplayMember = "idpgiao";
            string outmess = string.Empty;
            //thu kho
            lstUser_ViewModel = new USERSBll().GetUsersByPosition("THUKHO", Properties.Settings.Default.NameLog, ref outmess);
            if (outmess != "success")
            {
                XtraMessageBox.Show("Đã có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lueStorekeeper.Properties.DataSource = lstUser_ViewModel
                 .Select(item => new
                 {
                     item.id,
                     item.UserName,
                     item.ChucVu,
                     item.DiaChi,
                     item.SoDT
                 }).ToList();
            lueStorekeeper.Properties.ValueMember = "id";
            lueStorekeeper.Properties.DisplayMember = "UserName";

            //txtid
            txtid.Text = Utils.getNewId("PNHAP").ToString();
        }

        private void getDetailsGIAOHANG(int id)
        {
            try
            {
                string outmess = string.Empty;
                lstD_PNHAP_ViewModel = new List<D_PNHAP_ViewModel>();
                lstD_GIAOHANG_ViewModel = new PNHAPBll().GetLstDonGiao(id, ref outmess);
                foreach (var item in lstD_GIAOHANG_ViewModel)
                {
                    var temp = new D_PNHAP_ViewModel();
                    temp.idhang = item.idhang;
                    temp.tenhang = item.tenhang;
                    temp.slgiao = item.slgiaohang;
                    temp.slnhan = item.slnhanhang;
                    temp.CreateDate = item.CreateDate;
                    temp.CreateBy = item.CreateBy;
                    lstD_PNHAP_ViewModel.Add(temp);
                }
                gcD_DONMH.DataSource = null;
                gcD_DONMH.DataSource = lstD_PNHAP_ViewModel;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void luenlieu_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit editor = sender as LookUpEdit;
            object tenhang = editor.GetColumnValue("tenhang");
            txttenhang.Text = tenhang.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gcD_DONMH_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luenlieu_EditValueChanged_1(object sender, EventArgs e)
        {
            LookUpEdit editor = sender as LookUpEdit;
            object tenhang = editor.GetColumnValue("tenhang");
            txttenhang.Text = tenhang.ToString();
        }

        private void btnClearDetails_Click(object sender, EventArgs e)
        {
            clearFrm();
        }

        public void clearFrm()
        {
            nslgiaohang.Text = "0";
            nslnhanhang.Text = "0";
            txttenhang.Text = "";
            luenlieu.Text = "";
        }

        /// <summary>
        /// thêm
        /// </summary>
        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            //validate
            if (validateFrm())
            {
                //add
                int.TryParse(luenlieu.EditValue.ToString(), out int idhanghoa);
                int.TryParse(nslgiaohang.EditValue.ToString(), out int slgiao);
                int.TryParse(nslnhanhang.EditValue.ToString(), out int slnhap);
                var tenhang = txttenhang.Text;
                var idnhap = int.Parse(txtid.Text);

                var objDNHAP = new D_PNHAP_ViewModel
                {
                    idpnhap = idnhap,
                    idhang = idhanghoa,
                    tenhang = tenhang,
                    slgiao = slgiao,
                    slnhan = slnhap,
                    CreateBy = Properties.Settings.Default.NameLog,
                    CreateDate = DateTime.Now
                };

                //check trùng
                var check = lstD_PNHAP_ViewModel.FirstOrDefault(p => p.idhang == objDNHAP.idhang);
                if (check != null)
                {
                    XtraMessageBox.Show("Hàng hóa đã được chọn. Vui lòng sửa lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lstD_PNHAP_ViewModel.Add(objDNHAP);
                    gcD_DONMH.DataSource = null;
                    gcD_DONMH.DataSource = lstD_PNHAP_ViewModel;
                    clearFrm();
                }
            }
        }

        //validate
        public bool validateFrm()
        {
            int.TryParse(luenlieu.EditValue.ToString(), out int idhanghoa);
            int.TryParse(nslgiaohang.Text.ToString(), out int slgiao);
            double.TryParse(nslnhanhang.Text.ToString(), out double slnhap);

            if (luenlieu.Text == "" || luenlieu.Text == null || idhanghoa <= 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn mã hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (slgiao <= 0)
            {
                XtraMessageBox.Show("Số lượng giao phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (slnhap <= 0)
            {
                XtraMessageBox.Show("Số lượng nhập lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            var selects = gvD_NHAP.GetSelectedRows();
            var row = gvD_NHAP.GetRow(selects[0]);
            if (selects == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn hàng hóa để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var select = (D_DONMH_ViewModel)row;
                lstD_PNHAP_ViewModel = lstD_PNHAP_ViewModel.Where(p => p.idhang != select.idhang).ToList();
                gcD_DONMH.DataSource = lstD_PNHAP_ViewModel;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    int idpnhap = int.Parse(txtid.Text);
                    var ngaynhap = dtngaynhap.Value;
                    int.TryParse(lueDONGIAO.EditValue.ToString(), out int idgiaohang);
                    int.TryParse(lueStorekeeper.EditValue.ToString(), out int thukho);
                    string thukhoName = lueStorekeeper.Text;
                    string nguoigiao = txtNguoiGiao.Text;
                    string nguoinhap = txtNguoiNhan.Text;

                    if (ngaynhap == null)
                    {
                        XtraMessageBox.Show("Bạn chưa chọn ngày nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (lstD_PNHAP_ViewModel.Count == 0)
                    {
                        XtraMessageBox.Show("Bạn chưa nhập hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    if (lstD_PNHAP_ViewModel.Count() == 0)
                    {
                        XtraMessageBox.Show("Bạn chưa nhập hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var model = new PNHAP_ViewModel();
                    var nameLog = Properties.Settings.Default.NameLog; 
                    model.idpnhap = idpnhap;
                    model.idpgiao = idgiaohang;
                    model.ngaynhap = ngaynhap;
                    model.thukho = thukhoName;
                    model.nguoilapphieu = nameLog;
                    model.nguoigiao = nameLog;
                    var res = new PNHAPBll().savePNHAP(model, lstD_PNHAP_ViewModel, Properties.Settings.Default.NameLog);
                    if (res != "success")
                    {
                        XtraMessageBox.Show(res, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    XtraMessageBox.Show("Thêm phiếu giao hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lueDonMH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gcD_DONMH_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gvD_DONMH_DoubleClick;
        }

        private void gvD_DONMH_DoubleClick(object sender, EventArgs e)
        {
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idhang = (sender as GridView).GetRowCellValue(RowHandle, "idhang");
            object slmh = (sender as GridView).GetRowCellValue(RowHandle, "slmh");
            object slgiaohang = (sender as GridView).GetRowCellValue(RowHandle, "slgiaohang");

            luenlieu.EditValue = idhang;
            nslgiaohang.EditValue = slmh;
            nslnhanhang.EditValue = slgiaohang;
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            if (luenlieu.Text == "" || int.Parse(luenlieu.EditValue.ToString()) == 0)
            {
                XtraMessageBox.Show("Chưa chọn hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(luenlieu.EditValue.ToString(), out int idhang);
            int.TryParse(nslgiaohang.EditValue.ToString(), out int slgiao);//số lượng giao hàng
            int.TryParse(nslnhanhang.EditValue.ToString(), out int slnhanhang);
            if (slgiao <= 0)
            {
                XtraMessageBox.Show("Số lượng giao hàng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (slnhanhang <= 0)
            {
                XtraMessageBox.Show("Số lượng nhận hàng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (slnhanhang > slgiao)
            {
                XtraMessageBox.Show("Số lượng nhận hàng phải lớn hơn hoặc bằng số lượng giao hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var item = lstD_PNHAP_ViewModel.FirstOrDefault(x => x.idhang == idhang);
            if (item != null)
            {
                item.slgiao = slgiao;
                item.slnhan = slnhanhang;
            }
            gcD_DONMH.DataSource = null;
            gcD_DONMH.DataSource = lstD_PNHAP_ViewModel;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lueStorekeeper_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lueDONGIAO_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit editor = sender as LookUpEdit;
            object idpgiao = editor.GetColumnValue("idpgiao");
            string nguoigiao = editor.GetColumnValue("nguoigiao").ToString();
            txtNguoiGiao.Text = nguoigiao;

            int.TryParse(idpgiao.ToString(), out int id);
            getDetailsGIAOHANG(id);
        }
    }
}