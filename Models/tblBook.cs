//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Book_Keeping_Site.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBook
    {
        public int Id { get; set; }
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public string Publisher { get; set; }
        public decimal Publication_Year { get; set; }
        public int Price { get; set; }
        public string ISBN_Number { get; set; }
        public string Country_Origin { get; set; }
        public string Book_Description { get; set; }
        public string Available_On { get; set; }
        public System.DateTime Created_At { get; set; }
        public System.DateTime Updated_At { get; set; }
        public string Language { get; set; }
    }
}
