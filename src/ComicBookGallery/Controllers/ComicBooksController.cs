using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller           // MVC controller class
    {

        public ActionResult Detail()                             // Action Method
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");
            }

            return Content("Hello from the comic books controller!");


        }

    }
}