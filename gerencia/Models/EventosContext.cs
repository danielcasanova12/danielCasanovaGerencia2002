using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gerencia.Models;

namespace gerencia.Models

{
    public class EventosContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Guest> Guests { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql("server=localhost;database=db;user=root;password=",
                                    new MySqlServerVersion("10.4.28-MariaDB")); // versão do servidor MySQL
        }
    }
}