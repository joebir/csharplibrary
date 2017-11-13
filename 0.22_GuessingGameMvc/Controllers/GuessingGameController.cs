using _0._22_GuessingGameMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0._22_GuessingGameMvc.Controllers
{
    public class GuessingGameController : Controller
    {
        // GET: GuessingGame
        public ActionResult Index()
        {
            Session["answer"] = new Random().Next(1, 11);

            return View();
        }

        private bool GuessWasCorrect(int guess) =>
            guess == (int)Session["answer"];

        // POST: GuessingGame
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GameModel model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }

            return View(model);
        }
    }
}