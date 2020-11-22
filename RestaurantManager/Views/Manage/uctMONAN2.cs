using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using RestaurantManager.Properties;
using System.Web;
using System.Drawing.Imaging;
using DevExpress.XtraEditors;
using RestaurantManager.Database;
using RestaurantManager.Bussiness;
using DevExpress.XtraGrid.Views.Grid;
using RestaurantManager.Model;

namespace RestaurantManager
{
    public partial class uctMONAN2 : UserControl
    {
        private string imageLocation = "";
        private string imageName = "";
        private List<MONAN_ViewModel> lstMONAN;
        private List<CONGTHUC_ViewModel> lstCongThuc;
        private List<DANHMUC> lstDANHMUC;
        private List<NLIEU> lstNLIEU;
        public static uctMONAN2 uctMONAN = new uctMONAN2();
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public uctMONAN2()
        {
            InitializeComponent();
            lstDANHMUC = new DANHMUCBll().GetListDANHMUC();
            lstNLIEU = new NLIEUBll().GetListNLIEU();

        }

        private void uctMONAN2_Load(object sender, EventArgs e)
        {
            LoadGrid();
            loadDanhMuc();
            loadNLIEU();
        }

        #region Event
        private void gridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView1_DoubleClick_1;
        }
        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idmon = (sender as GridView).GetRowCellValue(RowHandle, "idmon");
            object temon = (sender as GridView).GetRowCellValue(RowHandle, "temon");
            object dongiamon = (sender as GridView).GetRowCellValue(RowHandle, "dongiamon");
            object dvt = (sender as GridView).GetRowCellValue(RowHandle, "dvt");
            object hinhanh = (sender as GridView).GetRowCellValue(RowHandle, "hinhanh");
            object iddmuc = (sender as GridView).GetRowCellValue(RowHandle, "iddmuc");
            textEditidmon.Text = idmon.ToString();
            textEditTenMon.Text = temon.ToString();
            textEditDonGia.Text = dongiamon.ToString();
            lueDanhMuc.EditValue = iddmuc;
            cbUnit.Text = dvt.ToString();

