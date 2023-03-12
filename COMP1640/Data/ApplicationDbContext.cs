using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP1640.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Security.Policy;

namespace COMP1640
{
    public class ApplicationDbContext : IdentityDbContext<Profile>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<IdentityRole> IdentityRoles { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<View> Views { get; set; }
        public DbSet<React> React { get; set; }
        public DbSet<ReactPoint> ReactPoints { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // tam thoi

            //1
            SeedProfile(builder);

            //2
            SeedRole(builder);

            //3
            SeedAccountRole(builder);

            //4
            SeedDepartment(builder);

            //5
            SeedCategory(builder);

            //5.5
            //SeedDocument(builder);

            //6
            SeedIdea(builder);

            //7
            SeedComment(builder);

            //8
            SeedReactPoint(builder);

            //9
            SeedEvent(builder);
        }

        //1
        private void SeedProfile(ModelBuilder builder)
        {

            builder.Entity<Profile>()
                .HasOne(x => x.Department)
                .WithMany(y => y.Profiles)
                .HasForeignKey(z => z.DepId);

            var admin1 = new Profile
            {
                Id = "1",
                UserName = "Truong",
                Email = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com",
                //EmailConfirmed = true,
                Name = "Truong Dep Zai",
                PhoneNumber = "0983337621",
                DoB = DateTime.Parse("2002-03-26"),
                Gender = "Male",
                Address = "Somewhere in the big gray sky",
                Avatar = "",
                DepId = "1",
            };
            var staff1 = new Profile
            {
                Id = "2",
                UserName = "Duke Mike The",
                Email = "staff1@gmail.com",
                NormalizedUserName = "staff1@gmail.com",
                Name = "Duke Mike The",
                PhoneNumber = "0329226528",
                DoB = DateTime.Parse("2002-08-25"),
                Gender = "Male",
                Address = "Somewhere in the big gray sky",
                Avatar = "",
                DepId = "1",
            };
            var qam1 = new Profile
            {
                Id = "3",
                UserName = "Mike The Duke",
                Email = "qam1@gmail.com",
                NormalizedUserName = "qam1@gmail.com",
                Name = "Mike The Duke",
                PhoneNumber = "0329226528",
                DoB = DateTime.Parse("2002-08-25"),
                Gender = "Male",
                Address = "Somewhere in the big gray sky",
                Avatar = "",
                DepId = "1",
            };
            var qac1 = new Profile
            {
                Id = "4",
                UserName = "Mai The Duc",
                Email = "qac1@gmail.com",
                NormalizedUserName = "qac1@gmail.com",
                Name = "Mai The Clone Duke",
                PhoneNumber = "0329226528",
                DoB = DateTime.Parse("2002-08-25"),
                Gender = "Female",
                Address = "Somewhere in the big gray sky",
                Avatar = "",
                DepId = "1",
            };


            //Khai báo thư viện để mã hóa mk
            var hashed = new PasswordHasher<Profile>();

            //Thiết lập để mã hóa từng tài khoản
            admin1.PasswordHash = hashed.HashPassword(admin1, "Admin#1");
            staff1.PasswordHash = hashed.HashPassword(staff1, "Staff#1");
            qam1.PasswordHash = hashed.HashPassword(qam1, "Qamr#1");
            qac1.PasswordHash = hashed.HashPassword(qac1, "Qacr#1");

            //Add tài khoản vào DB
            builder.Entity<Profile>().HasData(admin1, staff1, qam1, qac1);
        }

        //Add Role
        private void SeedRole(ModelBuilder builder)
        {
            //1. tạo các role cho hệ thống
            var ADMIN = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };

            var STAFF = new IdentityRole
            {
                Id = "B",
                Name = "Staff",
                NormalizedName = "Staff"
            };

            var QAM = new IdentityRole
            {
                Id = "C",
                Name = "Quality Assurance Manager",
                NormalizedName = "Quality Assurance Manager"
            };

            var QAC = new IdentityRole
            {
                Id = "D",
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
                    RoleId = "A"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "B"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "C"
                },
                new IdentityUserRole<string>
                {
                    UserId = "4",
                    RoleId = "D"
                }
             );
        }

        //4 
        //private void SeedProfile(ModelBuilder builder)
        //{
        //    builder.Entity<Profile>()   
        //        .HasOne(x => x.Department)
        //        .WithMany(y => y.Profiles)
        //        .HasForeignKey(z => z.DepId);
        //    builder.Entity<Profile>().HasData(

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
        //    );
        //}

        //2
        private void SeedDepartment(ModelBuilder builder)
        {
            builder.Entity<Department>()
                .HasMany(x => x.Profiles);
            builder.Entity<Department>().HasData(
                new Department
                {
                    DepId = "1",
                    dep_name = "Academic"
                }
            );
        }

        //3
        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    category_name = "Human Resource"
                }
            );
        }

        //4
/*        private void SeedDocument(ModelBuilder builder)
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
        }*/

        //5
        private void SeedIdea(ModelBuilder builder)
        {
            builder.Entity<Idea>()
                .HasMany(x => x.Comments);
            builder.Entity<Idea>().HasData(
                new Idea
                {
                    IdeaId = 1,
                    ProfileId = "1",
                    CategoryId = 1,
                    ReactPointId = 1,
                    EventId = 1,
                    idea_title = "Test",
                    idea_content = "This is a Test",
                    idea_anonymous = false,
                    idea_view = 0
                },
                new Idea
                {
                    IdeaId = 2,
                    ProfileId = "2",
                    CategoryId = 1,
                    ReactPointId = 2,
                    EventId = 2,
                    idea_title = "Test #2",
                    idea_content = "This is a Test #2",
                    idea_anonymous = false,
                    idea_view = 0,
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
                    ProfileId = "1",
                    IdeaId = 1,
                    com_content = "This is a great idea",
                    //created_date null
                    com_anonymous = false
                }
            );
        }

        private void SeedReactPoint(ModelBuilder builder)
        {
            builder.Entity<ReactPoint>().HasData(
                new ReactPoint
                {
                    ReactPointId = 1,
                    ThumbUp = 0,
                    ThumbDown = 0,
                },
                new ReactPoint
                {
                    ReactPointId = 2,
                    ThumbUp = 0,
                    ThumbDown = 0,
                }
            );
        }

        private void SeedEvent(ModelBuilder builder)
        {
            builder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 1,
                    EventName = "Test #1",
                    First_closure_date = null,
                    Last_closure_date = null
                },
                new Event
                {
                    EventId = 2,
                    EventName = "The second Test",
                    First_closure_date = null,
                    Last_closure_date = null
                }
            );
        }
    }
}