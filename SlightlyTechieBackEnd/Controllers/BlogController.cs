using Microsoft.AspNetCore.Mvc;
using SlightlyTechieBackEnd.Models;
using SlightlyTechieBackEnd.Services.BlogsRepository;

namespace SlightlyTechieBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        readonly IBlogsRepositoryService _blogsRepostory;

        public BlogController(IBlogsRepositoryService blogsRepostory)
        {
            _blogsRepostory = blogsRepostory;
        }

        
        [HttpGet]
        public ActionResult<List<Models.Blog>> Get()
        {
            return Ok(_blogsRepostory.GetBlogs());
        }

       
        [HttpGet("{id}")]
        public ActionResult<Models.Blog> Get(string id)
        {
            var data = _blogsRepostory.GetBlogsById(id);
            if(data == null)
            {
                return NotFound("Blog was not found with Id ="+id);
            }
            else
            {
                return Ok(data);
            }
           
        }
       
        
        [HttpPost]
        public void Post([FromBody] DataModel data)
        {
            _blogsRepostory.AddBlog(data);
        }

        // PUT api/<BlogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _blogsRepostory.DeleteBlog(id);
        }
    }
}
