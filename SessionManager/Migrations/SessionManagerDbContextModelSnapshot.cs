﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SessionManager.Data;
using SessionManager.Models;
using System;

namespace SessionManager.Migrations
{
    [DbContext(typeof(SessionManagerDbContext))]
    partial class SessionManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SessionManager.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Alignment");

                    b.Property<string>("Name");

                    b.Property<int?>("RaceId");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("SessionManager.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Size");

                    b.Property<int>("Speed");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("SessionManager.Models.Character", b =>
                {
                    b.HasOne("SessionManager.Models.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId");
                });
#pragma warning restore 612, 618
        }
    }
}
