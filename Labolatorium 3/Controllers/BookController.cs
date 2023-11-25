using Microsoft.AspNetCore.Mvc;
using Labolatorium_3.Models;

namespace Labolatorium_3.Controllers
{
    public class BookController : Controller
    {
        static Dictionary<int, Book> _contacts = new Dictionary<int, Book>();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book) {
        if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
        return View(book);
        }
    }
}
