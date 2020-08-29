using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    [Table("Subject", Schema = "app")]
    public class Subject
    {
        
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre ne doit pas être vide.")]
        public string Titre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La description doit être renseignée.")]
        public string Description { get; set; }

        [Range(1, 1000, ErrorMessage = "Un examen doit être sélectionné")]
        public int ExamId { get; set; }
        public List<Question> Questions { get; set; }
    }
}