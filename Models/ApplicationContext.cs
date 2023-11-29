using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AspNetMVC.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)

        {

            Database.EnsureCreated();
        }
    }
}
