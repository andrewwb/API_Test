using APITest.Infrastructure;
using APITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Services
{
    public class BookService
    {
        private BookRepository _repo;
        public BookService(BookRepository repo) {
            _repo = repo;
        }

        public IEnumerable<Book> GetBooks() {
            return _repo.GetBooks().ToList();
        }
    }
}
