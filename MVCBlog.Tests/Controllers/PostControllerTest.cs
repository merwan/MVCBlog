using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MVCBlog.Tests.Controllers
{
    [TestClass]
    public class PostControllerTest
    {
        [TestMethod]
        public void Index()
        {
            Mock<IPostRepository> postRepository = new Mock<IPostRepository>();

            new PostController(postRepository.Object).Index();


            postRepository.Verify(x => x.GetAllPosts());
        }
    }

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

    public interface IPostRepository
    {
        IEnumerable<Post> GetAllPosts();
    }

    public class Post
    {
    }
}