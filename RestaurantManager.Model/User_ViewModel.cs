using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Model
{
    public class User_ViewModel
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
