using BooksController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BooksController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {
        private readonly IBook _book;

        public BooksController(IBook book)
        {
            _book = book
        }
        [HttpGet(Id = " GrazintiPagalId")]
        public IActionResult IndexBookId()
        {
            var bookback = _book.GrazintiPagalId();
            return Ok(bookback);
        }
        [HttpPost(" PridetiNaujaKnyga")]
        public IBook PridetiNaujaKnyga(Book bookup)
        {
            try
            {
                _book.PridetiNaujaKnyga(bookup);
                return Ok();
            }
            catch
            {
                return Problem();
            }
        }
      


    }
}
