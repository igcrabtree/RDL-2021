using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDL.Models;
using RDL.ViewModels;

namespace RDL.Controllers
{
    public class TeamsController : Controller
    {
        private ApplicationDbContext _context;

        public TeamsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Teams
        public ActionResult Index()
        {
            var teams = _context.Teams.ToList();
            return View(teams);
        }

        public ActionResult Details(int id)
        {
            var team = _context.Teams.SingleOrDefault(c => c.Id == id);
            return View(team);
        }

        public ActionResult New()
        {
            var viewModel = new NewTeamViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
            return RedirectToAction("Index", "Teams");
        }
        public ActionResult IdentifyTeam()
        {
            return View();
        }
        //[HttpPost]
        public ActionResult AnswerQuestions(int id)
        {
            //int id = Convert.ToInt32(t);
            var team = _context.Teams.SingleOrDefault(c => c.Id == id);
            //Team actualTeam = _context.Teams.Find(team.Id);

            var questions = _context.StemQuestions.ToList();
            var usedquestions = _context.UsedQuestions.ToList();

            List<int> qIds = new List<int>();

            foreach (UsedQuestions q in usedquestions)
            {
                qIds.Add(q.QuestionId);
            }

            if (team.currentQuestionId <= 1001)
            {
                var min = 0;
                var range = 0;
                if (team.division == 2)
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
                //team.currentQuestionId = questNum;
                _context.Teams.Find(team.Id).currentQuestionId = questNum;

                var quest = new UsedQuestions
                {
                    QuestionId = questNum,
                    TeamId = team.Id
                };

                _context.UsedQuestions.Add(quest);
                //team.questions = team.questions + 
                _context.Teams.Find(team.Id).questions = team.questions + 1; 
                _context.SaveChanges();
            }

            var teamQ = new TeamQuestion
            {
                teamId = team.Id,
                questionId = team.currentQuestionId,
                qA = _context.StemQuestions.Find(team.currentQuestionId).AnswerA,
                qB = _context.StemQuestions.Find(team.currentQuestionId).AnswerB,
                qC = _context.StemQuestions.Find(team.currentQuestionId).AnswerC,
                qD = _context.StemQuestions.Find(team.currentQuestionId).AnswerD,
                answer = 0
            };
            _context.TeamQuestions.Add(teamQ);
            _context.SaveChanges();

            /*var viewModel = new StemQViewModel
            {
                team = team,
                question = _context.StemQuestions.Find(team.currentQuestionId)
            };*/

            //return View(viewModel);
            return View(teamQ);
        }
     
        [HttpPost]
        public ActionResult AddPoints(TeamQuestion teamQ)
        {
            var actualTeam = _context.Teams.Find(teamQ.teamId);
            actualTeam.questionAns = teamQ.answer;
            var question = _context.StemQuestions.Find(actualTeam.currentQuestionId);
            System.Diagnostics.Debug.WriteLine("Current Question: " + question.Id);
            if(actualTeam.questionAns == question.correctAns)
            {
                //point value might be different
                _context.Teams.Find(teamQ.teamId).stemQScore = actualTeam.stemQScore + 50;
                //*****DEBUGGING
                System.Diagnostics.Debug.WriteLine("Current STEM Score: " + _context.Teams.Find(teamQ.teamId).stemQScore);
                _context.Teams.Find(teamQ.teamId).Score = actualTeam.Score + 50;
                //*****DEBUGGING
                System.Diagnostics.Debug.WriteLine("Current STEM Score: " + _context.Teams.Find(teamQ.teamId).Score);
                _context.SaveChanges();
            }


            if (actualTeam.questions < 3)
            {
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
                _context.Teams.Find(teamQ.teamId).currentQuestionId = questNum;

                //*****DEBUGGING
                System.Diagnostics.Debug.WriteLine("New Question: " + _context.Teams.Find(teamQ.teamId).currentQuestionId);
                var quest = new UsedQuestions
                {
                    QuestionId = questNum,
                    TeamId = actualTeam.Id
                };

                _context.UsedQuestions.Add(quest);
                //actualTeam.questions = actualTeam.questions + 1;
                _context.Teams.Find(teamQ.teamId).questions = actualTeam.questions + 1;
                //*****DEBUGGING
                System.Diagnostics.Debug.WriteLine("Current Questions Answered: " + _context.Teams.Find(teamQ.teamId).questions);
                _context.SaveChanges();

                return RedirectToAction("AnswerQuestions", new { id = actualTeam.Id });
            } else
            {
                return RedirectToAction("Index", "Teams");
            }
            //return RedirectToAction("Index", "Home");
        }
    }
}