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
    [Migration("20180329161056_Ability Scores for Character, Race, Subrace")]
    partial class AbilityScoresforCharacterRaceSubrace
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SessionManager.Models.Alignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Alignments");
                });

            modelBuilder.Entity("SessionManager.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlignmentId");

                    b.Property<int>("Charisma");

                    b.Property<int?>("ClassId");

                    b.Property<int>("Constitution");

                    b.Property<int>("Dexterity");

                    b.Property<int>("Experience");

                    b.Property<int>("Intelligence");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int>("Speed");

                    b.Property<int>("Strength");

                    b.Property<int?>("SubraceId");

                    b.Property<int>("Wisdom");

                    b.HasKey("Id");

                    b.HasIndex("AlignmentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubraceId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("SessionManager.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("SessionManager.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Charisma");

                    b.Property<int>("Constitution");

                    b.Property<int>("Dexterity");

                    b.Property<int>("Intelligence");

                    b.Property<string>("Name");

                    b.Property<int>("Strength");

                    b.Property<int>("Wisdom");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("SessionManager.Models.Subrace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Charisma");

                    b.Property<int>("Constitution");

                    b.Property<int>("Dexterity");

                    b.Property<int>("Intelligence");

                    b.Property<string>("Name");

                    b.Property<bool>("Playable");

                    b.Property<int?>("RaceId");

                    b.Property<int>("Size");

                    b.Property<int>("Speed");

                    b.Property<int>("Strength");

                    b.Property<int>("Wisdom");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("Subraces");
                });

            modelBuilder.Entity("SessionManager.Models.Character", b =>
                {
                    b.HasOne("SessionManager.Models.Alignment", "Alignment")
                        .WithMany()
                        .HasForeignKey("AlignmentId");

                    b.HasOne("SessionManager.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("SessionManager.Models.Subrace", "Subrace")
                        .WithMany()
                        .HasForeignKey("SubraceId");
                });

            modelBuilder.Entity("SessionManager.Models.Subrace", b =>
                {
                    b.HasOne("SessionManager.Models.Race", "Race")
                        .WithMany("Subraces")
                        .HasForeignKey("RaceId");
                });
#pragma warning restore 612, 618
        }
    }
}
