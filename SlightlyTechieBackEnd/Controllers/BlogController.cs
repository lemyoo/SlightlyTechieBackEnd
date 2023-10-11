using Microsoft.AspNetCore.Mvc;

namespace SlightlyTechieBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        readonly IBlogsRepository _blogsRepostory;

        public BlogController(IBlogsRepository blogsRepostory)
        {
            _blogsRepostory = blogsRepostory;
        }

        
        [HttpGet]
        public ActionResult<List<Models.Blog>> Get()
        {
            return Ok(_blogsRepostory.GetBlogs());
        }

        // GET api/<BlogController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BlogController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
