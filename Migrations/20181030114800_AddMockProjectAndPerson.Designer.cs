﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLightHouse;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NLightHouse.Migrations
{
    [DbContext(typeof(NLighthouseDbContext))]
    [Migration("20181030114800_AddMockProjectAndPerson")]
    partial class AddMockProjectAndPerson
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("NLightHouse.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("PersonId1");

                    b.Property<string>("PersonId2");

                    b.Property<string>("PersonId3");

                    b.HasKey("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("PersonId2");

                    b.HasIndex("PersonId3");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("NLightHouse.Models.Project", b =>
                {
                    b.Property<string>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("PurposeId");

                    b.Property<string>("Title");

                    b.HasKey("ProjectId");

                    b.HasIndex("PurposeId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("NLightHouse.Models.ProjectDetail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.HasKey("Id");

                    b.ToTable("ProjectDetail");
                });

            modelBuilder.Entity("NLightHouse.Models.ProjectPerson", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PersonId");

                    b.Property<string>("PersonId1");

                    b.Property<string>("ProjectId");

                    b.Property<string>("ProjectId1");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProjectId1");

                    b.ToTable("ProjectPerson");
                });

            modelBuilder.Entity("NLightHouse.Models.Person", b =>
                {
                    b.HasOne("NLightHouse.Models.Person")
                        .WithMany("Following")
                        .HasForeignKey("PersonId1");

                    b.HasOne("NLightHouse.Models.Person")
                        .WithMany("Follower")
                        .HasForeignKey("PersonId2");

                    b.HasOne("NLightHouse.Models.Person")
                        .WithMany("Blocked")
                        .HasForeignKey("PersonId3");
                });

            modelBuilder.Entity("NLightHouse.Models.Project", b =>
                {
                    b.HasOne("NLightHouse.Models.ProjectDetail", "Purpose")
                        .WithMany()
                        .HasForeignKey("PurposeId");
                });

            modelBuilder.Entity("NLightHouse.Models.ProjectPerson", b =>
                {
                    b.HasOne("NLightHouse.Models.Person", "Person")
                        .WithMany("FundedProject")
                        .HasForeignKey("PersonId");

                    b.HasOne("NLightHouse.Models.Person")
                        .WithMany("OwnedProject")
                        .HasForeignKey("PersonId1");

                    b.HasOne("NLightHouse.Models.Project", "Project")
                        .WithMany("Funders")
                        .HasForeignKey("ProjectId");

                    b.HasOne("NLightHouse.Models.Project")
                        .WithMany("Owners")
                        .HasForeignKey("ProjectId1");
                });
#pragma warning restore 612, 618
        }
    }
}
