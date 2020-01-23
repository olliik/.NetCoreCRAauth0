using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyApiContext Context;
        public UserController(MyApiContext context)
        {
            Context = context;
        }

        // Get all
        [HttpGet]
        public IQueryable<object> GetUsers()
        {
            var data = Context.Users.Select(u => new { Id = u.Id, name = u.name, email = u.email });
            return data;
        }

        // Get by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUser(string id)
        {
            var data = await Context.Users.FindAsync(id);
            if (data == null)
            {
                return NotFound("The user was not found.");
            }
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<User>>> PostUser(User u)
        {
            using (Context)
            {
                foreach (User e in Context.Users)
                {
                    if (e.Id == u.Id)
                    {
                        return BadRequest("Error: User not created. (User by that ID already exists)");
                    }
                }
                Context.Users.Add(u);
                await Context.SaveChangesAsync();
                return Ok("New user created: " + u);
            }
        }

        [HttpDelete("{id}", Name = "DeleteById")]
        public async Task<ActionResult<IEnumerable<User>>> DeleteUser(string id)
        {
            var user = await Context.Users.FindAsync(id);
            if (user == null)
            {
                return BadRequest("Error: User by that ID does not exist.");
            }
            Context.Users.Remove(user);
            await Context.SaveChangesAsync();
            return Ok("User deleted: " + user.ToString());
        }

    }
}
