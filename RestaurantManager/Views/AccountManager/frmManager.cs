using DevExpress.XtraEditors;
using RestaurantManager.Database;
using RestaurantManager.Model;
using RestaurantManager.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.Views.AccountManager
{
    public partial class frmManager : Form
    {
        List<USER> lstUser = new List<USER>();
        public frmManager()
        {
            InitializeComponent();
        }
        private void frmManager_Load(object sender, EventArgs e)
        {
            loadChucVu();
            LoadData();

        }
        private void LoadData()
        {
            try
            {
                lstUser = new USERSBll().GetListUsers();
                gcUsers.DataSource = lstUser;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearDisplay();
        }
        private void ClearDisplay()
        {
            txtUser.Text = "";
            lueChucVu.Text = "";
            txtAddress.Text = "";
            txtNumberPhone.Text = "";
        }
        private void loadChucVu()
        {
            List<USER> lstChucVu = new List<USER>();
            USER chucvu = new USER();
            chucvu.ChucVu = "Admin";
            chucvu.MoTaChucVu = "Quản trị";
            lstChucVu.Add(chucvu);

            chucvu = new USER();
            chucvu.ChucVu = "THUKHO";
            chucvu.MoTaChucVu = "Quản lý đồ ăn";
            lstChucVu.Add(chucvu);

            chucvu = new USER();
            chucvu.ChucVu = "QLCHUNG";
            chucvu.MoTaChucVu = "Quản lý chung";
            lstChucVu.Add(chucvu);

            chucvu = new USER();
            chucvu.ChucVu = "PVKHACH";
            chucvu.MoTaChucVu = "Phục vụ khách";
            lstChucVu.Add(chucvu);

            chucvu = new USER();
            chucvu.ChucVu = "TTHOADON";
            chucvu.MoTaChucVu = "Thanh toán hóa đơn";
            lstChucVu.Add(chucvu);
            lueChucVu.Properties.DataSource = lstChucVu
                .Select(item => new
                {
                    item.ChucVu,
                    item.MoTaChucVu,
                }).ToList();
            lueChucVu.Properties.ValueMember = "ChucVu";
            lueChucVu.Properties.DisplayMember = "MoTaChucVu";
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txtPassword.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lueChucVu.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var user = new USER()
                {
                    UserName=txtUser.Text,
                    Password=txtPassword.Text,
                    ChucVu=lueChucVu.EditValue.ToString(),
                    MoTaChucVu= lueChucVu.Text,
                    ten=txtHoTen.Text,
                    DiaChi=txtAddress.Text,
                    SoDT=txtNumberPhone.Text,
                };

                string msg = "";
                var result = new USERSBll().saveUser(user,ref msg);

                XtraMessageBox.Show("Cập nhật thông tin tài khoản thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearDisplay();
                return;
            }
            catch(Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="")
            {
                XtraMessageBox.Show("Bạn chưa lụa chọn tên cần xóa ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            try
            {

                XtraMessageBox.Show("Xóa tài khoản thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearDisplay();
                return;
            }
            catch(Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txtPassword.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lueChucVu.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var user = new USER()
                {
                    UserName = txtUser.Text,
                    Password = txtPassword.Text,
                    ChucVu = lueChucVu.EditValue.ToString(),
                    MoTaChucVu = lueChucVu.Text,
                    ten = txtHoTen.Text,
                    DiaChi = txtAddress.Text,
                    SoDT = txtNumberPhone.Text,
                };

                string msg = "";
                var result = new USERSBll().saveUser(user, ref msg);

                XtraMessageBox.Show("Thêm khoản thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearDisplay();
                return;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}
