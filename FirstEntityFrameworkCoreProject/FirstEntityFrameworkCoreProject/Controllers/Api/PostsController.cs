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
    public class PostsController : ControllerBase
    {
        private readonly ApiContext _context;

        public PostsController(ApiContext context)
        {
            _context = context;
        }

        // GET api/posts
        [HttpGet]
        public async Task<IActionResult> GetAllPostsAsync()
        {
            var posts = await _context.Posts
                .Include(p => p.User)
                .ToListAsync();

            var response = posts.Select(p => new
            {
                id = p.Id,
                content = p.Content,
                userId = p.UserId,
                blogId = p.BlogId,
                user = p.User.FirstName
            });

            return Ok(response);
        }
    }
}