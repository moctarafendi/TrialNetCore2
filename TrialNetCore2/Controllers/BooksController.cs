using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrialNetCore2.IService;
using TrialNetCore2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrialNetCore2.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Pengolahan Data Buku";
            var books = _bookRepository.GetAllBooks();
            return View(books);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var book = _bookRepository.GetBookById(Convert.ToInt32(id));
            if (book == null)
                return NotFound();

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if(ModelState.IsValid && book != null)
            {
                _bookRepository.Insert(book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var book = _bookRepository.GetBookById(Convert.ToInt32(id));
            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.Update(book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var book = _bookRepository.GetBookById(Convert.ToInt32(id));
            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _bookRepository.Delete(Convert.ToInt32(id));
            return RedirectToAction("Index");

        }
        
    }
}
