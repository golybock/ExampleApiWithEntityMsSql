using ExampleApiWithEntityMsSql.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApiWithEntityMsSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ExampleDatabaseContext _context;

        public RoleController(ExampleDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("GetRole")]
        public IActionResult GetRole(int id)
        {
            return new OkObjectResult(_context.Roles.FirstOrDefault(c => c.Id == id));
        }

        [HttpGet("GetRoles")]
        public IActionResult GetRoles()
        {
            return new OkObjectResult(_context.Roles.ToList());
        }

        [HttpPost("AddRole")]
        public IActionResult AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return new OkResult();
        }
        
        [HttpDelete]
        public IActionResult DeleteRole(int id)
        {
            Role role = _context.Roles.FirstOrDefault(c => c.Id == id);
            _context.Roles.Remove(role);
            _context.SaveChanges();
            return new OkResult();
        }
        
    }
}
