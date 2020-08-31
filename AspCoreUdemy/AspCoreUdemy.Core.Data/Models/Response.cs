    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    [Table("Response", Schema = "app")]
    public class Response
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigné.")]
        public string Titre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le description doit être renseignée.")]
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
    }
}