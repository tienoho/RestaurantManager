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
using RestaurantManager.Bussiness;

namespace RestaurantManager
{

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        static public string NameLog;
        public static string UserName; bool hide = false;
        public frmLogin()
        {
            InitializeComponent();
            pictureEdit3.Click += new EventHandler(pictureEdit3_Click);
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            hide = !hide;
            if (hide == true)
            {
                this.txtPassword.Properties.PasswordChar = '\0';
            }
            else
            {
                this.txtPassword.Properties.PasswordChar = '*';
            }
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.user;
            txtPassword.Text = Properties.Settings.Default.password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == string.Empty || txtPassword.Text == string.Empty)
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        var checkLogin = new USERSBll().Login(txtUser.Text, txtPassword.Text);
                        UserName = txtUser.Text;
                        if (checkLogin != null)
                        {
                            if (checkSave.Checked)
                            {
                                Properties.Settings.Default.user = txtUser.Text;
                                Properties.Settings.Default.password = txtPassword.Text;
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                Properties.Settings.Default.user = "";
                                Properties.Settings.Default.password = "";
                                Properties.Settings.Default.Save();
                            }
                            XtraMessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Properties.Settings.Default.NameLog = txtUser.Text;
                            Properties.Settings.Default.PasswordLog = txtPassword.Text;
                            this.Hide();
                            frmMain main = new frmMain();
                            main.Show();

                            txtUser.Text = "";
                            txtPassword.Text = "";
                           // this.Show();

                        }
                        else
                        {
                            XtraMessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đăng nhập thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("Đăng nhập thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}