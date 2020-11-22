using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class D_DONDATDA_ViewModel
    {
        public int iddondat { get; set; }
        public int idmon { get; set; }
        public string tenmon { get; set; }
        public int sldat { get; set; }
        public double dongiamon { get; set; }
        public double TotalAmount { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
