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
    
    public partial class D_DONMH
    {
        public int iddonmh { get; set; }
        public int idhang { get; set; }
        public Nullable<int> slmh { get; set; }
        public Nullable<int> dongiamh { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    
        public virtual DONMH DONMH { get; set; }
        public virtual NLIEU NLIEU { get; set; }
    }
}
