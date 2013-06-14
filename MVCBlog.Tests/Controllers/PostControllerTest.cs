using MVCBlog.Controllers;
using MVCBlog.Models;
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
}