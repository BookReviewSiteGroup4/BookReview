using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookReview.Data;
using BookReview.Models;
using BookReview.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookReview.Controllers
{
    public class BooksController : Controller
    {
        private readonly DbCon _context;

        public BooksController(DbCon context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var dbCon = _context.Book.Include(b => b.Author);
            return View(await dbCon.ToListAsync());
        }

        // GET: Books/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var book = _context.Book.Where(b => b.Id == id).Include(b => b.Author).FirstOrDefault();

            if (book == null)
            {
                return NotFound();
            }

            var reviews = _context.Review.Where(r => r.BookID == id);

            var author = book.Author;

            BookViewModel bvm = new BookViewModel();
            bvm.Book = book;
            bvm.Reviews = reviews;
            bvm.Author = author;

            if(reviews.Where(x => x.BookID == id).Any())
            {
                bvm.Book.AverageRating = reviews.Where(x => x.BookID == id).Average(c => c.ReviewScore);
                bvm.Book.AverageRating = Math.Round(bvm.Book.AverageRating, 1);
            }

            return View(bvm);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["AuthorID"] = new SelectList(_context.Author, "Id", "FullName");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ISBN,AuthorID")] Book book)
        {

            if (CheckIfISBNisValid(book.ISBN))
            {
                ModelState.AddModelError("ISBN", "ISBN finns redan i databasen");
                ViewData["AuthorID"] = new SelectList(_context.Author, "Id", "FullName");
                return View();
            }

            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorID"] = new SelectList(_context.Author, "Id", "FullName", book.AuthorID);
            return View(book);
        }

        private bool CheckIfISBNisValid(int ISBN)
        {
            if(_context.Book.Any(x => x.ISBN == ISBN))
            {
                return true;
            }

            return false;
           
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorID"] = new SelectList(_context.Author, "Id", "FullName", book.AuthorID);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,ISBN,AuthorID")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorID"] = new SelectList(_context.Author, "Id", "FullName", book.AuthorID);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Book.FindAsync(id);
            _context.Book.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.Id == id);
        }
    }
}
