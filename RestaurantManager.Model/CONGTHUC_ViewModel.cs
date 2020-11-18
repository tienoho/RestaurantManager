using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class CONGTHUC_ViewModel
    {
        public int idmon { get; set; }
        public string temon { get; set; }
        public int idhang { get; set; }
        public string tenhang { get; set; }
        public string hamluong { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
