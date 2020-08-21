using System;
using System.Collections.Generic;
using System.Text;

namespace AspCoreUdemy.Core.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public  List<Reponse> MesReponses { get; set; }
    }
}