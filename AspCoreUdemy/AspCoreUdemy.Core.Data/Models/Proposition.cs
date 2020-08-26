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
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
    }
}