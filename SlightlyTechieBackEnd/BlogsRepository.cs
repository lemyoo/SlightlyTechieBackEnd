using Microsoft.EntityFrameworkCore;
using SlightlyTechieBackEnd.Models;

namespace SlightlyTechieBackEnd
{
    public class BlogsRepository : IBlogsRepository
    {
        public BlogsRepository() 
        {
            using (var context = new ApiContext())
            {
                var blogs = new List<Blog>
                {
                    new Blog {
                        Id = 1,
                        Author = "Johny Cage",
                        Title = "Blog1",
                        Description= "But she refused to let her mom or sister see her.She also refused to go to the hospital to see a doctor because her mom or sister would try to convince her to go home.And by then, it was almost 11"}
                };
                context.Blogs.AddRange(blogs);
                context.SaveChanges();
            }
        }

        public List<Blog> GetBlogs()
        {
            using (var context = new ApiContext())
            {
                var list = context.Blogs.ToList();
                return list;
            }
        }
    }
}
