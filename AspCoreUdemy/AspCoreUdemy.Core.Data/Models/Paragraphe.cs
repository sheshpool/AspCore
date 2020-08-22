using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    [Table("Paragraphe", Schema = "dbo")]
    public class Paragraphe
    {
        
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }

        public Question MaQuestion { get; set; }
    }
}
