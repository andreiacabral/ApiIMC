using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class IMCContext : DbContext
    {
        public IMCContext(DbContextOptions<IMCContext> options)
    : base(options)
        {
        }

        public DbSet<ConsultaIMC> Consultas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ConsultaIMC>(new ConsultaIMCMap().Configure);
        }

    }
}
