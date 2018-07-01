using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Blog.Controllers
{
    public class BlogController : ApiController
    {
        private readonly BlogContext db;
        public BlogController()
        {
            db = new BlogContext();
        }

        public ICollection<Post> GetAllPosts()
        {
            return db.GetAllPosts();
        }
    }
}
