using Microsoft.AspNetCore.Mvc;

namespace EsercizioApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReadBookController : ControllerBase
    {
        private static readonly List<Book> _readBooks = new List<Book>();

        [HttpPost(Name = "PostReadBooks")] //chiedere funzione
        public void PostReadBooks([FromBody] Book value)
        {
            _readBooks.Add(value);
        }

        [HttpGet("ReadBooks")]
        public List<Book> GetAllReadBooks()
        {
            return _readBooks;
        }

        [HttpGet("{value}")]
        public List<Book> GetOneReadBook(string value)
        {
            List<Book> customizedBookResearch = new List<Book>();

            foreach (var book in _readBooks)
            {
                if(book.Author.Contains(value) || book.Title.Contains(value))
                {
                    customizedBookResearch.Add(book);
                }
            }
            return customizedBookResearch;
        }

        [HttpDelete("{barcode}")]
        public List<Book> DeleteOneReadBook(int barcode)
        {
            foreach (var book in _readBooks.ToList())
            {
                if (barcode == book.Barcode)
                {
                    _readBooks.Remove(book);
                }
            }
            return _readBooks;
        }
    }
}