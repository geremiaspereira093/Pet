﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Models;

namespace PetShop.Migrations
{
    [DbContext(typeof(PetContext))]
    partial class PetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PetShop.Models.Agendamento", b =>
                {
                    b.Property<int>("AgendamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Petivery")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Serviços")
                        .HasColumnType("INTEGER");

                    b.HasKey("AgendamentoId");

                    b.ToTable("Agendamento");
                });

            modelBuilder.Entity("PetShop.Models.Cadastro", b =>
                {
                    b.Property<int>("CadastroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CPF")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Especie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomePet")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeTutor")
                        .HasColumnType("TEXT");

                    b.Property<long>("Telefone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("confirmaSenha")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("senha")
                        .HasColumnType("TEXT");

                    b.HasKey("CadastroId");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("PetShop.Models.Login", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Senha")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Usuario")
                        .HasColumnType("TEXT");

                    b.HasKey("LoginId");

                    b.ToTable("Login");
                });
#pragma warning restore 612, 618
        }
    }
}