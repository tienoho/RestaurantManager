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
    public partial class ReportDONDATDA : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDONDATDA()
        {
            InitializeComponent();
            
        }
        public void InitData(DONDATDA_ViewModel obj, List<D_DONDATDA_ViewModel> data)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lblid.Text = obj.iddondat.ToString();
                lblKhachHang.Text = obj.tenkh.ToString();
                lblsdt.Text = obj.sdt.ToString();
                lblBan.Text = obj.ban.ToString();
                lblNgay.Text = obj.ngaydat.Value.ToString("dd/MM/yyyy");
                lblFooterDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                objectDataSource2.DataSource = data;
                
            }
        }
    }
}
