using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class HOADONTT_ViewModel
    {
        public int idhoadontt { get; set; }
        public System.DateTime ngayhd { get; set; }
        public Nullable<System.DateTime> thoigian { get; set; }
        public string thungan { get; set; }
        public string ban { get; set; }
        public string sdt { get; set; }
        public Nullable<int> idkh { get; set; }
        public string tenkh { get; set; }
        public Nullable<int> iddondat { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        //tiền khách đưa
        public double CustomerPay { get; set; }
        public double TotalAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<D_HOADONTT_ViewModel> D_HOADONTT { get; set; }
    }
}
