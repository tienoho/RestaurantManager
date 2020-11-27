using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class PNHAP_ViewModel
    {
        public int idpnhap { get; set; }
        public Nullable<System.DateTime> ngaynhap { get; set; }
        public string nguoigiao { get; set; }        
        public string nguoilapphieu { get; set; }
        public string tennguoilapphieu { get; set; }
        public string thukho { get; set; }
        public string tenthukho { get; set; }
        public Nullable<int> idpgiao { get; set; }
    }
}
