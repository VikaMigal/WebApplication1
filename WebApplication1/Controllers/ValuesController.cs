using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Norm;
using WebApplication1.Contracts;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //private MongoDbContext _repo;
        private IRepositoryBase _repo;
        
 
        public ValuesController(IRepositoryBase repo)
        {
            _repo = repo;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //ar domesticAccounts = _repo.Owner.FindByCondition(x => x.AccountType.Equals("Domestic"));
//            var owners = _repo.All<User>().OrderBy(d => d.Login).ToList();

         
//            _repo.Add<User>(new User {
//                Login = "sdsgdg",
//                Password = "sdfsd",
//                Email = "sdfsd",
//                PhoneNumber = "sdfsd",
//                Sex = 0
//            });

            var owners = _repo.All<User>().FirstOrDefault(x => x.Login == "test1");
            return Ok(new {owners});
           
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}