using System.Web.Mvc;
using MVCBlog.Models;

namespace MVCBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void Index()
        {
            _postRepository.GetAllPosts();
        }
    }
}