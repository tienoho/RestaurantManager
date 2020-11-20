using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class D_PYC_ViewModel
    {
        public int idyc { get; set; }
        public int idhang { get; set; }
        public string tenhang { get; set; }
        public Nullable<int> sldukien { get; set; }
        public Nullable<int> slton { get; set; }
        public Nullable<int> nguong { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
