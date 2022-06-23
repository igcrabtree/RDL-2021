using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDL.Models
{
    public class Blue
    {
        public int Id { get; set; }
        public int bBeacon { get; set; }
        public int bSeismometer { get; set; }
        //public int bdivision { get; set; }
        public int currentQuestion { get; set; }
        public int TeamId { get; set; }
       

        public List<int> questionsUsed = new List<int>();
        public int fogMachine { get; set; }
        public int fan { get; set; }
    }
}