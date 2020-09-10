using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreUdemy.BackOffice.Web.UI.Models
{
    public class UserRoleViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        public IList<String> Roles { get; set; }
    }
}