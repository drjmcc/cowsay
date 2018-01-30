using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cowsay.Controllers
{
    public class HomeController : Controller
    {
        [Route("cow/{message?}")]
        public string Cow(string message)
        {
            if (String.IsNullOrEmpty(message))
                message = "Hi. My name is Dr Cow Pat.";

            return Cowsay.GetCowsay(message, AnimalMode.Wired);
        }
    }
}
