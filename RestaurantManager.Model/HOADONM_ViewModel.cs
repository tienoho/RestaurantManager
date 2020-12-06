using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class HOADONM_ViewModel
    {
        public int idhoadonm { get; set; }
        public Nullable<System.DateTime> ngaymua { get; set; }
        public Nullable<int> idpnhap { get; set; }
        public int idpgiao { get; set; }
        public int iddonmh { get; set; }
        public int idncc { get; set; }
        public string tenncc { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public double TotalAmount { get; set; }
        //public int idgiao { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
