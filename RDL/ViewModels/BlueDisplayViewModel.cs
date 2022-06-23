using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RDL.Models;

namespace RDL.ViewModels
{
    public class BlueDisplayViewModel
    {
        public Blue blue { get; set; }
        public List<StemQuestions> Questions { get; set; }
        //public List<UsedQuestions> usedQuestions { get; set; }
        
    }
}