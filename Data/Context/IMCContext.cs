using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data.Context
{
    public class IMCContext : DbContext
    {
        public IMCContext(DbContextOptions<IMCContext> options)  : base(options)
        {
            
        }

        public DbSet<ConsultaIMC> Consultas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ConsultaIMC>(new ConsultaIMCMap().Configure);

            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=IMC;Trusted_Connection=true;");
        }

    }
}
