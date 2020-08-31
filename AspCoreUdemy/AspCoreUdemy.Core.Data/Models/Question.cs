using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    [Table("Question", Schema = "app")]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigné.")]
        public string Titre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "La description doit être renseignée.")]
        public string Description { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public  List<Response> Responses { get; set; }
    }
}