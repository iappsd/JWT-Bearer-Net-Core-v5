using Microsoft.EntityFrameworkCore;
using WebApp.Entities;
using WebApp.Models;

namespace WebApp.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        //private readonly IConfiguration Configuration;
        //public DataContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // in memory database used for simplicity, change to a real db for production applications
        //    options.UseInMemoryDatabase("TestDb");
        //}
    }
}