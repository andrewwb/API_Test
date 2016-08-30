using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APITest.Services;
using APITest.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private BookService _service;
        public BooksController(BookService service) {
            _service = service;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _service.GetBooks();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
