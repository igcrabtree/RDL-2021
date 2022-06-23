using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDL.Models;
using RDL.ViewModels;

namespace RDL.Controllers
{
    public class FMSrController : Controller
    {
        private ApplicationDbContext _context;
        public FMSrController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Tests
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            var thisRed = _context.Red.SingleOrDefault(c => c.Id == 2);
            System.Diagnostics.Debug.WriteLine("team Id: " + thisRed.teamId);
            System.Diagnostics.Debug.WriteLine("team QId: " + thisRed.currentQuestion);
            var questions = _context.StemQuestions.ToList();
            var questListIndex = (_context.Teams.Find(thisRed.teamId).currentQuestionId - 1002) + 50;
            //thisRed.currentQuestion = _context.Teams.Find(thisRed.teamId).currentQuestionId;
            thisRed.currentQuestion = questListIndex;
            _context.SaveChanges();

            //var redteam = _context.Teams.Find(thisRed.teamId);
            //var redteam = _context.Teams.SingleOrDefault(c => c.Id == 1);
            if (thisRed.currentQuestion == 0)
            {
                thisRed.currentQuestion = 1;
                _context.SaveChanges();
            }
            //thisRed.currentQuestion = redteam.currentQuestionId;*/
            var viewModel = new RedDisplayViewModel
            {
                red = thisRed,
                Questions = questions
                //usedQuestions = usedquestions
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Change(Red updatedRed)
        {
            var red = _context.Red.SingleOrDefault(c => c.Id == 2);
            red.rBeacon = updatedRed.rBeacon;
            red.rSeismometer = updatedRed.rSeismometer;
            _context.SaveChanges();
            return RedirectToAction("ReceiveData", "FMSr");
        }

        public ActionResult ReceiveData()
        {
            var red = _context.Red.SingleOrDefault(c => c.Id == 2);

            if (red == null)
                return HttpNotFound();

            return View();
        }
    }
}