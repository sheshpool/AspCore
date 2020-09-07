using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AspCoreUdemy.Core.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "varchar(100)")] 
        public string LastName { get; set; }
    }
}