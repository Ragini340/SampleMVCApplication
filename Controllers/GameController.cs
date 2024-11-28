using SampleMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApplication.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Random()
        {
            var game = new Game()
            {
                Name = "Kabaddi"
            };
            return View(game);
        }
    }
}