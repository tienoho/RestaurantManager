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
    
    public partial class GIAOHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAOHANG()
        {
            this.D_GIAOHANG = new HashSet<D_GIAOHANG>();
            this.PNHAPs = new HashSet<PNHAP>();
        }
    
        public int idpgiao { get; set; }
        public Nullable<System.DateTime> ngaygiao { get; set; }
        public string nguoinhan { get; set; }
        public string nguoilapphieu { get; set; }
        public string nguoigiao { get; set; }
        public string cuahang { get; set; }
        public string diachi { get; set; }
        public Nullable<int> idncc { get; set; }
        public Nullable<int> iddonmh { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_GIAOHANG> D_GIAOHANG { get; set; }
        public virtual DONMH DONMH { get; set; }
        public virtual NCC NCC { get; set; }
        public virtual PNHAP PNHAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PNHAP> PNHAPs { get; set; }
    }
}
