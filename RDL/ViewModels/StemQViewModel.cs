using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RDL.Models;

namespace RDL.ViewModels
{
    public class StemQViewModel
    {
        public Team team { get; set; }
        public StemQuestions question { get; set; }
    }
}