using System.Threading.Tasks;
using Boilerplate.Api.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Boilerplate.Api.Controllers.v1
{
    public class ProductController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductRequest request)
        {
            return Created("","");
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateProductRequest request)
        {
            return Ok();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}