using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingStudyingApp.Controllers
{
    public class GoalController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["GoalIndexMessage"] = "Please set or edit your goals in here.";
            ViewData["SetGoalsMessage"] = "Please set your goals in here.";
            ViewData["EditGoalsMessage"] = "Please edit your goals in here.";
            return View();
        }

        public IActionResult SetGoals()
        {
            ViewData["SetGoalsMessage"] = "Please set your goals in here.";
            return View();
        }
    }
}
