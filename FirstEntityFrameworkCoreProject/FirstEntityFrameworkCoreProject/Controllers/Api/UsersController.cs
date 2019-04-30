using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEntityFrameworkCoreProject.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstEntityFrameworkCoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly ApiContext _context;

        public UsersController(ApiContext context)
        {
            _context = context;
        }

        // GET api/users
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _context.Users
                .Include(u => u.Posts)
                .ToArrayAsync();

            var response = users.Select(u => new 
            {
                firstName = u.FirstName,
                lastName = u.LastName,
                posts = u.Posts.Select(p => p.Content)
            });

            return Ok(response);
        }
    }
}