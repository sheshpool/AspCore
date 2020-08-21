using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    [Table("Paragraphe", Schema = "dbo")]
    public class Paragraphe
    {
        
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public Question MaQuestion { get; set; }
    }
}
