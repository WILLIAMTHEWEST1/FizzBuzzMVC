using FizzBuzzMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        public IActionResult FizzBuzz()
        {
            var model = new FizzBuzz();
            return View(model);
        }

        [HttpPost]
        public IActionResult FizzBuzz(FizzBuzz model)
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % model.FizzValue == 0 && i % model.BuzzValue == 0)
                {
                    model.Results.Add("FizzBuzz");
                }
                else if (i % model.FizzValue == 0)
                {
                    model.Results.Add("Fizz");
                }
                else if (i % model.BuzzValue == 0)
                {
                    model.Results.Add("Buzz");
                }
                else
                {
                    model.Results.Add(i.ToString());
                }
            }

            var test = model.Results.Count;

            return View(model);
        }

    }
}
