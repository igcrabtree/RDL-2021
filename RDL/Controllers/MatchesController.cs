using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDL.Models;
using RDL.ViewModels;

namespace RDL.Controllers
{
    public class MatchesController : Controller
    {
        private ApplicationDbContext _context;

        public MatchesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Matches
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Previous()
        {
            var matches = _context.Matches.ToList();
            return View(matches);
        }
        public ActionResult New()
        {
            //var viewModel = new NewMatchViewModel();
            var match = new Match();

            return View(match);
        }
        public ActionResult Test()
        {
            var viewModel = new NewMatchViewModel();
            return View(viewModel);
        }
        public ActionResult Events()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Score(Match match)
        {
            _context.Blue.Find(1).TeamId = match.BlueTeamID;
            _context.Red.Find(2).teamId = match.RedTeamID;
            _context.Teams.Find(match.BlueTeamID).Score = 0;
            _context.Teams.Find(match.RedTeamID).Score = 0;
            _context.Teams.Find(match.RedTeamID).stemQScore = 0;
            _context.Teams.Find(match.BlueTeamID).stemQScore = 0;
            var FMSb = _context.Blue.Find(1);
            var FMSr = _context.Red.Find(2);
            System.Diagnostics.Debug.WriteLine("Red Team Id: " + FMSr.teamId);
            System.Diagnostics.Debug.WriteLine("Blue Team Id: " + FMSb.TeamId);
            /*FMSb.TeamId = blue.Id;
            FMSr.teamId = red.Id;*/

            //var FMSr = _context.Blue.SingleOrDefault(c => c.Id == 2);
            //var FMSb = _context.Blue.SingleOrDefault(c => c.Id == 1);

            _context.SaveChanges();
            return RedirectToAction("Index", "Scores");
        }

    }
}