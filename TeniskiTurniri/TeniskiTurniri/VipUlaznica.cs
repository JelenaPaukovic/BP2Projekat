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
    
    public partial class VipUlaznica
    {
        public string oznv { get; set; }
        public int idvu { get; set; }
    
        public virtual Ulaznica Ulaznica { get; set; }
    }
}
