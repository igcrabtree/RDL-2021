using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDL.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int teamId { get; set; }
        public int siesmometer { get; set; }
        public int beacon { get; set; }
        public int auv { get; set; }
        public int imageRecog { get; set; }
        public int satellite { get; set; }
        public int hydroPod { get; set; }
        public int nitroPod { get; set; }
        public int carbonPod { get; set; }
        public int stemQs { get; set; }
        public double total { get; set; }
        public int endGame { get; set; }

        public double methane { get; set; }
        public double ethane { get; set; }
        public double butane { get; set; }
        public double pentane { get; set; }
        public double hexane { get; set; }
        public double heptane { get; set; }
        public double octane { get; set; }
        public double nonane { get; set; }
        public double decane { get; set; }
        
    }
}