//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShop.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class book
    {
        public string Book1 { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public int BookTypeId { get; set; }
        public float Price { get; set; }
        public int Number { get; set; }
        public int barcodeId { get; set; }
    
        public virtual booktype booktype { get; set; }
    }
}