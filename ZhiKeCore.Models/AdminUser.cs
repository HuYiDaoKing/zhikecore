using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZhiKeCore.Models
{
    [Table("AdminUsers")]
    public class AdminUser:Base
    {
        [DisplayName("邮箱")]
        public string Email { get; set; }
        public string PasswordSalt { get; set; }

        [DisplayName("密码")]
        [NotMapped]
        public string Password { get; set; }
        public string RealName { get; set; }
        public string Avatar { get; set; }
    }
}
