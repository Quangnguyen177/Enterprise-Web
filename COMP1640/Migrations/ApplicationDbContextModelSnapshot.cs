﻿// <auto-generated />
using System;
using COMP1640;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP1640.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP1640.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            category_name = "Human Resource"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Comment", b =>
                {
                    b.Property<int>("ComId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdeaId")
                        .HasColumnType("int");

                    b.Property<string>("ProfileId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("com_anonymous")
                        .HasColumnType("bit");

                    b.Property<string>("com_content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime2");

                    b.HasKey("ComId");

                    b.HasIndex("IdeaId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            ComId = 1,
                            IdeaId = 1,
                            ProfileId = "1",
                            com_anonymous = false,
                            com_content = "This is a great idea"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Department", b =>
                {
                    b.Property<int>("DepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dep_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepId = 1,
                            Dep_name = "Academic"
                        },
                        new
                        {
                            DepId = 2,
                            Dep_name = "IT"
                        },
                        new
                        {
                            DepId = 3,
                            Dep_name = "Business"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Document", b =>
                {
                    b.Property<int>("DocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdeaId")
                        .HasColumnType("int");

                    b.Property<string>("doc_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocId");

                    b.HasIndex("IdeaId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("COMP1640.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("First_closure_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Last_closure_date")
                        .HasColumnType("datetime2");

                    b.HasKey("EventId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            EventName = "Test #1"
                        },
                        new
                        {
                            EventId = 2,
                            EventName = "The second Test"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Idea", b =>
                {
                    b.Property<int>("IdeaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("ProfileId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ReactPointId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("idea_anonymous")
                        .HasColumnType("bit");

                    b.Property<string>("idea_content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idea_view")
                        .HasColumnType("int");

                    b.HasKey("IdeaId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EventId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("ReactPointId");

                    b.ToTable("Ideas");

                    b.HasData(
                        new
                        {
                            IdeaId = 1,
                            CategoryId = 1,
                            EventId = 1,
                            ProfileId = "1",
                            ReactPointId = 1,
                            idea_anonymous = false,
                            idea_content = "This is a Test",
                            idea_title = "Test",
                            idea_view = 0
                        },
                        new
                        {
                            IdeaId = 2,
                            CategoryId = 1,
                            EventId = 2,
                            ProfileId = "2",
                            ReactPointId = 2,
                            idea_anonymous = false,
                            idea_content = "This is a Test #2",
                            idea_title = "Test #2",
                            idea_view = 0
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Profile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DepId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
                            ConcurrencyStamp = "fad3bf3c-c467-4bc8-ba82-8661e90d8d70",
                            DepId = 1,
                            DoB = new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Truong Dep Zai",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEGsM2GUl+Qma3cXCanKS+9nmSZsszirTORhhd9QIz6eXDb7qEi9HP1UZYES9Ic/NLQ==",
                            PhoneNumber = "0983337621",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "02cfd4d8-de69-4ecc-bade-20cbc2dfce23",
                            TwoFactorEnabled = false,
                            UserName = "Truong"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
                            ConcurrencyStamp = "2190dc3c-3a66-43e9-8d38-210815544486",
                            DepId = 1,
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "staff1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Duke Mike The",
                            NormalizedUserName = "staff1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAENifggwa/4vQVzZ/OQ48cjhOivYQAILejDlEO7N7dV5ejRne/z9Oa1UM/eJu+Ilh8w==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3d801263-8f5e-4794-9047-54f7a8a56e73",
                            TwoFactorEnabled = false,
                            UserName = "Duke Mike The"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
                            ConcurrencyStamp = "83f85671-664e-4de5-9700-83331a0ab55c",
                            DepId = 1,
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "qam1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Mike The Duke",
                            NormalizedUserName = "qam1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEOLcIao/AkBoPHKE06mun32lzVQRs8BC/UKE6RfrT+3cwagZqoIz+Uf+yJajNPDYQA==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "26192ec6-53ee-43ba-8f6f-24dfdb9f34bc",
                            TwoFactorEnabled = false,
                            UserName = "Mike The Duke"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
                            ConcurrencyStamp = "07a2d68b-93f4-4ca2-a3a2-eb55a49b02d0",
                            DepId = 1,
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "qac1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Female",
                            LockoutEnabled = false,
                            Name = "Mai The Clone Duke",
                            NormalizedUserName = "qac1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEJn8adlHPupPq91vf6Q2XS8xI0w2u1Mo6gmiVGFnlioq+d8hJkj/u411Zgo1+02Z9g==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8004abd2-7e6a-45e9-ae12-383e34c98747",
                            TwoFactorEnabled = false,
                            UserName = "Mai The Duc"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.React", b =>
                {
                    b.Property<int>("ReactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdeaId")
                        .HasColumnType("int");

                    b.Property<string>("ProfileId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Reacted")
                        .HasColumnType("bit");

                    b.HasKey("ReactId");

                    b.HasIndex("IdeaId");

                    b.HasIndex("ProfileId");

                    b.ToTable("React");
                });

            modelBuilder.Entity("COMP1640.Models.ReactPoint", b =>
                {
                    b.Property<int>("ReactPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ThumbDown")
                        .HasColumnType("int");

                    b.Property<int>("ThumbUp")
                        .HasColumnType("int");

                    b.HasKey("ReactPointId");

                    b.ToTable("ReactPoints");

                    b.HasData(
                        new
                        {
                            ReactPointId = 1,
                            ThumbDown = 0,
                            ThumbUp = 0
                        },
                        new
                        {
                            ReactPointId = 2,
                            ThumbDown = 0,
                            ThumbUp = 0
                        });
                });

            modelBuilder.Entity("COMP1640.Models.View", b =>
                {
                    b.Property<int>("ViewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfView")
                        .HasColumnType("int");

                    b.Property<string>("ProfileId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ViewId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Views");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "A",
                            ConcurrencyStamp = "f1da33d3-fe05-45de-a256-5dd6d4b60fdb",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "B",
                            ConcurrencyStamp = "4a508958-ab2a-48be-9f4a-c39254fdee5c",
                            Name = "Staff",
                            NormalizedName = "Staff"
                        },
                        new
                        {
                            Id = "C",
                            ConcurrencyStamp = "2e781d74-d819-4734-83ce-9a0de9c740bb",
                            Name = "Quality Assurance Manager",
                            NormalizedName = "Quality Assurance Manager"
                        },
                        new
                        {
                            Id = "D",
                            ConcurrencyStamp = "aa06f74c-2a0d-4cc2-b187-169996beb3f5",
                            Name = "Quality Assurance Coordinator",
                            NormalizedName = "Quality Assurance Coordinator"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "A"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "B"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "C"
                        },
                        new
                        {
                            UserId = "4",
                            RoleId = "D"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("COMP1640.Models.Comment", b =>
                {
                    b.HasOne("COMP1640.Models.Idea", "Idea")
                        .WithMany("Comments")
                        .HasForeignKey("IdeaId")
                        .IsRequired();

                    b.HasOne("COMP1640.Models.Profile", "Profile")
                        .WithMany("Comments")
                        .HasForeignKey("ProfileId");

                    b.Navigation("Idea");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("COMP1640.Models.Document", b =>
                {
                    b.HasOne("COMP1640.Models.Idea", "Idea")
                        .WithMany("Documents")
                        .HasForeignKey("IdeaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("COMP1640.Models.Idea", b =>
                {
                    b.HasOne("COMP1640.Models.Category", "Category")
                        .WithMany("Ideas")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.Event", "Event")
                        .WithMany("Ideas")
                        .HasForeignKey("EventId");

                    b.HasOne("COMP1640.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.HasOne("COMP1640.Models.ReactPoint", "Reacpoint")
                        .WithMany()
                        .HasForeignKey("ReactPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Event");

                    b.Navigation("Profile");

                    b.Navigation("Reacpoint");
                });

            modelBuilder.Entity("COMP1640.Models.Profile", b =>
                {
                    b.HasOne("COMP1640.Models.Department", "Department")
                        .WithMany("Profiles")
                        .HasForeignKey("DepId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("COMP1640.Models.React", b =>
                {
                    b.HasOne("COMP1640.Models.Idea", "Idea")
                        .WithMany("React")
                        .HasForeignKey("IdeaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.Navigation("Idea");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("COMP1640.Models.View", b =>
                {
                    b.HasOne("COMP1640.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("COMP1640.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("COMP1640.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("COMP1640.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COMP1640.Models.Category", b =>
                {
                    b.Navigation("Ideas");
                });

            modelBuilder.Entity("COMP1640.Models.Department", b =>
                {
                    b.Navigation("Profiles");
                });

            modelBuilder.Entity("COMP1640.Models.Event", b =>
                {
                    b.Navigation("Ideas");
                });

            modelBuilder.Entity("COMP1640.Models.Idea", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Documents");

                    b.Navigation("React");
                });

            modelBuilder.Entity("COMP1640.Models.Profile", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
