// using CommunityApp.Models;
using CommunityApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Province>().Property(p => p.ProvinceCode).IsRequired();
            builder.Entity<City>().Property(c => c.CityName).IsRequired();
            builder.Entity<Province>().ToTable("Provinces");
            builder.Entity<City>().ToTable("Cities");
            builder.Seed();
        }
    }
}


// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;

// namespace CommunityApp.Data;

// public class ApplicationDbContext : IdentityDbContext
// {
//     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//         : base(options)
//     { }

//     public DbSet<City> Cities { get; set; }
//     public DbSet<Province> Provinces { get; set; }


//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         base.OnModelCreating(modelBuilder);

//         modelBuilder.Entity<Province>().HasData(
//             new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" },
//             new Province { ProvinceCode = "ON", ProvinceName = "Ontario" },
//             new Province { ProvinceCode = "AB", ProvinceName = "Alberta" }
//         );

//         modelBuilder.Entity<City>().HasData(
//             new City { CityId = 1, CityName = "Vancouver", Population = 706012, ProvinceCode = "BC" },
//             new City { CityId = 2, CityName = "Surrey", Population = 633234, ProvinceCode = "BC" },
//             new City { CityId = 3, CityName = "Richmond", Population = 222954, ProvinceCode = "BC" },
            
//             new City { CityId = 4, CityName = "Toronto", Population = 3026000, ProvinceCode = "ON" },
//             new City { CityId = 5, CityName = "Ottawa", Population = 1072000, ProvinceCode = "ON" },
//             new City { CityId = 6, CityName = "London", Population = 448051, ProvinceCode = "ON" },
            
//             new City { CityId = 7, CityName = "Calgary", Population = 1414000, ProvinceCode = "AB" },
//             new City { CityId = 8, CityName = "Edmonton", Population = 1087000, ProvinceCode = "AB" },
//             new City { CityId = 9, CityName = "Banff", Population = 8305, ProvinceCode = "AB" }
//         );

//         //     modelBuilder.Entity<City>()
//         //         .HasOne(c => c.Province)
//         //         .WithMany(p => p.Cities)
//         //         .HasForeignKey(c => c.ProvinceCode);
//         // }


//     }
// }