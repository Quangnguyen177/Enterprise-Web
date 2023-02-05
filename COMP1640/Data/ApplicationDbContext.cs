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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // tam thoi
            SeedStaff(builder);

            SeedTag(builder);

            SeedIdea(builder);

        }

        private void SeedStaff(ModelBuilder builder)
        {
            builder.Entity<Staff>().HasData(
                new Staff
                {
                    StaffId = 1,
                    staff_name = "Test",
                    staff_phone = 0329226528,
                    staff_email = "Test@123.com",
                    staff_DoB = DateTime.Parse("2002-08-25"),
                    staff_gender = "Male",
                    staff_address = "Somewhere in the big gray sky",
                    staff_avatar = ""
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
                    idea_document = "",
                    idea_image = "Test"
                    //first_closure = ,
                    //last_closure = 
                }
            );
        }
    }
}