            try
            {
                if (hinhanh.ToString() == "" || hinhanh.ToString() == null)
                    pictureBox.Image = Resources.noimage;
                else
                    pictureBox.Image = Image.FromFile(path + "\\images\\" + hinhanh.ToString());
            }
            catch
            {
                pictureBox.Image = Resources.noimage;
            }
            LoadGridCONGTHUC((int)idmon);
            textEditIdMon_CongThuc.Text = idmon.ToString();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Title = "Chọn Picture";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFile.FileName;
                imageLocation = openFile.FileName.ToString();
                imageName = imageLocation.Substring(imageLocation.LastIndexOf("\\") + 1);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            textEditTenMon.Enabled = true;
            textEditDonGia.Enabled = true;
            cbUnit.Enabled = true;
            textEditDonGia.Enabled = true;
            lueDanhMuc.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearDisplay();
            ClearDisplay_CongThuc();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            textEditidmon.Text = "";
            textEditTenMon.Enabled = true;
            textEditDonGia.Enabled = true;
            cbUnit.Enabled = true;
            textEditDonGia.Enabled = true;
            lueDanhMuc.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (textEditidmon.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải chọn món cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(textEditidmon.Text, out int id);
                var msg = new MONANBll().DeleteMONAN(id);
                LoadGrid();
                XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay();
                return;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                var txtIdMon = textEditidmon.Text;
                var txtTenMon = textEditTenMon.EditValue.ToString();
                var txtDonGia = textEditDonGia.Text;
                var txtHinhAnh = imageLocation;
                var txtDonVi = cbUnit.Text;
                var txtDanhMuc = lueDanhMuc.Text;
                if (txtTenMon == "" && txtDonGia == "" && txtDonVi == "" && txtDanhMuc == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (txtTenMon == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (txtDonGia == "")
                {
                    XtraMessageBox.Show("Đơn giá phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (txtDonVi == "")
                {
                    XtraMessageBox.Show("Bạn chưa chọn đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                if (txtDanhMuc == "")
                {
                    XtraMessageBox.Show("Bạn chưa chọn danh mục món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(txtIdMon, out int idmon);
                double.TryParse(textEditDonGia.EditValue.ToString(), out double DonGia);
                var iddanhmuc = (int)lueDanhMuc.EditValue;

                if (imageName != "")
                {
                    var pathImage = path + "\\images\\" + imageName;

                    if (!File.Exists(pathImage))
                    {
                        System.IO.File.Copy(imageLocation, path + "\\images\\" + imageName);
                    }
                }
                var model = new MONAN_ViewModel
                {
                    idmon = idmon,
                    temon = txtTenMon,
                    dongiamon = DonGia,
                    dvt = txtDonVi,
                    hinhanh = imageName,
                    iddmuc = iddanhmuc,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog
                };
                var msg = new MONANBll().AddMONAN(model);
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
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        #endregion

        #region Function
        async public void LoadGrid()
        {
            lstMONAN = await Task.Run(() => new MONANBll().GetListMONAN());

            gridControl1.DataSource = lstMONAN;

        }
        private void loadDanhMuc()
        {
            lueDanhMuc.Properties.DataSource = lstDANHMUC
                .Select(item => new { iddmuc = item.iddmuc, tendmuc = item.tendmuc, }).ToList();
            lueDanhMuc.Properties.ValueMember = "iddmuc";
            lueDanhMuc.Properties.DisplayMember = "tendmuc";
        }
        private void loadNLIEU()
        {
            lookUpEditMaHang.Properties.DataSource = lstNLIEU
                .Select(item => new { idhang = item.idhang, tenhang = item.tenhang, }).ToList();
            lookUpEditMaHang.Properties.ValueMember = "idhang";
            lookUpEditMaHang.Properties.DisplayMember = "tenhang";
        }
        private void ClearDisplay()
        {
            imageLocation = "";
            imageName = "";
            textEditidmon.Text = "";
            textEditTenMon.Text = "";
            textEditDonGia.EditValue = 0;
            pictureBox.Image = Resources.noimage;

            textEditTenMon.Enabled = false;
            textEditDonGia.Enabled = false;
            cbUnit.Enabled = false;
            textEditDonGia.Enabled = false;
            lueDanhMuc.Enabled = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

        }
        #endregion

        #region Công thức
        private void btnAdd_CongThuc_Click(object sender, EventArgs e)
        {
            btnAdd_CongThuc.Enabled = false;
            btnUpdate_CongThuc.Enabled = false;
            btnSave_CongThuc.Enabled = true;
            btnDelete_CongThuc.Enabled = false;

            textEditHamLuong.Enabled = true;
            lookUpEditMaHang.Enabled = true;
        }

        private void btnUpdate_CongThuc_Click(object sender, EventArgs e)
        {
            btnAdd_CongThuc.Enabled = false;
            btnUpdate_CongThuc.Enabled = false;
            btnSave_CongThuc.Enabled = true;
            btnDelete_CongThuc.Enabled = false;

            textEditHamLuong.Enabled = true;
            lookUpEditMaHang.Enabled = true;
        }

        private void btnClear_CongThuc_Click(object sender, EventArgs e)
        {
            ClearDisplay_CongThuc();
        }

        private void btnSave_CongThuc_Click(object sender, EventArgs e)
        {

            try
            {
                var txtIdMon = textEditIdMon_CongThuc.Text;
                var txtHamLuong = textEditHamLuong.Text;
                var txtMaHang = lookUpEditMaHang.Text;

                if (txtIdMon == "" && txtHamLuong == "" && txtMaHang == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay_CongThuc();
                    return;
                }
                if (txtIdMon == "")
                {
                    XtraMessageBox.Show("Bạn chưa chọn món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay_CongThuc();
                    return;
                }
                if (txtHamLuong == "")
                {
                    XtraMessageBox.Show("Bạn phải nhập hàm lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay_CongThuc();
                    return;
                }
                if (txtMaHang == "")
                {
                    XtraMessageBox.Show("Bạn chưa chọn mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay_CongThuc();
                    return;
                }

                int.TryParse(txtIdMon, out int idmon);
                int.TryParse(lookUpEditMaHang.EditValue.ToString(), out int idmahang);

                var model = new CONGTHUC_ViewModel
                {
                    idmon = idmon,
                    idhang = idmahang,
                    hamluong = txtHamLuong,
                    CreateBy = Properties.Settings.Default.NameLog,
                    ModifyBy = Properties.Settings.Default.NameLog
                };
                var msg = new CONGTHUCBll().AddCONGTHUC(model);
                if (msg != null && msg != "")
                {
                    LoadGridCONGTHUC(idmon);
                    XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDisplay();
                    return;
                }
                XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearDisplay_CongThuc();
                return;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDelete_CongThuc_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (textEditIdMon_CongThuc.Text == "" && lookUpEditMaHang.Text == "")
                {
                    XtraMessageBox.Show("Bạn phải công thức cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearDisplay();
                    return;
                }
                int.TryParse(textEditidmon.Text, out int idmon);
                int.TryParse(lookUpEditMaHang.EditValue.ToString(), out int idhang);
                var msg = new CONGTHUCBll().DeleteCONGTHUC(idmon, idhang);
                LoadGridCONGTHUC(idmon);
                XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDisplay_CongThuc();
                return;
            }

        }

        private void ClearDisplay_CongThuc()
        {
            btnAdd_CongThuc.Enabled = true;
            btnUpdate_CongThuc.Enabled = true;
            btnSave_CongThuc.Enabled = false;
            btnDelete_CongThuc.Enabled = true;

            textEditHamLuong.Enabled = false;
            lookUpEditMaHang.Enabled = false;

            textEditHamLuong.EditValue = null;
            lookUpEditMaHang.EditValue = null;
        }


        async public void LoadGridCONGTHUC(int idmon)
        {
            lstCongThuc = await Task.Run(() => new CONGTHUCBll().GetListCONGTHUC(idmon));

            gridControlCONGTHUC.DataSource = lstCongThuc;

        }
        #endregion

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            int RowHandle = (sender as GridView).FocusedRowHandle;
            object idhang = (sender as GridView).GetRowCellValue(RowHandle, "idhang");
            object hamluong = (sender as GridView).GetRowCellValue(RowHandle, "hamluong");

            lookUpEditMaHang.EditValue = idhang;
            textEditHamLuong.EditValue = hamluong;
        }

        private void gridControlCONGTHUC_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            if (e.View.IsDetailView == false)
                return;

            (e.View as GridView).DoubleClick += gridView2_DoubleClick;
        }
    }
}