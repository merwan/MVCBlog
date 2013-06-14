using System.Collections.Generic;

namespace MVCBlog.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAllPosts();
    }
}