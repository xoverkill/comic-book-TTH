using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookTTH.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail() {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday) {
                return Redirect("/");
            }

            return Content("Hello");
            
        }
    }
}
