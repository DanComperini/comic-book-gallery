using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller           // MVC controller class
    {
        private ComicBookRepository _comicBookRepository = null;

        // Instance of repository Constructor
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)                             // Action Method
        {
            
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
           
            return View(comicBook);
        }

    }
}