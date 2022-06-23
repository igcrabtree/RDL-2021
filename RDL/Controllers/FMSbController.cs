using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDL.Models;
using RDL.ViewModels;

namespace RDL.Controllers
{
    public class FMSbController : Controller
    {

        private ApplicationDbContext _context;
        
        public FMSbController()
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
            var thisBlue = _context.Blue.SingleOrDefault(c => c.Id == 1);
            var questions = _context.StemQuestions.ToList();
            //thisBlue.currentQuestion = _context.Teams.Find(thisBlue.TeamId).currentQuestionId;
            var questListIndex = (_context.Teams.Find(thisBlue.TeamId).currentQuestionId - 1002) + 50;
            //thisRed.currentQuestion = _context.Teams.Find(thisRed.teamId).currentQuestionId;
            thisBlue.currentQuestion = questListIndex;
            _context.SaveChanges();

            //var blueteam = _context.Teams.Find(thisBlue.TeamId);
            //test with team #2
            //var blueteam = _context.Teams.SingleOrDefault(c => c.Id == 2);
            /*if(blueteam.currentQuestionId == 0)
            {
                blueteam.currentQuestionId = 1;
                _context.SaveChanges();
            }*/
            //thisBlue.currentQuestion = blueteam.currentQuestionId;
            var viewModel = new BlueDisplayViewModel {
                blue = thisBlue,
                Questions = questions,
                //usedQuestions = usedquestions
            };
            return View(viewModel); 
        }

        [HttpPost]
        public ActionResult Change(Blue updatedBlue)
        {
            var blue = _context.Blue.SingleOrDefault(c => c.Id == 1);
            blue.bBeacon = updatedBlue.bBeacon;
            blue.bSeismometer = updatedBlue.bSeismometer;
            _context.SaveChanges();
            return RedirectToAction("ReceiveData", "FMSb");
        }

        public ActionResult ReceiveData()
        {
            var blue = _context.Blue.SingleOrDefault(c => c.Id == 1);

            if (blue == null)
                return HttpNotFound();

            return View();
        }

    }
}