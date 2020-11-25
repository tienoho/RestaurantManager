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
    public partial class frmHOADONM_Detail : Form
    {
        List<NCC_ViewModel> lstncc;
        List<NLIEU> lstnlieu;
        List<DONMH_ViewModel> lstDONMH_ViewModel;
        List<D_DONMH_ViewModel> lstD_DONMH_ViewModel = new List<D_DONMH_ViewModel>();

        public frmHOADONM_Detail()
        {
            InitializeComponent();
            luencc.Enabled = false;
            luenlieu.Enabled = false;
            nslgiaohang.Enabled = true;
            nslnhanhang.Enabled = true;
            loadControls();
        }
        #region Function

        public void loadControls()
        {
            //ncc
            lstncc = new NCCBll().GetListNCC();

            luencc.Properties.DataSource = lstncc
                .Select(item => new
                {
                    item.idncc,
                    item.tenncc,
                    item.sdt,
                    item.stk,
                    item.diachi
                }).ToList();
            luencc.Properties.ValueMember = "idncc";
            luencc.Properties.DisplayMember = "tenncc";

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


            //Load DonMH
            lstDONMH_ViewModel = new DONMHBll().GetListDONMH();
            lueDonMH.Properties.DataSource = lstDONMH_ViewModel
                 .Select(item => new
                 {
                     item.iddonmh,
                     item.idncc,
                     item.tenncc,
                     item.ngaydonmh
                 }).ToList();
            lueDonMH.Properties.ValueMember = "iddonmh";
            lueDonMH.Properties.DisplayMember = "iddonmh";

            //txtid
            txtid.Text = Utils.getNewId("GIAOHANG").ToString();
        }

        private void getDetailsDONMH(int id)
        {
            try
            {
                lstD_DONMH_ViewModel = new DONMHBll().GetListD_DONMH(id);
                gcD_DONMH.DataSource = lstD_DONMH_ViewModel;
                gvD_DONMH.RefreshData();
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
                int.TryParse(nslgiaohang.EditValue.ToString(), out int slmh);
                int.TryParse(nslnhanhang.EditValue.ToString(), out int dongiamh);
                var ngaydonmh = dtngaygiao.Value;
                var tenhang = txttenhang.Text;
                var iddonmh = int.Parse(txtid.Text);

                var d_donmh = new D_DONMH_ViewModel
                {
                    iddonmh = iddonmh,
                    idhang = idhanghoa,
                    tenhang = tenhang,
                    slmh = slmh,
                    dongiamh = dongiamh,
                    totalamount = slmh * dongiamh,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now
                };

                //check trùng
                var check = lstD_DONMH_ViewModel.FirstOrDefault(p => p.idhang == d_donmh.idhang);
                if (check != null)
                {
                    XtraMessageBox.Show("Hàng hóa đã được chọn. Vui lòng sửa lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lstD_DONMH_ViewModel.Add(d_donmh);
                    gcD_DONMH.DataSource = null;
                    gcD_DONMH.DataSource = lstD_DONMH_ViewModel;
                    clearFrm();
                }
            }
        }

        //validate
        public bool validateFrm()
        {
            int.TryParse(luenlieu.EditValue.ToString(), out int idhanghoa);
            int.TryParse(nslgiaohang.Text.ToString(), out int slmh);
            double.TryParse(nslnhanhang.Text.ToString(), out double dongiamh);

            if (luenlieu.Text == "" || luenlieu.Text == null || idhanghoa <= 0)
            {
                XtraMessageBox.Show("Bạn chưa chọn mã hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (slmh <= 0)
            {
                XtraMessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dongiamh <= 0)
            {
                XtraMessageBox.Show("Đơn giá phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            var selects = gvD_DONMH.GetSelectedRows();
            var row = gvD_DONMH.GetRow(selects[0]);
            if (selects == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn hàng hóa để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var select = (D_DONMH_ViewModel)row;
            lstD_DONMH_ViewModel = lstD_DONMH_ViewModel.Where(p => p.iddonmh != select.iddonmh).ToList();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idpgiao = int.Parse(txtid.Text);
                var ngaygiao = dtngaygiao.Value;
                int.TryParse(luencc.EditValue.ToString(), out int idncc);
                int.TryParse(lueDonMH.EditValue.ToString(), out int iddonmh);
                if (ngaygiao == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn ngày mua hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (lstD_DONMH_ViewModel.Count == 0)
                {
                    XtraMessageBox.Show("Bạn chưa nhập hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var model = new GIAOHANG_ViewModel()
                {
                    idpgiao = idpgiao,
                    iddonmh = iddonmh,
                    idncc = idncc,
                    ngaygiao = dtngaygiao.Value,
                    nguoigiao = txtNguoiGiao.Text,
                    nguoilapphieu = Properties.Settings.Default.NameLog,
                    nguoinhan = txtNguoiNhan.Text,
                    cuahang = txtCuaHang.Text,
                    diachi = txtCuaHang.Text,
                };
                var lstD_GIAOHANG = new List<D_GIAOHANG_ViewModel>();
                foreach (var item in lstD_DONMH_ViewModel)
                {
                    var detail = new D_GIAOHANG_ViewModel
                    {
                        idhang = item.idhang,
                        idpgiao = model.idpgiao,
                        slgiaohang = item.slmh,
                        slnhanhang = item.slnhanhang
                    };

                    lstD_GIAOHANG.Add(detail);
                }
                var res = new GIAOHANGBll().AddGIAOHANG(model, lstD_GIAOHANG, Properties.Settings.Default.NameLog);
                if (res != "success")
                {
                    XtraMessageBox.Show(res, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                XtraMessageBox.Show("Thêm phiếu giao hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lueDonMH_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit editor = sender as LookUpEdit;
            object iddonmh = editor.GetColumnValue("iddonmh");
            object idncc = editor.GetColumnValue("idncc");
            luencc.EditValue = idncc;

            int.TryParse(iddonmh.ToString(), out int id);
            getDetailsDONMH(id);


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
            int.TryParse(nslgiaohang.EditValue.ToString(), out int slmh);//số lượng giao hàng
            int.TryParse(nslnhanhang.EditValue.ToString(), out int slnhanhang);
            if (slmh <= 0)
            {
                XtraMessageBox.Show("Số lượng giao hàng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (slnhanhang <= 0)
            {
                XtraMessageBox.Show("Số lượng nhận hàng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (slnhanhang > slmh)
            {
                XtraMessageBox.Show("Số lượng nhận hàng phải lớn hơn hoặc bằng số lượng giao hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var item = lstD_DONMH_ViewModel.FirstOrDefault(x => x.idhang == idhang);
            if (item != null)
            {
                item.slmh = slmh;
                item.slnhanhang = slnhanhang;
            }
            gcD_DONMH.DataSource = lstD_DONMH_ViewModel;
            gvD_DONMH.RefreshData();

        }
    }
}