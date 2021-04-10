using Blazor.CRUD.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace Blazor.CRUD.Server.Data
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
		{
		}
		public DbSet<Developer> Developers { get; set; }
	}
}
