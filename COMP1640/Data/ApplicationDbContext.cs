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

            //XX
            //SeedProfile(builder);

            //2
            SeedDepartment(builder);

            //3
            SeedCategory(builder);

            //4
            SeedDocument(builder);

            //5
            SeedIdea(builder);

            //6
            SeedComment(builder);

            //7 
            SeedReactPoint(builder);
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



            //Khai báo thư viện để mã hóa mk
            var hashed = new PasswordHasher<Profile>();

            //Thiết lập để mã hóa từng tài khoản
            admin1.PasswordHash = hashed.HashPassword(admin1, "admin#1");
            staff1.PasswordHash = hashed.HashPassword(admin1, "Staff#1");

            //Add tài khoản vào DB
            builder.Entity<Profile>().HasData(admin1, staff1);


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
                }
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
                    ProfileId = "1",
                    CategoryId = 1,
                    idea_title = "Test",
                    idea_content = "This is a Test",
                    //created_date = ,
                    //first_closure = ,
                    //last_closure = ,
                    idea_anonymous = false,
                    idea_view = 0,
                    ReactPointId = 1,
                },
                new Idea
                {
                    IdeaId = 2,
                    ProfileId = "2",
                    CategoryId = 1,
                    idea_title = "Test #2",
                    idea_content = "This is a Test #2",
                    //created_date = ,
                    //first_closure = ,
                    //last_closure = ,
                    idea_anonymous = false,
                    idea_view = 0,
                    ReactPointId = 2,
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
                    ComId = "1",
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
    }
}