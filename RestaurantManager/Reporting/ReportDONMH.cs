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
    public partial class ReportHOADONTT : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHOADONTT()
        {
            InitializeComponent();
            
        }
        public void InitData(PYC pyc, List<D_PYC_ViewModel> data)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lblid.Text = pyc.idyc.ToString();
                lblFooterDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                ///var details = new PYCBll().GetListD_PYC(pyc.idyc);
                objectDataSource1.DataSource = data;
                
            }
        }
    }
}
