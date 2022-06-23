using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDL.Models;
using RDL.ViewModels;

namespace RDL.Controllers
{
    public class ClockController : Controller
    {
        // GET: Clock
        private ApplicationDbContext _context;

        public ClockController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Start()
        {
            var fogmachine = _context.Blue.SingleOrDefault(c => c.Id == 1);
            return View(fogmachine);
        }

        [HttpPost]
        public ActionResult Change(Blue updatedBlue)
        {
            var blue = _context.Blue.SingleOrDefault(c => c.Id == 1);
            var red = _context.Red.SingleOrDefault(c => c.Id == 2);
            blue.fogMachine = updatedBlue.fogMachine;
            red.rFogMachine = updatedBlue.fogMachine;
            blue.fan = updatedBlue.fan;
            _context.SaveChanges();
            return null;
        }
    }
}