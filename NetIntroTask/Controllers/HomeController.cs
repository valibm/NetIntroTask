using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NetIntroTask.Controllers
{
    public class HomeController :Controller
    {

        List<int> _numbers = new List<int>()
        {
            1, 3, 7, 9, 8, 15, 19, 23, 32, 37
        };

        [Route("home/getnumber/{number}")]
        public IActionResult GetNumber(int number)
        {
            var isExist = _numbers.Exists(n => n == number);
            if (isExist)
            {
                int myNumber = _numbers.Find(n => n == number);
                return View(model: myNumber.ToString());
            }
            else
            {
                return View(model: "Number could not be found.");
            }
        }

        public IActionResult GetPerson()
        {
            var person = new { firstname = "Vali", surname = "Mustafayev", age = 21};

            return Json(person);
        }

        public IActionResult SayHello()
        {
            return Content("Salam");
        }

        
    }
}
