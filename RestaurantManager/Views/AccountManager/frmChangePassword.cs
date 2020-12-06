using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using RestaurantManager.Database;
using RestaurantManager.Model;
using RestaurantManager.Bussiness;

namespace RestaurantManager.Views.AccountManager
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        static public string NameLog = Properties.Settings.Default.NameLog;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == string.Empty || txtOldPass.Text == string.Empty || txtRegisPass.Text == string.Empty)
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (txtOldPass.Text != Properties.Settings.Default.PasswordLog) lbOld.Text = "Mật khẩu cũ không chính xác";
            else
                if (txtNewPass.Text != txtRegisPass.Text) return;
            else
                if (txtOldPass.Text == txtNewPass.Text) return;
            else
            {
                try
                {
                    string msg = "";
                    var USER = new USERSBll().ChangePassword(NameLog, txtNewPass.Text, ref msg);
                    if (msg == "success")
                    {
                        Properties.Settings.Default.PasswordLog = USER.Password;
                        XtraMessageBox.Show("Đổi mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRegisPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtRegisPass.Text)
            {
                lbNew.ForeColor = Color.Red;
                lbNew.Text = "Không khớp mật khẩu.";
            }
            else if (txtNewPass.Text == txtRegisPass.Text)
            {
                lbNew.Text = "Khớp mật khẩu.";
                lbNew.ForeColor = Color.Green;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtOldPass.Text) lbCheck.Text = "Không được trùng với mật khẩu cũ!";
            else
                lbCheck.Text = "";
            if (txtNewPass.Text != txtRegisPass.Text) lbNew.Text = "";
        }
    }
}