using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZhiKeCore.Models;
using ZhiKeCore.Service.Concrete;
//using ZhiKeCore.EF.Models;

namespace ZhiKeCore.Web.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly ZhikeDbContext _context;
        private readonly AdminUserService _adminUserService;
        private readonly ILogger<AdminUserController> _logger;


        public AdminUserController(ZhikeDbContext context, AdminUserService adminUserService, ILogger<AdminUserController> logger)
        {
            _context = context;
            _adminUserService = adminUserService;
            _logger = logger;
        }


        public IActionResult Index()
        {
            _logger.LogInformation("AdminUserController.Index.");
            return View(_adminUserService.GetAll());
        }
        
    }
}