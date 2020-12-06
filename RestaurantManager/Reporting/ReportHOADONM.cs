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
        public void InitData(HOADONM_ViewModel obj, List<D_HOADONM_ViewModel> data)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lblid.Text = obj.idhoadonm.ToString();
                lblFooterDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                ///var details = new PYCBll().GetListD_PYC(pyc.idyc);

                lblid.Text = obj.idhoadonm.ToString();
                lblNCC.Text = obj.tenncc.ToString();
                lblNgayMua.Text = obj.ngaymua.Value.ToString("dd/MM/yyyy");
                lblDiaChi.Text = obj.diachi;
                lblsdt.Text = obj.sdt;

                objectDataSource4.DataSource = data;
                
            }
        }
    }
}
