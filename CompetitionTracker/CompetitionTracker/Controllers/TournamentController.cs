using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompetitionTracker.Models;
using CompetitionTracker.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompetitionTracker.Controllers
{
    public class TournamentController : Controller
    {
        private readonly ApplicationDbContext _DbContext;

        public TournamentController(ApplicationDbContext appDbContext) {
            _DbContext = appDbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Competitor> compList =_DbContext.Competitors.ToList();
            return View(compList);
        }
    }
}
