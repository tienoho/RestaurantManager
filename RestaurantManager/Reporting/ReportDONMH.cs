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
    public partial class ReportDONMH : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDONMH()
        {
            InitializeComponent();
            
        }
        public void InitData(DONMH_ViewModel obj, List<D_DONMH_ViewModel> lstDetail)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lbliddonmua.Text = obj.iddonmh.ToString();
                lbldiachi.Text = obj.diachi;
                lbltenncc.Text = obj.tenncc;
                lblsdt.Text = obj.sdt;
                lblFooterDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                objectDataSource3.DataSource = lstDetail;
            }
        }
    }
}
