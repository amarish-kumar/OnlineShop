//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShop.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductReview
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string AspNetUserId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public System.DateTime ReviewDate { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Product Product { get; set; }
    }
}