using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDL.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public int division { get; set; }

        public List<int> PreviousScores { get; set; }
        public int currentQuestionId { get; set; }
        public int questionAns { get; set; }
        public int questions { get; set; }
        public int stemQScore { get; set; }

        //public List<int> QuestionsUsed { get; set; } = new List<int>();
        public bool winner { get; set; }
    }
}