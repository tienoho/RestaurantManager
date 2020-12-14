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
        public void InitData(HOADONTT_ViewModel obj, List<D_HOADONTT_ViewModel> data)
        {
            using(var db=new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lblid.Text = obj.idhoadontt.ToString();
                lblNgayHD.Text = obj.ngayhd.ToString("dd/MM/yyyy");
                lblBan.Text = obj.ban;
                lblsdt.Text = obj.sdt;
                lblKhachHang.Text = obj.tenkh==null?"": obj.tenkh;
                lblThoiGian.Text = obj.thoigian.Value.ToString("hh:mm:ss");
                lblThuNgan.Text = obj.thungan.ToString();
                lblCustomerPay.Text = obj.CustomerPay.ToString("#,###");
                var total = data.Sum(x => x.TotalAmount);
                xrReturn.Text = (obj.CustomerPay - total).ToString("#,###");
                //lblFooterDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                ///var details = new PYCBll().GetListD_PYC(pyc.idyc);
                objectDataSource4.DataSource = data;
                
            }
        }
    }
}
