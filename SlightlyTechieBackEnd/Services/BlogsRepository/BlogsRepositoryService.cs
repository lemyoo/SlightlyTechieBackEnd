using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SlightlyTechieBackEnd.Models;

namespace SlightlyTechieBackEnd.Services.BlogsRepository
{
    public class BlogsRepositoryService : IBlogsRepositoryService
    {
        public BlogsRepositoryService()
        {

            using (var context = new ApiContext())
            {
                if (context.Blogs.Count() == 0)
                {
                    CreateFirstData();
                }
            }
        }

        private void CreateFirstData()
        {
            using (var context = new ApiContext())
            {
                var blogs = new List<Blog>
                {
                    new Blog {
                        Id = new Guid(Guid.NewGuid().ToString()),
                        Author = "Johny Cage",
                        Title = "Blog1",
                        Description= "But she refused to let her mom or sister see her.She also refused to go to the hospital to see a doctor because her mom or sister would try to convince her to go home.And by then, it was almost 11"}
                };
                context.Blogs.AddRange(blogs);
                context.SaveChanges();
            }
        }

        public void AddBlog(DataModel data)
        {
            using (var context = new ApiContext())
            {
               var blog = new Blog
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Author = data.Author,
                    Title = data.Title,
                    Description = data.Description,
                };

                context.Blogs.Add(blog);
                context.SaveChanges();
            }
        }

        public void DeleteBlog(string id)
        {
            using (var context = new ApiContext())
            {
                var blog = context.Blogs.SingleOrDefault(b => b.Id.ToString() == id);

                if (blog != null)
                {
                    context.Blogs.Remove(blog);

                    context.SaveChanges();
                }
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

        public Blog GetBlogsById(string id)
        {
            
            using (var context = new ApiContext())
            {
                var blog = context.Blogs.SingleOrDefault(b => b.Id.ToString() == id);
                
                return blog;
            }
        }
    }
}
