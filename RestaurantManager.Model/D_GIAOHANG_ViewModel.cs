using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class D_GIAOHANG_ViewModel
    {
        public int idpgiao { get; set; }
        public int idhang { get; set; }
        public string tenhang { get; set; }
        public Nullable<int> slgiaohang { get; set; }
        public Nullable<int> slnhanhang { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
