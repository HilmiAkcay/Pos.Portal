using CloudDomain.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Pos.Domain.Model;
using Pos.EfCore.Context;

namespace Pos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : Controller
    {

        readonly CloudContext Context;

        public PageController(CloudContext context)
        {
            Context = context;
        }


        // GET: api/<ApplicationController>
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<Page>>> Get()
        {
            var res =  Context.Page.AsAsyncEnumerable();

            return Ok(res);
        }

        [HttpPost]
        [EnableQuery]
        public void Post([FromBody] PageModelCreate page)
        {
        }
    }
}
