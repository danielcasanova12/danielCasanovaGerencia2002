using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.VisualStudio.OLE.Interop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace gerencia.Model
{
    public class EventosContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Guest> Guests { get; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=gerenciamento.db");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>()
                .HasKey(g => g.IdGuest);

            modelBuilder.Entity<Guest>()
                .HasOne(g => g.Evento)
                .WithMany(e => e.Guests)
                .HasForeignKey(g => g.IdEvento);

            modelBuilder.Entity<Guest>()
                .HasOne(g => g.UsuarioConvidado)
                .WithMany()
                .HasForeignKey(g => g.IdUsuario);

            base.OnModelCreating(modelBuilder);
        }


    }



}



