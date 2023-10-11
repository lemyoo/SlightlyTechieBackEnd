using SlightlyTechieBackEnd.Models;

namespace SlightlyTechieBackEnd.Services.BlogsRepository
{
    public interface IBlogsRepositoryService
    {
        public List<Blog> GetBlogs();

        public Blog GetBlogsById(string id);

        public void AddBlog(DataModel data);

        public void DeleteBlog(string id);
    }
}
