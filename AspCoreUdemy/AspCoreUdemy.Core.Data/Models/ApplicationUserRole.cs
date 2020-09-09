using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace AspCoreUdemy.Core.Data.Models
{
    public class ApplicationUserRole: IdentityUserRole<string>
    {
        public ApplicationUserRole(): base()
        {
        }
        
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ApplicationRole ApplicationRole { get; set; }
    }
}
