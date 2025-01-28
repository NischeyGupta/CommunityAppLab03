using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;
// using CommunityApp.Models;

namespace CommunityApp.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Province>().HasData(
                new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" },
                new Province { ProvinceCode = "ON", ProvinceName = "Ontario" },
                new Province { ProvinceCode = "AB", ProvinceName = "Alberta" }
            );

            builder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "Vancouver", Population = 706012, ProvinceCode = "BC" },
                new City { CityId = 2, CityName = "Surrey", Population = 633234, ProvinceCode = "BC" },
                new City { CityId = 3, CityName = "Richmond", Population = 222954, ProvinceCode = "BC" },
                new City { CityId = 5, CityName = "Toronto", Population = 3026000, ProvinceCode = "ON" },
                new City { CityId = 6, CityName = "Ottawa", Population = 1072000, ProvinceCode = "ON" },
                new City { CityId = 7, CityName = "London", Population = 448051, ProvinceCode = "ON" },
                new City { CityId = 9, CityName = "Calgary", Population = 1414000, ProvinceCode = "AB" },
                new City { CityId = 10, CityName = "Edmonton", Population = 1087000, ProvinceCode = "AB" },
                new City { CityId = 11, CityName = "Banff", Population = 8305, ProvinceCode = "AB" }
            );
        }
    }
}