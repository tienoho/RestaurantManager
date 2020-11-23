using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class GIAOHANG_ViewModel
    {
        public int idpgiao { get; set; }
        public Nullable<System.DateTime> ngaygiao { get; set; }
        public string nguoinhan { get; set; }
        public string nguoilapphieu { get; set; }
        public string nguoigiao { get; set; }
        public string cuahang { get; set; }
        public string diachi { get; set; }
        public Nullable<int> idncc { get; set; }
        public string tenncc { get; set; }
        public Nullable<int> iddonmh { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }

        ///
        public List<D_GIAOHANG_ViewModel> D_GIAOHANG { get; set; }
    }
}
