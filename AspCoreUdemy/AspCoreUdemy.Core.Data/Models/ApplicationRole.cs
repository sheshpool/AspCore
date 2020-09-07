using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    public class ApplicationRole: IdentityRole
    {
        public string RoleName { get; set; }
    }
}
