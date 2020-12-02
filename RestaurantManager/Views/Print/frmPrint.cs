using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManager.Database;
using RestaurantManager.Model;
using RestaurantManager.Reporting;

namespace RestaurantManager.Views.Print
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }
        //hiển thị phiếu yêu cầu
        public void PrintPYC(PYC obj, List<D_PYC_ViewModel> data)
        {
            ReportPYC report = new ReportPYC();
            //Hide paramater
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            //Init data report
            report.InitData(obj, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="data"></param>
        public void PrintHOADONTT(HOADONTT_ViewModel obj, List<D_HOADONTT_ViewModel> data)
        {
            ReportHOADONTT report = new ReportHOADONTT();
            //Hide paramater
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            //Init data report
            report.InitData(obj, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void PrintGIAOHANG(GIAOHANG_ViewModel obj, List<D_GIAOHANG_ViewModel> data)
        {
            ReportGIAOHANG report = new ReportGIAOHANG();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="data"></param>
        public void PrintPNHAP(PNHAP_ViewModel obj, List<D_PNHAP_ViewModel> data)
        {
            ReportPNHAP report = new ReportPNHAP();
        }
        public void PrintGIAOHANG(GIAOHANG_ViewModel obj, List<D_GIAOHANG_ViewModel> data)
        {
            ReportGIAOHANG report = new ReportGIAOHANG();
            //Hide paramater
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            //Init data report
            report.InitData(obj, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
        public void PrintBaoCaoDoanhThu(DateTime fromday, DateTime today, List<HOADONTT_ViewModel> data)
        {
            ReportBCDoanhThu report = new ReportBCDoanhThu();
            //Hide paramater
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            //Init data report
            report.InitData(fromday, today, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
