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
    public partial class ReportBCDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBCDoanhThu()
        {
            InitializeComponent();

        }
        public void InitData(DateTime fromday, DateTime today, List<HOADONTT_ViewModel> data)
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lblfromday.Text = fromday.ToString("dd/MM/yyyy");
                lbltoday.Text = today.ToString("dd/MM/yyyy");

                lblFooterDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                ///var details = new PYCBll().GetListD_PYC(pyc.idyc);
                objectDataSource3.DataSource = data;

            }
        }
    }
}
