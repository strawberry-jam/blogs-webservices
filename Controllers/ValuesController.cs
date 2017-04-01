using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        BlogDatabaseContext dbContext;
        public ValuesController(BlogDatabaseContext dbContext) {
            this.dbContext = dbContext;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return dbContext.Blogs;
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
