using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace succus_shop.Models
{
    public class SuccuDbContext:DbContext
    {
        public DbSet<SuccuModel> SuccuModels {get;set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public SuccuDbContext(DbContextOptions<SuccuDbContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }
    }
}
