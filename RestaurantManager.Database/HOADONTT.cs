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
    
    public partial class HOADONTT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONTT()
        {
            this.D_HOADONTT = new HashSet<D_HOADONTT>();
        }
    
        public int idhoadontt { get; set; }
        public System.DateTime ngayhd { get; set; }
        public Nullable<System.DateTime> thoigian { get; set; }
        public string thungan { get; set; }
        public Nullable<int> idkh { get; set; }
        public Nullable<int> iddondat { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_HOADONTT> D_HOADONTT { get; set; }
        public virtual DONDATDA DONDATDA { get; set; }
    }
}
