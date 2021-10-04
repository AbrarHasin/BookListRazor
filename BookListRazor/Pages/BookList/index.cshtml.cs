using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class indexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public indexModel(ApplicationDBContext db) // using dependency injection db
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet() //handler
        {
            Books = await _db.Book.ToListAsync(); //retriving all the books
        }
    }
}
