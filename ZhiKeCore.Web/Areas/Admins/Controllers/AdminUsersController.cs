using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZhiKeCore.Web.Areas.Admins.Controllers
{
    public class AdminUsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}