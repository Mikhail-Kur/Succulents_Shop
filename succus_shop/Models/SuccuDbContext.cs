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

        public SuccuDbContext(DbContextOptions<SuccuDbContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
            
            if (!SuccuModels.Any())
            {
                SuccuModels.Add(new SuccuModel {
                    Name = "Пулидонис",
                    Description = "Распространнёный суккулент, очень красив и не требует много ухода",
                    IsAvialible = true,
                    Size = 8,
                    Species = "Echeveria"
                }) ;
                SuccuModels.Add(new SuccuModel
                {
                    Name = "Пулидонис",
                    Description = "Распространнёный суккулент, очень красив и не требует много ухода",
                    IsAvialible = true,
                    Size = 8,
                    Species = "Echeveria"
                });
                SuccuModels.Add(new SuccuModel
                {
                    Name = "Опалина",
                    Description = "маленькая красотка",
                    IsAvialible = false,
                    Size = 4,
                    Species = "Graptoveria"
                });
                SaveChanges();
            }
        }
    }
}
