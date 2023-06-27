using Microsoft.EntityFrameworkCore;

namespace Stock
{
    public class Context : DbContext
    {
        public DbSet<Checkin> Checkin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;user=root;database=stock;password=Rfhfylfitkm12r;";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(5, 7, 21)));
        }
    }
}
