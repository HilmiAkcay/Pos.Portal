using AutoMapper;
using CloudDomain.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Pos.Application.Dtos.Page;
using Pos.Domain.Interface;

namespace Pos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : Controller
    {

        readonly IPageRepository _repository;

        public PageController(IPageRepository repository)
        {
            _repository = repository;
        }


        // GET: api/<ApplicationController>
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<Page>>> Get()
        {
            var res = await _repository.GetAllAsync();

            return Ok(res);
        }

        [HttpPost]
        [EnableQuery]
        public async Task<IActionResult> Post([FromBody] PageCreateDto page)
        {
            Page pageEntity = new Page();
            pageEntity.Name = page.Name;
            pageEntity.PurePosId = page.PurePosId;
            var returnItem = await _repository.AddAsync(pageEntity);

            return CreatedAtAction(nameof(GetPageById), new { id = returnItem.ID }, returnItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] PageCreateDto page)
        {
            if (page == null || page.ID != id)
            {
                return BadRequest();
            }

            var existingPage = await _repository.GetByIdAsync(id);
            if (existingPage == null)
            {
                return NotFound();
            }

            Page pageEntity = new Page();
            pageEntity.Name = page.Name;
            pageEntity.PurePosId = page.PurePosId;

           await _repository.UpdateAsync(pageEntity);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            bool success = await _repository.DeleteAsync(id);

            return success ? NoContent() : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPageById(int id)
        {
            var page = await _repository.GetByIdAsync(id);
            if (page == null)
            {
                return NotFound();
            }

            return Ok(page);
        }
    }
}
