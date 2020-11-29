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
    public partial class ReportGIAOHANG : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportGIAOHANG()
        {
            InitializeComponent();
            
        }
        public void InitData(GIAOHANG_ViewModel obj, List<D_GIAOHANG_ViewModel> data)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lbliddonmh.Text = obj.idpgiao.ToString();
                lblDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                ///var details = new PYCBll().GetListD_PYC(pyc.idyc);
                objectDataSource1.DataSource = data;
                
            }
        }
        private void getInfoNCC(int idncc)
        {

        }
    }
}
