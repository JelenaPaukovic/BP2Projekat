//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeniskiTurniri
{
    using System;
    using System.Collections.Generic;
    
    public partial class Igrac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Igrac()
        {
            this.Ucestvuje = new HashSet<Ucestvuje>();
        }
    
        public int idig { get; set; }
        public string imei { get; set; }
        public string przi { get; set; }
        public System.DateTime datri { get; set; }
        public string drzi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ucestvuje> Ucestvuje { get; set; }
    }
}
