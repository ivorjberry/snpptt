//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace snpptt.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Bookmarks = new HashSet<Bookmark>();
        }
    
        public int ID { get; set; }
        public string Username { get; set; }
    
        public virtual ICollection<Bookmark> Bookmarks { get; set; }
    }
}
