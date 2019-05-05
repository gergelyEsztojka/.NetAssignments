using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstEntityFrameworkCoreProject.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly ApiContext _context;

        public BlogsController(ApiContext context)
        {
            _context = context;
        }

        // GET api/blogs
        [HttpGet]
        public async Task<IActionResult> GetAllBlogs()
        {
            var blogs = await _context.Blogs
                .Include(b => b.Posts)
                .ToArrayAsync();

            var response = blogs.Select(b => new
            {
                id = b.Id,
                name = b.Name,
                url = b.Url,
                posts = b.Posts.Select(p => p.Content)
            });

            return Ok(response);
        }
    }
}