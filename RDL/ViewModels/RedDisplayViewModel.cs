using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RDL.Models;

namespace RDL.ViewModels
{
    public class RedDisplayViewModel
    {
        public Red red { get; set; }
        public List<StemQuestions> Questions { get; set; }
    }
}