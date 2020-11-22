using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class DONDATDA_ViewModel
    {
        public int iddondat { get; set; }
        public Nullable<System.DateTime> ngaydat { get; set; }
        public string ban { get; set; }
        public Nullable<int> idkh { get; set; }
        public string tenkh { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }

        public List<D_DONDATDA_ViewModel> D_DONDATDA { get; set; }
    }
}
