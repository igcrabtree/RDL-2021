using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace RDL.Models
{
    public class StemQuestions
    {
        public int Id { get; set; }
        public String Question { get; set; }
        public String AnswerA { get; set; }
        public String AnswerB { get; set; }
        public String AnswerC { get; set; }
        public String AnswerD { get; set; }

        public int correctAns { get; set; }
        public int division { get; set; }
    }
}