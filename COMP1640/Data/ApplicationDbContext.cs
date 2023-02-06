using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP1640.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMP1640
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<QACoordinator> QACoordinators { get; set; }
        public DbSet<QAManager> QAManagers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // tam thoi
            SeedStaff(builder);

            SeedTag(builder);

            SeedIdea(builder);

            SeedAdmin(builder);

            SeedComment(builder);

            SeedDepartment(builder);
            SeedDocument(builder);

            SeedQACoordinator(builder);

            SeedQAManager(builder);

        }

        private void SeedQAManager(ModelBuilder builder)
        {
            builder.Entity<QAManager>().HasData(
                new QAManager
                {
                    QamId = 1,
                    qam_email= "qam@gmail.com",
                    qam_gender= "male",
                    qam_name= "Duong",
                    qam_phone= "0293872618"
                }
            );
        }
        private void SeedStaff(ModelBuilder builder)
        {
            builder.Entity<Staff>().HasData(
                new Staff
                {
                    StaffId = 1,
                    staff_name = "Test",
                    staff_phone = "0329226528",
                    staff_email = "Test@123.com",
                    staff_DoB = DateTime.Parse("2002-08-25"),
                    staff_gender = "Male",
                    staff_address = "Somewhere in the big gray sky",
                    staff_avatar = "",
                    DepId= 1
                }
            );
        }
        private void SeedQACoordinator(ModelBuilder builder)
        {
            builder.Entity<QACoordinator>().HasData(
                new QACoordinator
                {
                    QacId = 1,
                    qac_email= "qac@gmail.com",
                    qac_gender= "female",
                    qac_name= "Duc",
                    qac_phone= "0927652226"
                }
            );
        }

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

        private void SeedDepartment(ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(
                new Department
                {
                    DepId = 1,
                    dep_name = "Academic"
                }
            );
        }

        private void SeedComment(ModelBuilder builder)
        {
            builder.Entity<Comment>()
                .HasOne(x => x.Staff)
                .WithMany(x => x.Comments)
                .HasForeignKey(z => z.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Comment>()
                .HasOne(x => x.Idea)
                .WithMany(x => x.Comments)
                .HasForeignKey(z => z.IdeaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Comment>().HasData(
                new Comment
                {
                    ComId = 1,
                    StaffId = 1,
                    IdeaId = 1,
                    com_content = "This is a great idea",
                    //created_date null
                }
            );
        }

        private void SeedAdmin(ModelBuilder builder)
        {
            builder.Entity<Admin>().HasData(
                new Admin
                {
                    AdId = 1,
                    ad_email= "admin@gmail.com",
                    ad_name= "Truong",
                    ad_phone= "0983337621"
                }
            );
        }

        

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

        private void SeedIdea(ModelBuilder builder)
        {
            _ = builder.Entity<Idea>().HasData(
                new Idea
                {
                    IdeaId = 1,
                    StaffId = 1,
                    TagId = 1,
                    idea_title = "Test",
                    idea_content = "This is a Test",
                    //first_closure = ,
                    //last_closure = ,
                    //created_date
                }
            );
        }
    }
}