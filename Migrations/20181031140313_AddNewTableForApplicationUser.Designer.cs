﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLightHouse.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NLightHouse.Migrations
{
    [DbContext(typeof(NLighthouseDbContext))]
    [Migration("20181031140313_AddNewTableForApplicationUser")]
    partial class AddNewTableForApplicationUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NLightHouse.Models.ApplicationUser", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("PersonId");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("NLightHouse.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserUserId");

                    b.Property<string>("ApplicationUserUserId1");

                    b.Property<string>("ApplicationUserUserId2");

                    b.Property<string>("Name");

                    b.Property<string>("PersonId1");

                    b.Property<string>("PersonId2");

                    b.Property<string>("PersonId3");

                    b.HasKey("PersonId");

                    b.HasIndex("ApplicationUserUserId");

                    b.HasIndex("ApplicationUserUserId1");

                    b.HasIndex("ApplicationUserUserId2");

                    b.HasIndex("PersonId1");

                    b.HasIndex("PersonId2");

                    b.HasIndex("PersonId3");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("NLightHouse.Models.Project", b =>
                {
                    b.Property<string>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Canceled");

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

                    b.Property<string>("ApplicationUserUserId");

                    b.Property<string>("ApplicationUserUserId1");

                    b.Property<string>("PersonId");

                    b.Property<string>("PersonId1");

                    b.Property<string>("ProjectId");

                    b.Property<string>("ProjectId1");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserUserId");

                    b.HasIndex("ApplicationUserUserId1");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ProjectId1");

                    b.ToTable("ProjectPerson");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NLightHouse.Models.Person", b =>
                {
                    b.HasOne("NLightHouse.Models.ApplicationUser")
                        .WithMany("Blocked")
                        .HasForeignKey("ApplicationUserUserId");

                    b.HasOne("NLightHouse.Models.ApplicationUser")
                        .WithMany("Follower")
                        .HasForeignKey("ApplicationUserUserId1");

                    b.HasOne("NLightHouse.Models.ApplicationUser")
                        .WithMany("Following")
                        .HasForeignKey("ApplicationUserUserId2");

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
                    b.HasOne("NLightHouse.Models.ApplicationUser")
                        .WithMany("FundedProject")
                        .HasForeignKey("ApplicationUserUserId");

                    b.HasOne("NLightHouse.Models.ApplicationUser")
                        .WithMany("OwnedProject")
                        .HasForeignKey("ApplicationUserUserId1");

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
