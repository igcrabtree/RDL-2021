using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RDL.Models;

namespace RDL.ViewModels
{
    public class NewScoreViewModel
    {
        public Score Score { get; set; }
        public Team Team { get; set; }
    }
}