using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class EmployeeDbContext : DbContext
    {
		public DbSet<employee> employees { get; set; }

		public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
		 : base(options)
		{

		}

	}
}
