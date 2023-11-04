using System;
using Microsoft.EntityFrameworkCore;
using Crud.Models;

namespace Crud.Datos
{
	public class ContextoBD:DbContext
	{
		public ContextoBD(DbContextOptions<ContextoBD> options):base(options)
		{
			
		}
		public DbSet<Usuarios> usuarios { get; set; }

	}
}
