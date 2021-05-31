using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labset_1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello, ASP.NET MVC!";
        }


        public int Echo(int id)
        {
            return id;
        }

    }
}
