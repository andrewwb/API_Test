using APITest.Data;
using APITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Infrastructure
{
    public class BookRepository
    {
        private ApplicationDbContext _db;
        public BookRepository(ApplicationDbContext db) {
            _db = db;
        }

        public IQueryable<Book> GetBooks() {
            return _db.Books;
        }
    }
}
