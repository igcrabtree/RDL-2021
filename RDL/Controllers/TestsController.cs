using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDL.Models;
using RDL.ViewModels;

namespace RDL.Controllers
{
    public class TestsController : Controller
    {
        private ApplicationDbContext _context;
        public TestsController()
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
        public ActionResult PiTest()
        {
            var Switch = _context.Testing.SingleOrDefault(c => c.Id == 1);
            return View(Switch);
        }

        [HttpPost]
        public ActionResult Change(Testing Test)
        {
            var Switch = _context.Testing.SingleOrDefault(c => c.Id == 1);
            Switch.Switch = Test.Switch;
            _context.SaveChanges();
            return RedirectToAction("ReceiveData", "Tests");
        }

        public ActionResult ReceiveData()
        {
            var Switch = _context.Testing.SingleOrDefault(c => c.Id == 1);

            if (Switch == null)
                return HttpNotFound();

            return View();
        }

        public ActionResult testButton()
        {
            var viewModel = new testViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(Testing test)
        {
            _context.Testing.Add(test);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}