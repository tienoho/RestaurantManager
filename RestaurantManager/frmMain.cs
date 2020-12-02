﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Threading;
using DevExpress.XtraSplashScreen;
using RestaurantManager.Bussiness;

namespace RestaurantManager
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            var list = new DONDATDABll().GetOuterOrder();
            btnOrderWait.Caption = String.Format("Chờ thanh toán ({0})", list.Count());
            addTabPages(uctWelcome.uctDL, 17, "Welcome");
        }

        internal static List<byte> typePages = new List<byte>();
        public void addTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            // Kiểm tra tồn tại trang này chưa
            for (int i = 0; i < tabDisplay.TabPages.Count; i++)
            {
                if (tabDisplay.TabPages[i].Contains(uct) == true)
                {
                    tabDisplay.SelectedTab = tabDisplay.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;

            tab.Size = tabDisplay.Size;
            tab.Text = tenTab + "   ";
            tabDisplay.TabPages.Add(tab);
            tabDisplay.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        // Đóng tab hiện tại
        public void CloseTabDisplayCurrent()
        {
            tabDisplay.TabPages.Remove(tabDisplay.SelectedTab);
        }
        // Đóng tất cả các Tab
        public void CloseAllTab()
        {
            while (tabDisplay.TabPages.Count > 0)
            {
                CloseTabDisplayCurrent();
            }
            //tabDisplay.TabPages.Clear();
        }
        private void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
        }
        private void btnInfoAgency_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnProductOfAgency_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            //addTabPages(uctSanPhamDL.uctSPDL,30, "Sản Phẩm Đại Lí");
        }

        private void btnInfoOfCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctKHACHHANG.uctDL, 30, "Thông tin Khách hàng");
        }

        private void btnBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctHOADON.uctDL, 25, "Hóa đơn");
        }


        private void colseAllTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTab();
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CloseTabDisplayCurrent();
        }


        private void btnProductOfStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            //addTabPages(uctSanPhamCH.uctSPCH, 10, "Sản phẩm trong Cửa hàng");
        }

        private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItem3.Caption = DateTime.Now.ToLongDateString();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(2000);
            //addTabPages(uctBackGroud.ucthienthi, 40, "");
            skins();
        }

        private void tabDisplay_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Font drawFont = new Font("Time New Roman", 10);
            g.FillRectangle(new SolidBrush(Color.Blue), e.Bounds.Left, e.Bounds.Top, 200, 1);
            //e.Graphics.DrawString("X", drawFont, Brushes.Red, e.Bounds.Right - 14, e.Bounds.Top);e.Bounds.Left+10, e.Bounds.Top + 6
            e.Graphics.DrawString(this.tabDisplay.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top + 6);
            e.Graphics.DrawImage(Properties.Resources.x2, e.Bounds.Right - 16, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabDisplay.TabPages.Count; i++)

            {
                Rectangle r = tabDisplay.GetTabRect(i);
                //Getting the position of the “x” mark.
                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 20, 20);

                if (closeButton.Contains(e.Location))

                {
                    if (MessageBox.Show("Bạn có muốn đóng Tab hiện tại hay không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        this.tabDisplay.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void btnChangePassWord_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmDoiMatKhau Change = new frmDoiMatKhau();
            //Change.ShowDialog();
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            //frmLogin l = new frmLogin();
            //l.ShowDialog();
            this.Close();
        }


        

        private void btnProductOfStore1_ItemClick(object sender, ItemClickEventArgs e)
        {
            // addTabPages(uctSanPhamCH.uctSPCH, 10, "Quản lí sản phẩm");
        }

        private void btnAuthorInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmAuthorInfo author=new frmAuthorInfo();
            //author.ShowDialog();
            //this.Show();
        }
        private void btnSorftwareInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //frmSorftwareInfo author = new frmSorftwareInfo();
                //author.ShowDialog();
                //this.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thong bao");
            }
        }

        private void btnProductRender_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //frmBaoCaoSPTonKho baocao = new frmBaoCaoSPTonKho();
                //baocao.ShowDialog();
                //this.Show();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thong bao");
            }
        }

        private void btnDebtAgency_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //frmBaoCaoNoDaiLi baocao = new frmBaoCaoNoDaiLi();
                //baocao.ShowDialog();
                //this.Show();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thong bao");
            }
        }

        private void btnDeptCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //frmBaoCaoTienNoKhachHang baocao = new frmBaoCaoTienNoKhachHang();
                //baocao.ShowDialog();
                //this.Show();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thong bao");
            }
        }

        private void btnStatistics_ItemClick(object sender, ItemClickEventArgs e)
        {
            //addTabPages(uctThongKe.uctthongke, 10, "Thống kê doanh thu sản phẩm");
        }

        private void btnInfoAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmThongTinTaiKhoan account = new frmThongTinTaiKhoan();
            //account.ShowDialog();
            //this.Show();
        }

        private void btnManagerAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmAdmin account = new frmAdmin();
            //account.ShowDialog();
            //this.Show();
        }

        private void btnMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctMONAN2.uctMONAN, 1, "Menu");
        }

        private void btnNguyenLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctNLIEU.uctDL, 2, "Nguyên liệu");
        }

        private void btnDanhMuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctDANHMUC.uctDL, 3, "Danh mục món ăn");
        }

        private void btnNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctNCC.uctDL, 4, "Danh sách nhà cung cấp");
        }

        private void btnPYC_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctCreate_PYC.uctDL, 5, "Tạo phiếu yêu cầu");
        }

        private void btnListPYC_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctPYC.uctDL, 6, "Phiếu yêu cầu");
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctDONDATDA.uctDL, 7, "Đặt đơn hàng");
            uctDONDATDA.uctDL.fillCaption(btnOrderWait);
            uctDONDATDA.uctDL.LoadData();
        }

        private void btnOrderWait_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctHOADONTT.uctDL, 8, "Chờ thanh toán");
            uctHOADONTT.uctDL.fillCaption(btnOrderWait);
        }

        # region mua hàng
        private void btnDONMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctDONMH.uctDL, 9, "Đơn mua hàng");
        }
        private void btnCreateDONMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctDONMH_Detail.uctDL, 10, "Tạo đơn mua hàng");
        }


        #endregion

        private void btnGiaoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctGIAOHANG.uctDL, 11, "Giao hàng");

        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctPNHAP.uctDL, 12, "Nhập hàng");
        }

        private void menuToolStrip_Click(object sender, EventArgs e)
        {

        }


        private void btnExportHOADONM_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctHOADONM.uctDL, 13, "Xuất hóa đơn mua");
        }

        private void btnDONDATDA_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctListDONDATDA.uctDL, 14, "Đơn đặt đồ ăn");
        }
        private void btnHOADONM_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctListHOADONM.uctDL, 15, "Hóa đơn mua");
        }
        private void btnRevenue_ItemClick(object sender, ItemClickEventArgs e)
        {
            addTabPages(uctReportDoanhThu.uctDL, 16, "Báo cáo doanh thu");
        }
    }
}