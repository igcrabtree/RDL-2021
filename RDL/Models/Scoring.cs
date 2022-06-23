using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDL.Models
{
    public class Scoring
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int PointsInAuto { get; set; }
        public int PointsInTele { get; set; }

    }
}