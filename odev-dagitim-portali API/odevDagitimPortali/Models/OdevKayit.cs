//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace odevDagitimPortali.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OdevKayit
    {
        public int kayitId { get; set; }
        public int ogrId { get; set; }
        public int odevId { get; set; }
    
        public virtual Odev Odev { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}