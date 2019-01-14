using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZhiKeCore.Models
{
    public class ZhikeDbContext : DbContext
    {
        public ZhikeDbContext(DbContextOptions<ZhikeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Field> Fields { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }

}
