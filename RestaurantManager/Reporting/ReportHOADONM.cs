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
    public partial class ReportHOADONM : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHOADONM()
        {
            InitializeComponent();
            
        }
        public void InitData(HOADONM_ViewModel master, List<D_HOADONM_ViewModel> detail)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lblidhoadonm.Text = master.idhoadonm.ToString();
                lbltenncc.Text = master.tenncc.ToString();
                lblidgiao.Text = master.idpgiao.ToString();
                lblidnhap.Text = master.idpnhap.ToString();
                lblCreateBy.Text = master.CreateBy.ToString();
                lblnguoilap.Text = master.CreateBy.ToString();
                lblngaymua.Text = string.Format("{0}/{1}/{2}", master.CreateDate.Day, master.CreateDate.Month, master.CreateDate.Year);
                objectDataSource4.DataSource = detail;
                lblFooterDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);

            }
        }
    }
}
