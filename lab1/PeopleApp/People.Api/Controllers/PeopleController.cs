using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using People.Api.Database;

namespace People.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class PeopleController : ControllerBase
    {
        private readonly ILogger<PeopleController> _logger;
        private PeopleContext context;
        public PeopleController(ILogger<PeopleController> logger, PeopleContext context)
        {
            this.context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var peoples = this.context.Peoples.ToList();

            return Ok(peoples);
        }

        [HttpPost]
        public IActionResult Post([FromBody]People.Api.Domain.People people)
        {
            this.context.Peoples.Add(people);
            this.context.SaveChanges();
            return Get();
        }

        [HttpDelete]
        public IActionResult Remove([FromBody] int id)
        {
            var people = this.context.Peoples.FirstOrDefault(x => x.Id == id);

            if (people != null)
            {
                this.context.Peoples.Remove(people);
                context.SaveChanges();
            }
            return Get();
        }
    }
}
