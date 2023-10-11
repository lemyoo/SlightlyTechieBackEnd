using SlightlyTechieBackEnd.Models;

namespace SlightlyTechieBackEnd
{
    public interface IBlogsRepository
    {
        public List<Blog> GetBlogs();
    }
}
