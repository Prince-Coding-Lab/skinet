using System.Collections.Generic;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly StoreContext _context;
        public UsersController(StoreContext context)
        {

            _context = context;
        }
        // [HttpGet]
        // public ActionResult<IEnumerable<AppUser>> GetUsers()
        // {

        //     var users = _context.Users.ToList();
        //     return users;
        // }
        // public ActionResult<AppUser> GetUser(int id)
        // {

        //     var user = _context.Users.Find(id);
        //     return user;
        // }
    }
}