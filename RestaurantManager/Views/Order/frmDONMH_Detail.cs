﻿using DevExpress.XtraEditors;
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
    public partial class frmDONMH_Detail : Form
    {
        List<NCC_ViewModel> lstncc;
        List<NLIEU> lstnlieu;
        List<D_DONMH_ViewModel> lstD_DONMH_ViewModel = new List<D_DONMH_ViewModel>();
        public frmDONMH_Detail()
        {
            InitializeComponent();
            luencc.Enabled = true;
            luenlieu.Enabled = true;
            nslmh.Enabled = true;
            ndongiamh.Enabled = true;
            loadControls();
        }

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

            //txtid
            txtid.Text = new DONMHBll().getNewIdDONMH();
        }

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
            nslmh.Text = "0";
            ndongiamh.Text = "0";
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
                int.TryParse(nslmh.EditValue.ToString(), out int slmh);
                int.TryParse(ndongiamh.EditValue.ToString(), out int dongiamh);
                var ngaydonmh = dtngaydonmh.Value;
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
            int.TryParse(nslmh.Text.ToString(), out int slmh);
            double.TryParse(ndongiamh.Text.ToString(), out double dongiamh);

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
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var select = (D_DONMH_ViewModel)row;
                lstD_DONMH_ViewModel = lstD_DONMH_ViewModel.Where(p => p.idhang != select.idhang).ToList();
                gcD_DONMH.DataSource = lstD_DONMH_ViewModel;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //validate
            int iddonmh = int.Parse(txtid.Text);
            var ngaydonmh = dtngaydonmh.Value;
            int.TryParse(luencc.EditValue.ToString(), out int idncc);
            if (ngaydonmh == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày mua hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstD_DONMH_ViewModel.Count == 0)
            {
                XtraMessageBox.Show("Bạn chưa nhập hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var obj = new DONMH_ViewModel()
            {
                iddonmh = iddonmh,
                idncc = idncc,
                ngaydonmh = ngaydonmh
            };

            var res = new DONMHBll().saveDONMH(obj, lstD_DONMH_ViewModel, Properties.Settings.Default.NameLog);
            if (res != "success")
            {
                XtraMessageBox.Show(res, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            XtraMessageBox.Show("Thêm mới đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            //uctDONMH uctDONMH = new uctDONMH();
            //uctDONMH.LoadGrid();
            
        }

        private void gvD_DONMH_RowClick_1(object sender, RowClickEventArgs e)
        {
            var idhanghoa = (sender as GridView).GetFocusedRowCellValue("idhang");
            var tenhang = (sender as GridView).GetFocusedRowCellValue("tenhang");
            var slmh = (sender as GridView).GetFocusedRowCellValue("slmh");
            var dongiamh = (sender as GridView).GetFocusedRowCellValue("dongiamh");
            luenlieu.Text = tenhang.ToString();
            luenlieu.EditValue = idhanghoa;
            txttenhang.Text = tenhang.ToString();
            nslmh.Text = slmh.ToString();
            ndongiamh.Text = dongiamh.ToString();
        }

        private void btnUpdateDetails_Click_1(object sender, EventArgs e)
        {
            int.TryParse(luenlieu.EditValue.ToString(), out int idhanghoa);
            int.TryParse(nslmh.Text.ToString(), out int slmh);
            double.TryParse(ndongiamh.Text.ToString(), out double dongiamh);

            var sl = lstD_DONMH_ViewModel.FirstOrDefault(p => p.idhang == idhanghoa);
            if (sl == null)
            {
                XtraMessageBox.Show("Hàng hóa chưa có trong chi tiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (validateFrm())
            {
                //remove đi add lại
                lstD_DONMH_ViewModel.Remove(sl);
                sl.slmh = slmh;
                sl.dongiamh = dongiamh;
                sl.totalamount = slmh * dongiamh;
                lstD_DONMH_ViewModel.Add(sl);
                gcD_DONMH.DataSource = null;
                gcD_DONMH.DataSource = lstD_DONMH_ViewModel;
            }
        }
    }
}