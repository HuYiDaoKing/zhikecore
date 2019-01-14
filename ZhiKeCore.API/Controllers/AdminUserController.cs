using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using ZhiKeCore.Service;

namespace ZhiKeCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        public AdminUserController()
        {
            //if (_context.AdminUser.Count() == 0)
            //{
            //    // Create a new TodoItem if collection is empty,
            //    // which means you can't delete all TodoItems.
            //    _context.AdminUser.Add(new AdminUser {

            //    });
            //    _context.SaveChanges();
            //}
        }

        // GET: api/Todo
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<AdminUser>>> GetAdminUsers()
        //{
        //    //return await _context.TodoItems.ToListAsync();
        //    AdminUserRepository
        //    AdminUserServices service = new AdminUserServices();
        //    return await service.Query(c=>c.IsUse==true);
        //}

    }
}