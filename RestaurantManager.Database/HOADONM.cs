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
    
    public partial class HOADONM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONM()
        {
            this.D_HOADONM = new HashSet<D_HOADONM>();
        }
    
        public int idhoadonm { get; set; }
        public Nullable<System.DateTime> ngaymua { get; set; }
        public Nullable<int> idpnhap { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_HOADONM> D_HOADONM { get; set; }
        public virtual PNHAP PNHAP { get; set; }
    }
}
