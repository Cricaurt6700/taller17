using System;
using System.Linq;
using System.Web.Mvc;

namespace Taller3.Controllers
{
    public class AuthorController : Controller
    {
        booksEntities db = new booksEntities();

        public ActionResult Index(string searching)
        {
            var author = from s in db.authors select s;

            if (!String.IsNullOrEmpty(searching)) {
                author = author.Where(s => s.au_fname.Contains(searching));
            }

            return View(author.ToList());
        }
    }
}