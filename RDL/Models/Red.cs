using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDL.Models
{
    public class Red
    {
        public int Id { get; set; }
        public int rBeacon { get; set; }
        public int rSeismometer { get; set; }
        public int teamId { get; set; }
        public int currentQuestion { get; set; }
        public int rFogMachine { get; set; }
    }
}