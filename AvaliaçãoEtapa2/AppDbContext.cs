using AvaliaçãoEtapa2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace AvaliaçãoEtapa2
{
    public class AppDbContext : DbContext
    {
        public DbSet<Banco> Bancos => Set<Banco>();
        public DbSet<Agencia> Agencias => Set<Agencia>();
        public DbSet<Conta> Contas => Set<Conta>();
        public DbSet<Cliente> Clientes => Set<Cliente>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=banco.db");
        }
    }

}

