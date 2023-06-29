using Microsoft.EntityFrameworkCore;
using RPG.Models;

namespace RPG.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Character> Characters => Set<Character>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=1234567;database=dotnet-rpg";

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}