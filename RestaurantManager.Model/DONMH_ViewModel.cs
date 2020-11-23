using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class DONMH_ViewModel
    {
        public int iddonmh { get; set; }
        public System.DateTime ngaydonmh { get; set; }
        public int? idncc { get; set; }
        public string tenncc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}