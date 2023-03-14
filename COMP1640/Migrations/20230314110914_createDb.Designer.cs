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
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
    [Migration("20230314110914_createDb")]
    partial class createDb
========
    [Migration("20230314115510_test")]
    partial class test
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP1640.Models.Account", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Accounts");
                });

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
                    b.Property<string>("DepId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("dep_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepId = "1",
                            dep_name = "Academic"
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

                    b.Property<string>("DepId")
                        .HasColumnType("nvarchar(450)");

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
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            ConcurrencyStamp = "276736a2-4a9e-4e9e-b8e3-ab73e3757b48",
========
                            ConcurrencyStamp = "9e215897-6f32-42ed-b077-75fe00068bb3",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            DepId = "1",
                            DoB = new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Truong Dep Zai",
                            NormalizedUserName = "admin@gmail.com",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            PasswordHash = "AQAAAAEAACcQAAAAEBJo+3BqIjqpwlHde1qsqLx18wDnHcpOlujetCqnzh6OYO2CO8oIV1kqhCh0s4B3cg==",
                            PhoneNumber = "0983337621",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3d70c30d-3d07-4d15-b6f6-0f4d1d32d35c",
========
                            PasswordHash = "AQAAAAEAACcQAAAAEDpNLuD9DrfxvqrWiXu44sPXBjpR8fDSHKgo2UmAqlfXtrkMlSKGZhcQVif1t5opfg==",
                            PhoneNumber = "0983337621",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b6c2d3c5-61b8-48c6-acc0-25bc4c745c88",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            TwoFactorEnabled = false,
                            UserName = "Truong"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            ConcurrencyStamp = "f50f3439-7a90-4441-8fc8-7cf5f0c73c56",
========
                            ConcurrencyStamp = "0c6b0243-9ad7-4e73-8639-36932c16c6b1",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            DepId = "1",
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "staff1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Duke Mike The",
                            NormalizedUserName = "staff1@gmail.com",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            PasswordHash = "AQAAAAEAACcQAAAAEOtVOs6vTXqso8cP2tAn6c3sbo9vYXke22zDPC/k0pt4gK2gkiSQR7OxDqAIvmrJnQ==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a0f0b65d-bc09-40e0-9322-3c8c0018279b",
========
                            PasswordHash = "AQAAAAEAACcQAAAAEPNe0gh2MAOs/MEuBRVx/nTcaXv45OjomtSNHDToSyqraRq0PYiG4DY3aqXLT+QLVw==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8525634d-a8e4-4550-b54e-4fa1eaf7d8f8",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            TwoFactorEnabled = false,
                            UserName = "Duke Mike The"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            ConcurrencyStamp = "0cc3318c-c3b8-4b6e-ac7e-efe45ee72b5e",
========
                            ConcurrencyStamp = "e5a8ee82-3a1f-4a0f-9892-ca391ae75dc6",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            DepId = "1",
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "qam1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Male",
                            LockoutEnabled = false,
                            Name = "Mike The Duke",
                            NormalizedUserName = "qam1@gmail.com",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            PasswordHash = "AQAAAAEAACcQAAAAEAYwXfeqrjHexY8Xx94fadgVQwb4yeHbzzNB0IFsQxwtiw/tQ23bFGilPKmFZT9F7A==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8fdd7ea7-24ff-4aeb-8a9f-f68b115b50be",
========
                            PasswordHash = "AQAAAAEAACcQAAAAEBmuW55CoOr6mG3/+V2MJsz+Gqp2mSrH96f/zi2eNmF2PfEDEzbiAtOwCKaM78/DnQ==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b1a31937-0a6c-4480-ad5e-2dd4b9798d8e",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            TwoFactorEnabled = false,
                            UserName = "Mike The Duke"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            Address = "Somewhere in the big gray sky",
                            Avatar = "",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            ConcurrencyStamp = "30148cb8-d7e6-44c0-a601-286042fae324",
========
                            ConcurrencyStamp = "404e72d2-4a6d-4fec-b079-d7bb30dc785d",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            DepId = "1",
                            DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "qac1@gmail.com",
                            EmailConfirmed = false,
                            Gender = "Female",
                            LockoutEnabled = false,
                            Name = "Mai The Clone Duke",
                            NormalizedUserName = "qac1@gmail.com",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            PasswordHash = "AQAAAAEAACcQAAAAEMixx7FQqEzcGielFSGoTy4bhzxgVv6FW/Rv9HLTfyQwRFG1vvCDeJGjgxwkgHpc0w==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9021f6b3-e167-434c-b710-e5203dbb0af9",
========
                            PasswordHash = "AQAAAAEAACcQAAAAEBH7E3h8HldNRT2w1TT1gsQWs0/ZgecQNVlXMxEZmbBN7iqaD1gJMaYOQkBIHxUBYA==",
                            PhoneNumber = "0329226528",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9af2ec8-8d8a-464b-b442-e47a6284105c",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
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
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            ConcurrencyStamp = "53cae5d2-6448-4513-8639-08568fd1b538",
========
                            ConcurrencyStamp = "461bb35b-a4cd-4b54-8b15-5fe51fbe386a",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "B",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            ConcurrencyStamp = "d1fee689-6db6-480a-9c2f-374e9e5bbd72",
========
                            ConcurrencyStamp = "becc4e5d-dbe7-4097-81a6-dd4c06539a80",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            Name = "Staff",
                            NormalizedName = "Staff"
                        },
                        new
                        {
                            Id = "C",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            ConcurrencyStamp = "085f8e9a-0f3a-4afc-82d6-eda2126efb03",
========
                            ConcurrencyStamp = "25722a6f-6e65-49ee-b172-d355754a7291",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
                            Name = "Quality Assurance Manager",
                            NormalizedName = "Quality Assurance Manager"
                        },
                        new
                        {
                            Id = "D",
<<<<<<<< HEAD:COMP1640/Migrations/20230314110914_createDb.Designer.cs
                            ConcurrencyStamp = "8e25a577-5acf-491f-a280-4768fab82739",
========
                            ConcurrencyStamp = "a3e7548d-1899-48ed-944c-2264ec85bc86",
>>>>>>>> 26b6661 (admin edit account):COMP1640/Migrations/20230314115510_test.Designer.cs
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
