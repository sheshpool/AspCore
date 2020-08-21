using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreUdemy.Core.Data.Models
{
    [Table("Aventure", Schema = "dbo")]
    public class Aventure
    {
        public int Id { get; set; }
        public string Titre { get; set; }
    }
}