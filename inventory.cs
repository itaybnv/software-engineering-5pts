//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClothingShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventory
    {
        public int Id { get; set; }
        public int merchandise_id { get; set; }
        public int quantity { get; set; }
        public bool deleted { get; set; }
    
        public virtual merchandise merchandise { get; set; }
    }
}
