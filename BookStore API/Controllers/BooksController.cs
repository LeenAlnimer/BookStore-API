using BookStore_API.Data;
using BookStore_API.Models;
using BookStore_API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookDbContext _context;

        public BooksController(BookDbContext context)
        {
            _context = context;
        }

        // GET: api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Books.ToList());
        }

        // GET: api/books/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }

        // POST: api/books
        [HttpPost]
        public IActionResult Create(CreateBookDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                Author = dto.Author,
                Year = dto.Year
            };

            _context.Books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }

        // PUT: api/books/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateBookDto dto)
        {
            var book = _context.Books.Find(id);
            if (book == null)
                return NotFound();

            book.Title = dto.Title;
            book.Author = dto.Author;
            book.Year = dto.Year;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/books/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
                return NotFound();

            _context.Books.Remove(book);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
