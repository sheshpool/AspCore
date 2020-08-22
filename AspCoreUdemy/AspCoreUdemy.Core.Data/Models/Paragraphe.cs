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

        [Range(1, 999999)]
        public int Numero { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre ne doit pas être vide.")]
        public string Titre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La description doit être renseignée.")]
        public string Description { get; set; }

        public Question MaQuestion { get; set; }
    }
}
