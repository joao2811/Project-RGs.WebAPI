﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto1.Data;

namespace Projeto1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190830134959_commit1")]
    partial class commit1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Projeto1.Models.RG", b =>
                {
                    b.Property<int>("RgId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RgCpf");

                    b.Property<string>("RgDataDeNascimento");

                    b.Property<string>("RgNaturalidade");

                    b.Property<string>("RgNome");

                    b.Property<string>("RgNomeMae");

                    b.Property<string>("RgNomePai");

                    b.Property<string>("RgNumber");

                    b.HasKey("RgId");

                    b.ToTable("RGs");
                });
#pragma warning restore 612, 618
        }
    }
}
