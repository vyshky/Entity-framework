using System.IO;
using EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF.Lib
{
    public sealed class DataBase : DbContext
    {
        public DbSet<Games> TabGames { get; set; }

        private DataBase()
        {
        }

        public DataBase(DbContextOptions<DataBase> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public static DataBase Init()
        {
            ConfigurationBuilder builder = new();
            builder.SetBasePath(Directory.GetCurrentDirectory()); // методы расширения
            builder.AddJsonFile("connect_to_db_config.json");
            string connectionString = builder.Build().GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<DataBase>()
                .UseMySQL(connectionString)
                .Options;
            return new DataBase(options);
        }
    }
}