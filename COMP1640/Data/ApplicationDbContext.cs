using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP1640.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace COMP1640
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // tam thoi

            //1
            SeedAccount(builder);

            //2
            SeedRole(builder);

            //3
            SeedAccountRole(builder);

            //4
            SeedProfile(builder);

            //2
            SeedDepartment(builder);

            //3
            SeedTag(builder);

            //4
            SeedDocument(builder);

            //5
            SeedIdea(builder);

            //6
            SeedComment(builder);
        }

        //1
        private void SeedAccount(ModelBuilder builder)
        {
            var ADMIN = new IdentityUser
            {
                Id = "1",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                EmailConfirmed = true
            };

            //Khai báo thư viện để mã hóa mk
            var hashed = new PasswordHasher<IdentityUser>();

            //Thiết lập để mã hóa từng tài khoản
            ADMIN.PasswordHash = hashed.HashPassword(ADMIN, "admin1");

            //Add tài khoản vào DB
            builder.Entity<IdentityUser>().HasData(ADMIN);


        }

        //Add Role
        private void SeedRole(ModelBuilder builder)
        {
            //1. tạo các role cho hệ thống
            var ADMIN = new IdentityRole
            {
                Id = "1",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };

            var STAFF = new IdentityRole
            {
                Id = "2",
                Name = "StafF",
                NormalizedName = "Staff"
            };

            var QAM = new IdentityRole
            {
                Id = "3",
                Name = "Quality Assurance Manager",
                NormalizedName = "Quality Assurance Manager"
            };

            var QAC = new IdentityRole
            {
                Id = "4",
                Name = "Quality Assurance Coordinator",
                NormalizedName = "Quality Assurance Coordinator"
            };

            //2. add role vào trong DB
            builder.Entity<IdentityRole>().HasData(ADMIN, STAFF, QAM, QAC);
        }

        private void SeedAccountRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId= "1",
                    RoleId = "1"
                }
                //new IdentityUserRole<string>
                //{
                //    UserId = "2",
                //    RoleId = "B"
                //},
                //new IdentityUserRole<string>
                //{
                //    UserId = "3",
                //    RoleId = "C"
                //},
                //new IdentityUserRole<string>
                //{
                //    UserId = "4",
                //    RoleId = "C"
                //}
             );
        }

        //4 
        private void SeedProfile(ModelBuilder builder)
        {
            builder.Entity<Profile>().HasData(
                new Profile
                {
                    ProfileId = 1,
                    Name = "Truong",
                    Email = "admin@gmail.com",
                    Phone = "0983337621",
                }
            //    new Account
            //    {
            //        Username = "Test@123.com",
            //        Password = "staff1",
            //        Role = "STAFF",
            //        Name = "Test",
            //        Email = "Test@123.com",
            //        Phone = "0329226528",
            //        DoB = DateTime.Parse("2002-08-25"),
            //        Gender = "Male",
            //        Address = "Somewhere in the big gray sky",
            //        Avatar = "",
            //        DepId = 1,
            //    },
            //    new Account
            //    {
            //        Username = "qam@gmail.com",
            //        Password = "qam1",
            //        Role = "QAM",
            //        Name = "Duong",
            //        Email = "qam@gmail.com",
            //        Phone = "0293872618",
            //        Gender = "female",
            //    },
            //    new Account
            //    {
            //        Username = "qac@gmail.com",
            //        Password = "qac1",
            //        Role = "QAC",
            //        Name = "Duc",
            //        Email = "qac@gmail.com",
            //        Phone = "0927652226",
            //        Gender = "male",
            //    }
            );
        }

        //2
        private void SeedDepartment(ModelBuilder builder)
        {
            builder.Entity<Department>()
                .HasMany(x => x.Profiles);
            builder.Entity<Department>().HasData(
                new Department
                {
                    DepId = 1,
                    dep_name = "Academic"
                }
            );
        }

        //3
        private void SeedTag(ModelBuilder builder)
        {
            builder.Entity<Tag>().HasData(
                new Tag
                {
                    TagId = 1,
                    tag_name = "Testing Tag"
                }
            );
        }

        //4
        private void SeedDocument(ModelBuilder builder)
        {
            builder.Entity<Document>().HasData(
                new Document
                {
                    DocId = 1,
                    IdeaId= 1,
                    doc_content = "This is a word or pdf, it can be a file",
                    doc_type = "Word"
                }
            );
        }

        //5
        private void SeedIdea(ModelBuilder builder)
        {
            builder.Entity<Idea>()
                .HasMany(x => x.Comments);
            builder.Entity<Idea>().HasData(
                new Idea
                {
                    IdeaId = 1,
                    ProfileId = 1,
                    TagId = 1,
                    idea_title = "Test",
                    idea_content = "This is a Test",
                    //created_date = ,
                    //first_closure = ,
                    //last_closure = ,
                    idea_anonymous = false,
                    Ipoint = 0,
                }
            );
        }

        //6
        private void SeedComment(ModelBuilder builder)
        {
            builder.Entity<Comment>()
                .HasOne(x => x.Profile)
                .WithMany(y => y.Comments)
                .HasForeignKey(z => z.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Comment>()
                .HasOne(x => x.Idea)
                .WithMany(y => y.Comments)
                .HasForeignKey(z => z.IdeaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Comment>().HasData(
                new Comment
                {
                    ComId = 1,
                    ProfileId = 1,
                    IdeaId = 1,
                    com_content = "This is a great idea",
                    //created_date null
                    com_anonymous = false
                }
            );
        }  
    }
}