using System;

namespace RestaurantManager.Model
{
   public class D_HOADONTT_ViewModel
    {
        public int idhoadontt { get; set; }
        public int idmon { get; set; }
        public int slban { get; set; }
        public double dongiaban { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}