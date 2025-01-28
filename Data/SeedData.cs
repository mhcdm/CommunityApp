using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    // Extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>()
        {
            new Province()
            {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia"
            },
            new Province()
            {
                ProvinceCode = "AB",
                ProvinceName = "Alberta"
            },
            new Province()
            {
                ProvinceCode = "ON",
                ProvinceName = "Ontario"
            },
            new Province()
            {
                ProvinceCode = "CA",
                ProvinceName = "California"
            },
            new Province()
            {
                ProvinceCode = "FL",
                ProvinceName = "Florida"
            },
            new Province()
            {
                ProvinceCode = "IL",
                ProvinceName = "Illinois"
            }
        };

        return provinces;
    }

    public static List<City> GetCities()
    {
        List<City> cities = new List<City>()
        {
            new City()
            {
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
                Province = null 
            },
            new City()
            {
                CityId = 2,
                CityName = "Edmonton",
                Population = 932546,
                Province = null
            },
            new City()
            {
                CityId = 3,
                CityName = "Calgary",
                Population = 1239220,
                Province = null
            },
            new City()
            {
                CityId = 4,
                CityName = "Toronto",
                Population = 2731571,
                Province = null
            },
            new City()
            {
                CityId = 5,
                CityName = "San Jose",
                Population = 1021795,
                Province = null
            },
            new City()
            {
                CityId = 6,
                CityName = "Anaheim",
                Population = 353085,
                Province = null
            },
            new City()
            {
                CityId = 7,
                CityName = "Tampa Bay",
                Population = 387050,
                Province = null
            },
            new City()
            {
                CityId = 8,
                CityName = "Chicago",
                Population = 2695598,
                Province = null
            }
        };

        return cities;
    }
}
