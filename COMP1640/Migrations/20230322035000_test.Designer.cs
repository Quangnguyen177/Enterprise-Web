﻿// <auto-generated />
using System;
using COMP1640;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP1640.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230322035000_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("EventId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            EventName = "Test #1",
                            Status = false
                        },
                        new
                        {
                            EventId = 2,
                            EventName = "The second Test",
                            Status = false
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

                    b.Property<int>("EventId")
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
                            created_date = new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                            created_date = new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_anonymous = false,
                            idea_content = "This is a Test #2",
                            idea_title = "Test #2",
                            idea_view = 0
                        },
                        new
                        {
                            IdeaId = 3,
                            CategoryId = 1,
                            EventId = 1,
                            ProfileId = "1",
                            ReactPointId = 3,
                            created_date = new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_anonymous = false,
                            idea_content = "This is a Test #3",
                            idea_title = "Test #3",
                            idea_view = 0
                        },
                        new
                        {
                            IdeaId = 4,
                            CategoryId = 1,
                            EventId = 2,
                            ProfileId = "2",
                            ReactPointId = 4,
                            created_date = new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_anonymous = false,
                            idea_content = "This is a Test #4",
                            idea_title = "Test #4",
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
                            ConcurrencyStamp = "0ba19516-848e-4c6b-b0e7-1cefc1904b0f",
                            DepId = 1,
                            DoB = new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Truong Dep Zai",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEPfT52Gqvya4V7Bcb9lJI1WAH+4egZUgJsnfHbl650YKAE6w6S+DL9nTn11m9dvayQ==",
                            PhoneNumber = "0983337621",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a28fbdab-af7d-4ecb-a7ae-03857570789e",
                            TwoFactorEnabled = false,
                            UserName = "Truong"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
                            ConcurrencyStamp = "44890de8-7fe2-4b89-b132-ec48ab8a77a8",
                            DepId = 1,
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "staff1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Duke Mike The",
                            NormalizedUserName = "staff1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAELoqUiEuFFdAZjiGYwEB/+fcoeBqls/jcvta03cQqKEFtEgzGMpoV1vDCeKakMT8DQ==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c5820fd0-dd02-4d20-8a3e-c3b9d5ed41e6",
                            TwoFactorEnabled = false,
                            UserName = "Duke Mike The"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
                            ConcurrencyStamp = "52ec3059-cc6f-4b21-a2c8-16ba55d4fa24",
                            DepId = 1,
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "qam1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Mike The Duke",
                            NormalizedUserName = "qam1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAELxBdIjfM4VshoPu+lb13oA0xu/DrV2Bysi62wfKgxulPlarkdY3QbL+rFc8lfHTlQ==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "160e081c-95ca-4f59-8b0f-e3b16804403e",
                            TwoFactorEnabled = false,
                            UserName = "Mike The Duke"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
                            ConcurrencyStamp = "bf6e4705-ef26-426b-9f8e-71ee9f7b970c",
                            DepId = 1,
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "qac1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Female",
                            LockoutEnabled = false,
                            Name = "Mai The Clone Duke",
                            NormalizedUserName = "qac1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEB3Px7c2bHHZ1H4dVltyE8cICflEUPp4oBcO+Gp8CCeb2JX6LAP+rHBncRH4gc1zDw==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "258fe6a7-84ec-4175-96a1-238b9fd9e929",
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
                        },
                        new
                        {
                            ReactPointId = 3,
                            ThumbDown = 0,
                            ThumbUp = 0
                        },
                        new
                        {
                            ReactPointId = 4,
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
                            ConcurrencyStamp = "adef854d-ac28-4b46-8b8f-0834ba867158",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "B",
                            ConcurrencyStamp = "df799b2a-bba1-410a-99cf-aed1726d0732",
                            Name = "Staff",
                            NormalizedName = "Staff"
                        },
                        new
                        {
                            Id = "C",
                            ConcurrencyStamp = "46cdab6e-6ef7-4bb7-9c5e-f7b71cb320c1",
                            Name = "Quality Assurance Manager",
                            NormalizedName = "Quality Assurance Manager"
                        },
                        new
                        {
                            Id = "D",
                            ConcurrencyStamp = "fbc862e4-8a48-41b3-82b6-f968b34c9c2f",
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
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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