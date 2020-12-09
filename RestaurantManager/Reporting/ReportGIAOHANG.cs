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
            using (var db = new RestaurantManagerDataEntities())
            {
                var toDay = DateTime.Now;
                lbliddonmh.Text = obj.idpgiao.ToString();
                lblDate.Text = string.Format("Ngày {0} tháng {1} năm {2}", toDay.Day, toDay.Month, toDay.Year);
                ///var details = new PYCBll().GetListD_PYC(pyc.idyc);
                ///
                var ncc = getInfoNCC(obj.idncc.Value);
                lbltenncc.Text = ncc.tenncc;
                lblCuaHang.Text = obj.cuahang;
                lblDiaChi.Text = obj.diachi;
                lblAddress.Text = ncc.diachi;
                lblPhone.Text = ncc.sdt;
                lblidgiaohang.Text = obj.idpgiao.ToString();
                lbliddonmh.Text = obj.iddonmh.ToString();
                lblNguoiNhanTitle.Text = obj.nguoinhan;
                lblNguoiNhan.Text = obj.nguoinhan;
                lblNguoiGiao.Text = obj.nguoigiao;
                lblnguoilap.Text = obj.nguoilapphieu;


                objectDataSource2.DataSource = data;

            }
        }
        private NCC getInfoNCC(int idncc)
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                var result = db.NCCs.AsNoTracking().FirstOrDefault(x => x.idncc == idncc);
                return result;
            }
        }
    }
}
