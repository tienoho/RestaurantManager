using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class MONAN_ViewModel
    {
        public int idmon { get; set; }
        public string temon { get; set; }
        public Nullable<double> dongiamon { get; set; }
        public string dvt { get; set; }
        public string hinhanh { get; set; }
        public Nullable<int> iddmuc { get; set; }
        public string tendmuc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
