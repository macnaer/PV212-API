using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var news = await _newsService.GetAll();
            return Ok(news);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var news = await _newsService.Get(Id);
            return Ok(news);
        }

        [HttpPost("GetByCategory")]
        public async Task<IActionResult> GetByCategory(int id)
        {
            var news = await _newsService.GetByCategory(id);
            return Ok(news);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(News model)
        {
            await _newsService.Insert(model);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(News model)
        {
            await _newsService.Update(model);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _newsService.Delete(Id);
            return Ok();
        }
    }
}
