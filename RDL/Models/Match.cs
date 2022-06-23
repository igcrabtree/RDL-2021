using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDL.Models
{
    public class Match
    {
        public int Id { get; set; }

        public int RedTeamID { get; set; }
        public int BlueTeamID { get; set; }
    }
}