﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    [Table("Question", Schema = "dbo")]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }

        public int ParagrapheId { get; set; }
        public  List<Reponse> MesReponses { get; set; }
    }
}