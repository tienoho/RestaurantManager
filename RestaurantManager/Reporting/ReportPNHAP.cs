using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using RestaurantManager.Model;
using RestaurantManager.Bussiness;
using RestaurantManager.Database;
using System.Collections.Generic;

namespace RestaurantManager.Reporting
{
    public partial class ReportPNHAP : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPNHAP()
        {
            InitializeComponent();
            
        }
        public void InitData(PNHAP_ViewModel master, List<D_PNHAP_ViewModel> detail)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lblidpnhap.Text = master.idpnhap.ToString();
                lblidgiaohang.Text = master.idpgiao.ToString();
                lblngaynhap.Text = string.Format("{0}/{1}/{2}", master.ngaynhap.Value.Day, master.ngaynhap.Value.Month, master.ngaynhap.Value.Year);
                lblnguoigiao.Text = master.nguoigiao;
                lblnguoilap.Text = master.nguoilapphieu;
                lblthukho.Text = master.thukho;
                objectDataSource2.DataSource = detail;
                lblFooterDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                
            }
        }
    }
}
