using System;
using System.Collections.Generic;
using System.Text;
using ZhiKeCore.Models;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace ZhiKeCore.Service.Concrete
{
    public class AdminUserService
    {
        private readonly ZhikeDbContext _context;
        private readonly ILogger<AdminUserService> _logger;
        public AdminUserService(ZhikeDbContext context,ILogger<AdminUserService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public List<AdminUser> GetAll()
        {
            _logger.LogInformation("AdminUserController.Index.");
            return _context.AdminUsers.ToList();
        }
    }
}
