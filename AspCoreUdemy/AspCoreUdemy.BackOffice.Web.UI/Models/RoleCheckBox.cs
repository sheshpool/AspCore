using AspCoreUdemy.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreUdemy.BackOffice.Web.UI.Models
{
    public class RoleCheckBox
    {
        public ApplicationRole ApplicationRole { get; set; }
        public bool  IsChecked { get; set; }
    }
}