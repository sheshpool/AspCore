using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {
        }
        
        [PersonalData]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "varchar(100)")] 
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "DateTime2")]
        public DateTime CreationDateTime { get; set; }

        public virtual ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; }
    }
}