using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDL.Models
{
    public class TeamQuestion
    {
        public int Id { get; set; }
        public int teamId { get; set; }
        public int questionId { get; set; }
        public string qA { get; set; }
        public string qB { get; set; }
        public string qC { get; set; }
        public string qD { get; set; }
        public int answer { get; set; }
    }
}