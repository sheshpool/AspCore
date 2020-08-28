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
  
        public string Titre { get; set; }

        public string Description { get; set; }
        public int SubjectId { get; set; }
        public  List<Response> Responses { get; set; }
    }
}