using CloudData;
using CloudDomain.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ApplicationController : ODataController
    {
        readonly CloudContext Context;
        public ApplicationController(CloudContext context)
        {
            Context = context;
        }

        // GET: api/<ApplicationController>
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<Application>>> Get()
        {
            return await Context.Application.ToListAsync();
        }

        // GET api/<ApplicationController>/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Application>> Get(int id)
        //{
        //    var res = await Context.Applications.Where(w => w.ID == id).FirstOrDefaultAsync();

        //    if (res == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return res;
        //    }
        //}

        // POST api/<ApplicationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApplicationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApplicationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
