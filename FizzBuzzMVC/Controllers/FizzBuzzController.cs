using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        private string ToFizzBuzz(int num)
        {
            var isDivisibleByFive = num % 5 == 0;
            var isDivisibleByThree = num % 3 == 0;

            if (isDivisibleByFive && isDivisibleByThree) return "FizzBuzz";
            if (isDivisibleByFive) return "Buzz";
            if (isDivisibleByThree) return "Fizz";

            return $"{num}";
        }

        // GET: FizzBuzz
        public ActionResult Index()
        {
            var model = Enumerable.Range(1, 100).Select(ToFizzBuzz);
            return View(model);
        }
    }
}