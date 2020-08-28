using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    [Table("Exam", Schema = "app")]
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre ne doit pas être vide.")]
        public string Titre { get; set; }

        public string Description { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}