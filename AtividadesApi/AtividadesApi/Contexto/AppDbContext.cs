using System;
using Microsoft.EntityFrameworkCore;

namespace AtividadesApi.Contexto
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<Atividade> Atividades { get; set; }
	}
}

