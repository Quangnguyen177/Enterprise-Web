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

            modelBuilder.Entity("COMP1640.Models.Account", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Email");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Email = "admin@gmail.com",
                            Password = "admin1",
                            Role = "ADMIN"
                        },
                        new
                        {
                            Email = "Test@123.com",
                            Password = "staff1",
                            Role = "STAFF"
                        },
                        new
                        {
                            Email = "qam@gmail.com",
                            Password = "qam1",
                            Role = "QAM"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Admin", b =>
                {
                    b.Property<int>("AdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ad_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ad_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ad_phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdId");

                    b.HasIndex("Email");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdId = 1,
                            Email = "admin@gmail.com",
                            ad_email = "admin@gmail.com",
                            ad_name = "Truong",
                            ad_phone = "0983337621"
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

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("com_content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComId");

                    b.HasIndex("IdeaId");

                    b.HasIndex("StaffId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            ComId = 1,
                            IdeaId = 1,
                            StaffId = 1,
                            com_content = "This is a great idea"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Department", b =>
                {
                    b.Property<int>("DepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dep_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepId = 1,
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

                    b.Property<string>("doc_content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocId");

                    b.HasIndex("IdeaId");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            DocId = 1,
                            IdeaId = 1,
                            doc_content = "This is a word or pdf, it can be a file",
                            doc_type = "Word"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Idea", b =>
                {
                    b.Property<int>("IdeaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("first_closure")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("last_closure")
                        .HasColumnType("datetime2");

                    b.HasKey("IdeaId");

                    b.HasIndex("StaffId");

                    b.HasIndex("TagId");

                    b.ToTable("Ideas");

                    b.HasData(
                        new
                        {
                            IdeaId = 1,
                            StaffId = 1,
                            TagId = 1,
                            idea_content = "This is a Test",
                            idea_title = "Test"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.QACoordinator", b =>
                {
                    b.Property<int>("QacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("accountEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("qac_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qac_gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qac_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qac_phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QacId");

                    b.HasIndex("accountEmail");

                    b.ToTable("QACoordinators");

                    b.HasData(
                        new
                        {
                            QacId = 1,
                            qac_email = "qac@gmail.com",
                            qac_gender = "female",
                            qac_name = "Duc",
                            qac_phone = "0927652226"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.QAManager", b =>
                {
                    b.Property<int>("QamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("qam_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qam_gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qam_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qam_phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QamId");

                    b.HasIndex("Email");

                    b.ToTable("QAManagers");

                    b.HasData(
                        new
                        {
                            QamId = 1,
                            Email = "qam@gmail.com",
                            qam_email = "qam@gmail.com",
                            qam_gender = "male",
                            qam_name = "Duong",
                            qam_phone = "0293872618"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("staff_DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("staff_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("staff_phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffId");

                    b.HasIndex("DepId");

                    b.HasIndex("Email");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            DepId = 1,
                            Email = "Test@123.com",
                            staff_DoB = new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            staff_address = "Somewhere in the big gray sky",
                            staff_avatar = "",
                            staff_email = "Test@123.com",
                            staff_gender = "Male",
                            staff_name = "Test",
                            staff_phone = "0329226528"
                        });
                });

            modelBuilder.Entity("COMP1640.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tag_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            tag_name = "Testing Tag"
                        });
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
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

            modelBuilder.Entity("COMP1640.Models.Admin", b =>
                {
                    b.HasOne("COMP1640.Models.Account", "Account")
                        .WithMany("Admins")
                        .HasForeignKey("Email");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("COMP1640.Models.Comment", b =>
                {
                    b.HasOne("COMP1640.Models.Idea", "Idea")
                        .WithMany("Comments")
                        .HasForeignKey("IdeaId")
                        .IsRequired();

                    b.HasOne("COMP1640.Models.Staff", "Staff")
                        .WithMany("Comments")
                        .HasForeignKey("StaffId")
                        .IsRequired();

                    b.Navigation("Idea");

                    b.Navigation("Staff");
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
                    b.HasOne("COMP1640.Models.Staff", "Staff")
                        .WithMany("Ideas")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.Tag", "Tag")
                        .WithMany("Ideas")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("COMP1640.Models.QACoordinator", b =>
                {
                    b.HasOne("COMP1640.Models.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountEmail");

                    b.Navigation("account");
                });

            modelBuilder.Entity("COMP1640.Models.QAManager", b =>
                {
                    b.HasOne("COMP1640.Models.Account", "Account")
                        .WithMany("QAManagers")
                        .HasForeignKey("Email");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("COMP1640.Models.Staff", b =>
                {
                    b.HasOne("COMP1640.Models.Department", "Department")
                        .WithMany("Staffs")
                        .HasForeignKey("DepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP1640.Models.Account", "Account")
                        .WithMany("Staffs")
                        .HasForeignKey("Email");

                    b.Navigation("Account");

                    b.Navigation("Department");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COMP1640.Models.Account", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("QAManagers");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("COMP1640.Models.Department", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("COMP1640.Models.Idea", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("COMP1640.Models.Staff", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ideas");
                });

            modelBuilder.Entity("COMP1640.Models.Tag", b =>
                {
                    b.Navigation("Ideas");
                });
#pragma warning restore 612, 618
        }
    }
}
