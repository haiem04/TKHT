//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TKHT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> Role { get; set; }
        public Nullable<int> StudentId { get; set; }
    
        public virtual Student Student { get; set; }
    }
}