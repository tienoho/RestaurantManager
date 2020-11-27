using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
   public class D_PNHAP_ViewModel
    {
        public int idpnhap { get; set; }
        public int idhang { get; set; }
        public string tenhang { get; set; }
        public Nullable<int> slgiao { get; set; }
        public Nullable<int> slnhan { get; set; }
    }
}
