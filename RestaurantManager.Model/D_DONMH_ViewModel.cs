using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class D_DONMH_ViewModel
    {
        public int iddonmh { get; set; }
        public int idhang { get; set; }
        public string tenhang { get; set; }
        public int slmh { get; set; }
        public double dongiamh { get; set; }
        public double totalamount { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
