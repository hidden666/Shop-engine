//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Data.Interfaces;

namespace Infrastructure
{
    using System;
    using System.Collections.Generic;

    public partial class Role : IEntityBase 
    {
        public Role()
        {
            this.UserRole = new HashSet<UserRole>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
