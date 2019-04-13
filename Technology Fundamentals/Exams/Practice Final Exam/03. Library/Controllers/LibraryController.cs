using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Library.Data;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var books = db.Books.ToList();
                return this.View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (string.IsNullOrEmpty(book.Author)
                || string.IsNullOrEmpty(book.Title)
                || book.Price.Equals(null)
                || book.Price < 1)
            {
                return RedirectToAction("Index");
            }

            using (var db = new LibraryDbContext())
            {
                Book b = new Book
                {
                    Title = book.Title,
                    Author = book.Author,
                    Price = book.Price
                };

                db.Books.Add(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.Find(id);
                return View(bookToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToDelete = db.Books.Find(id);
                return View(bookToDelete);
            }
            
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}