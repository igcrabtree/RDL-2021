using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDL.Models;
using RDL.ViewModels;

namespace RDL.Controllers
{
    public class ScoresController : Controller
    {
        private ApplicationDbContext _context;

        public ScoresController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Score
        public ActionResult Index()
        {
            //var viewModel = new NewScoreViewModel();
            //var match = new Match();
            return View();
        }

        [HttpPost]
        public ActionResult Add(Score score)
        {
            score.stemQs = score.stemQs + _context.Teams.Find(score.teamId).stemQScore;
            System.Diagnostics.Debug.WriteLine("Stem Q Score: " + score.stemQs);
            score.total += score.stemQs;
            var red = _context.Red.Find(2).teamId;
            var blue = _context.Blue.Find(1).TeamId;
            if(score.teamId == blue)
            {
                if(score.beacon == 0)
                {
                    if(_context.Blue.Find(1).bBeacon == 1)
                    {
                        score.beacon = 30;
                        score.total += 30;
                    }
                }
            }

            if (score.teamId == red)
            {
                if (score.beacon == 0)
                {
                    if (_context.Red.Find(2).rBeacon == 1)
                    {
                        score.beacon = 30;
                        score.total += 30;
                    }
                }
            }
            _context.Score.Add(score);
            System.Diagnostics.Debug.WriteLine("Total Score: " + score.total);
            _context.SaveChanges();
            return View(score);
        }

         public ActionResult AddBonusQuestion(int id)
         {
            var team = _context.Teams.Find(id);
            return View(team);
         }

        public ActionResult ResetQ(int id)
        {
            _context.Teams.Find(id).questions = 0;
            _context.SaveChanges();
            return null;
        }

       
        public ActionResult AddQ(int id)
        {
            //_context.Teams.Find(id).questions = 0;
            //var id = team.Id;
            _context.Teams.Find(id).questions = 2;
            _context.SaveChanges();

            var actualTeam = _context.Teams.Find(id);
            var questions = _context.StemQuestions.ToList();
            var usedquestions = _context.UsedQuestions.ToList();


            List<int> qIds = new List<int>();

            foreach (UsedQuestions q in usedquestions)
            {
                qIds.Add(q.QuestionId);
            }


            var min = 0;
            var range = 0;
            if (actualTeam.division == 2)
            {
                min = 1002;
                range = 1048;
            }
            else
            {
                min = 1049;
                range = 1108;
            }


            Random rand = new Random();
            var questNum = rand.Next(min, range);
            while (qIds.Contains(questNum))
            {
                questNum = rand.Next(min, range);
            }
            //actualTeam.currentQuestionId = questNum;
            _context.Teams.Find(id).currentQuestionId = questNum;

            //*****DEBUGGING
            System.Diagnostics.Debug.WriteLine("New Question: " + _context.Teams.Find(id).currentQuestionId);
            var quest = new UsedQuestions
            {
                QuestionId = questNum,
                TeamId = actualTeam.Id
            };

            _context.UsedQuestions.Add(quest);
            //actualTeam.questions = actualTeam.questions + 1;
            _context.Teams.Find(id).questions = actualTeam.questions + 1;
            //*****DEBUGGING
            System.Diagnostics.Debug.WriteLine("Current Questions Answered: " + _context.Teams.Find(id).questions);
            _context.SaveChanges();
            return null;
        }
        /*public ActionResult AddBonusQuestion(int id)
        {
            var team = _context.Teams.SingleOrDefault(c => c.Id == id);
            return View(team);
        }*/
        [HttpPost]
        public ActionResult Update(Score score)
        {
            score.stemQs = score.stemQs + _context.Teams.Find(score.teamId).stemQScore;
            System.Diagnostics.Debug.WriteLine("Stem Q Score: " + score.stemQs);
            score.total += score.stemQs;
            var red = _context.Red.Find(2).teamId;
            var blue = _context.Blue.Find(1).TeamId;
            if (score.teamId == blue)
            {
                if (score.beacon == 0)
                {
                    if (_context.Blue.Find(1).bBeacon == 1)
                    {
                        score.beacon = 30;
                        score.total += 30;
                    }
                }
            }

            if (score.teamId == red)
            {
                if (score.beacon == 0)
                {
                    if (_context.Red.Find(2).rBeacon == 1)
                    {
                        score.beacon = 30;
                        score.total += 30;
                    }
                }
            }
            _context.Teams.Find(score.teamId).Score = score.total;
            System.Diagnostics.Debug.WriteLine("Total Score: " + score.total);
            _context.SaveChanges();
            return null;
        }

        public ActionResult DisplayScores(int id)
        {
            var team = _context.Teams.SingleOrDefault(c => c.Id == id);
            return View(team);
        }

        public ActionResult New()
        {
            return View();
        }
    }
}