using Microsoft.EntityFrameworkCore;
using serverside.Model;
using System;

namespace serverside.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<CityModel> cities { get; set; }    
        public DbSet<CountryModel> country { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CityModel>().HasIndex(m => m.uuid).IsUnique();
            modelBuilder.Entity<CountryModel>().HasIndex(m => m.uuid).IsUnique();


            modelBuilder.Entity<CountryModel>().HasData(
                new CountryModel {ID = 1, name = "Indonesia", latitude=20, longtitude=203, uuid = System.Guid.NewGuid().ToString() },
                new CountryModel { ID = 2, name = "America", latitude = 30, longtitude = 303, uuid = System.Guid.NewGuid().ToString() },
                new CountryModel { ID = 3, name = "China", latitude = 40, longtitude = 403, uuid = System.Guid.NewGuid().ToString() }
           );

            modelBuilder.Entity<CityModel>().HasData(
                new CityModel {
                    ID = 1,
                    name = "Bandung", 
                    countryID=(long)1, 
                    dew_point=2,
                    pressure=203,
                    location=222,
                    relative_humidility=232,
                    sky_condition="rain",
                    temp_celcius=20,
                    temp_fahrenheit=30,
                    time=DateTime.Now.AddHours(2),
                    uuid=System.Guid.NewGuid().ToString(),
                    wind = 222,
                    visibility = 7002
                },
                new CityModel
                {
                    ID = 2,
                    name = "Jakarta",
                    countryID = (long)1,
                    dew_point = 2,
                    pressure = 431,
                    location = 232,
                    relative_humidility = 522,
                    sky_condition = "rain",
                    temp_celcius = 10,
                    temp_fahrenheit = 5,
                    time = DateTime.Now.AddHours(2),
                    uuid = System.Guid.NewGuid().ToString(),
                    wind = 2222,
                    visibility = 7003
                },
                new CityModel
                {
                    ID = 3,
                    name = "New York",
                    countryID = (long)2,
                    dew_point = 3,
                    pressure = 455,
                    location = 231,
                    relative_humidility = 123,
                    sky_condition = "rain",
                    temp_celcius = 15,
                    temp_fahrenheit = 19,
                    time = DateTime.Now.AddHours(7),
                    uuid = System.Guid.NewGuid().ToString(),
                    wind = 222,
                    visibility = 703
                },
                new CityModel
                {
                    ID = 4,
                    name = "Washington",
                    countryID = (long)2,
                    dew_point = 3,
                    pressure = 123,
                    location = 456,
                    relative_humidility = 789,
                    sky_condition = "rain",
                    temp_celcius = 9,
                    temp_fahrenheit = 7,
                    time = DateTime.Now.AddHours(7),
                    uuid = System.Guid.NewGuid().ToString(),
                    wind = 333,
                    visibility = 7023
                },
                new CityModel
                {
                    ID = 5,
                    name = "Maoming",
                    countryID = (long)3,
                    dew_point = 4,
                    pressure = 444,
                    location = 555,
                    relative_humidility = 666,
                    sky_condition = "rain",
                    temp_celcius = 13,
                    temp_fahrenheit = 44,
                    time = DateTime.Now.AddHours(4),
                    uuid = System.Guid.NewGuid().ToString(),
                    wind = 456,
                    visibility = 7233
                },
                new CityModel
                {
                    ID = 6,
                    name = "Beijing",
                    countryID = (long)3,
                    dew_point = 5,
                    pressure = 555,
                    location = 666,
                    relative_humidility = 777,
                    sky_condition = "rain",
                    temp_celcius = 14,
                    temp_fahrenheit = 22,
                    time = DateTime.Now.AddHours(4),
                    uuid = System.Guid.NewGuid().ToString(),
                    wind = 657,
                    visibility = 7233
                }
            );


        }


    }
}
