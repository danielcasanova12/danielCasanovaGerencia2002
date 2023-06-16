﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gerencia.Models;

#nullable disable

namespace gerencia.Migrations
{
    [DbContext(typeof(EventosContext))]
    [Migration("20230616134131_v21")]
    partial class v21
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("gerencia.Models.Evento", b =>
                {
                    b.Property<int>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CriadorEventoIdUsuario")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoEvento")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("HorarioEvento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCriadorEvento")
                        .HasColumnType("int");

                    b.Property<string>("LocalizacaoEvento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeEvento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PrivacidadeEvento")
                        .HasColumnType("int");

                    b.HasKey("IdEvento");

                    b.HasIndex("CriadorEventoIdUsuario");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("gerencia.Models.Guest", b =>
                {
                    b.Property<int>("IdGuest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EventoGuestIdEvento")
                        .HasColumnType("int");

                    b.Property<int>("IdEventoGuest")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioGuestIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdGuest");

                    b.HasIndex("EventoGuestIdEvento");

                    b.HasIndex("UsuarioGuestIdUsuario");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("gerencia.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("gerencia.Models.Evento", b =>
                {
                    b.HasOne("gerencia.Models.Usuario", "CriadorEvento")
                        .WithMany()
                        .HasForeignKey("CriadorEventoIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CriadorEvento");
                });

            modelBuilder.Entity("gerencia.Models.Guest", b =>
                {
                    b.HasOne("gerencia.Models.Evento", "EventoGuest")
                        .WithMany("GuestsEvento")
                        .HasForeignKey("EventoGuestIdEvento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gerencia.Models.Usuario", "UsuarioGuest")
                        .WithMany()
                        .HasForeignKey("UsuarioGuestIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventoGuest");

                    b.Navigation("UsuarioGuest");
                });

            modelBuilder.Entity("gerencia.Models.Evento", b =>
                {
                    b.Navigation("GuestsEvento");
                });
#pragma warning restore 612, 618
        }
    }
}