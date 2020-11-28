using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using RestaurantManager.Model;
using RestaurantManager.Bussiness;
using RestaurantManager.Database;

namespace RestaurantManager.Reporting
{
    public partial class ReportPYC : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPYC(string Id)
        {
            InitializeComponent();
            
        }
        public void initControl(PYC_ViewModel pyc)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var details = new PYCBll().GetListD_PYC(pyc.idyc);
                
            }
        }
    }
}
