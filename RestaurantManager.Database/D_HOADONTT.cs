//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManager.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class D_HOADONTT
    {
        public int idhoadontt { get; set; }
        public int idmon { get; set; }
        public Nullable<int> slban { get; set; }
        public Nullable<int> dongiaban { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    
        public virtual HOADONTT HOADONTT { get; set; }
        public virtual MONAN MONAN { get; set; }
    }
}
