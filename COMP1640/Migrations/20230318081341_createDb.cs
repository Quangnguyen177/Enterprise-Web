﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dep_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First_closure_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Last_closure_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "ReactPoints",
                columns: table => new
                {
                    ReactPointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThumbUp = table.Column<int>(type: "int", nullable: false),
                    ThumbDown = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactPoints", x => x.ReactPointId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepId",
                        column: x => x.DepId,
                        principalTable: "Departments",
                        principalColumn: "DepId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ideas",
                columns: table => new
                {
                    IdeaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idea_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idea_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    idea_anonymous = table.Column<bool>(type: "bit", nullable: false),
                    idea_view = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ReactPointId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ideas", x => x.IdeaId);
                    table.ForeignKey(
                        name: "FK_Ideas_AspNetUsers_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ideas_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ideas_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ideas_ReactPoints_ReactPointId",
                        column: x => x.ReactPointId,
                        principalTable: "ReactPoints",
                        principalColumn: "ReactPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Views",
                columns: table => new
                {
                    ViewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfView = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Views", x => x.ViewId);
                    table.ForeignKey(
                        name: "FK_Views_AspNetUsers_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ComId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    com_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    com_anonymous = table.Column<bool>(type: "bit", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdeaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ComId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Ideas_IdeaId",
                        column: x => x.IdeaId,
                        principalTable: "Ideas",
                        principalColumn: "IdeaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doc_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doc_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocId);
                    table.ForeignKey(
                        name: "FK_Documents_Ideas_IdeaId",
                        column: x => x.IdeaId,
                        principalTable: "Ideas",
                        principalColumn: "IdeaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "React",
                columns: table => new
                {
                    ReactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reacted = table.Column<bool>(type: "bit", nullable: false),
                    IdeaId = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_React", x => x.ReactId);
                    table.ForeignKey(
                        name: "FK_React_AspNetUsers_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_React_Ideas_IdeaId",
                        column: x => x.IdeaId,
                        principalTable: "Ideas",
                        principalColumn: "IdeaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:COMP1640/Migrations/20230318081341_createDb.cs
                    { "A", "9a42a515-0f40-4c2d-9680-a265eb630085", "Administrator", "Administrator" },
                    { "B", "b1db7db6-d155-4b49-b27c-70855f166cb6", "Staff", "Staff" },
                    { "C", "4c3c52b4-42aa-4235-93b3-edfc7e48ac5d", "Quality Assurance Manager", "Quality Assurance Manager" },
                    { "D", "dc6c875e-9ff9-481d-92d0-6f1d03e100e1", "Quality Assurance Coordinator", "Quality Assurance Coordinator" }
========
                    { "A", "188eae10-2406-4bf2-b44b-6c9dce9830f8", "Administrator", "Administrator" },
                    { "B", "927365f2-19b9-4cce-8f95-04103bdbcf41", "Staff", "Staff" },
                    { "C", "bb29ba6f-2c2f-41d1-9a57-ae2a1537018a", "Quality Assurance Manager", "Quality Assurance Manager" },
                    { "D", "06de70e8-3e83-44a3-a878-4b966d53b6fd", "Quality Assurance Coordinator", "Quality Assurance Coordinator" }
>>>>>>>> 682a7991b0d5e12b750af3b7d147d77e2ca6c1cc:COMP1640/Migrations/20230318070727_test.cs
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "category_name" },
                values: new object[] { 1, "Human Resource" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepId", "Dep_name" },
                values: new object[,]
                {
                    { 1, "Academic" },
                    { 2, "IT" },
                    { 3, "Business" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EventName", "First_closure_date", "Last_closure_date" },
                values: new object[,]
                {
                    { 1, "Test #1", null, null },
                    { 2, "The second Test", null, null }
                });

            migrationBuilder.InsertData(
                table: "ReactPoints",
                columns: new[] { "ReactPointId", "ThumbDown", "ThumbUp" },
                values: new object[,]
                {
                    { 1, 0, 0 },
                    { 2, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "DepId", "DoB", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:COMP1640/Migrations/20230318081341_createDb.cs
                    { "1", 0, "Somewhere in the big gray sky", "", "16e71ef5-9307-4a69-8bea-87c7c054a72b", 1, new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Male", false, null, "Truong Dep Zai", null, "admin@gmail.com", "AQAAAAEAACcQAAAAEP7//KVircJaLT1lt33fdk20JPiPfOiqi73qAYjbch/hyOppdW/PoNYGLJZw9KeeGA==", "0983337621", false, "2d60365b-4ce8-4714-b14a-c5b9fd6c8b8d", false, "Truong" },
                    { "2", 0, "Somewhere in the big gray sky", "", "84f92e6c-36c6-4d3b-8225-07169f4fcb19", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", false, "Male", false, null, "Duke Mike The", null, "staff1@gmail.com", "AQAAAAEAACcQAAAAEBtvH/AqjlMYJN9iBkxsdUlnbflalMSOmU80vUd/TubQkglKpodqlxtIZ5aEZAwNxw==", "0329226528", false, "580b9e40-8f3a-4c2c-86a9-0d91e5e14b65", false, "Duke Mike The" },
                    { "3", 0, "Somewhere in the big gray sky", "", "fb144453-4ca9-46f5-947f-a014820434f2", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "qam1@gmail.com", false, "Male", false, null, "Mike The Duke", null, "qam1@gmail.com", "AQAAAAEAACcQAAAAEOwrdOtkq553VywbE/zNcWwUbL5z+yOz3P9v/d9f0Z2qrZGorDbN5Zwn3hUC+apADQ==", "0329226528", false, "58625c68-8071-45af-a7e1-a392c21d7219", false, "Mike The Duke" },
                    { "4", 0, "Somewhere in the big gray sky", "", "344ce1bb-b570-4246-ac73-8d38ab38eeff", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "qac1@gmail.com", false, "Female", false, null, "Mai The Clone Duke", null, "qac1@gmail.com", "AQAAAAEAACcQAAAAEIbQKEqz4F3up9zy1X6LoyX+f5I1uZZjbuD2GRlcVDeiqmI5YXNi2OMoDJS/8KivhQ==", "0329226528", false, "0e621a32-43b9-4a37-9abc-f823e4b8c243", false, "Mai The Duc" }
========
                    { "1", 0, "Somewhere in the big gray sky", "", "1ed91cd1-537d-47b7-9c1f-521a3c9f847f", 1, new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Male", false, null, "Truong Dep Zai", null, "admin@gmail.com", "AQAAAAEAACcQAAAAEL4lX4W9e4iTjzE71Jd+L3cilXQJSCx4v04FKM0CeeudYQmHZu5AdRUmqzl/eAefxg==", "0983337621", false, "1e8c1755-d5bd-4204-a97c-b92656af3180", false, "Truong" },
                    { "2", 0, "Somewhere in the big gray sky", "", "31c6aecb-6e94-490b-9f95-06fc4bca318b", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", false, "Male", false, null, "Duke Mike The", null, "staff1@gmail.com", "AQAAAAEAACcQAAAAEKeGpWol9zPrE29tfbwSjsJlWRHYfZbTKJR27u1Eo39rAr89xlE+TqfSSPe2AImI3g==", "0329226528", false, "f42e85f5-b1ff-4d3b-8843-1222c430ea1e", false, "Duke Mike The" },
                    { "3", 0, "Somewhere in the big gray sky", "", "43714291-b1de-4a0b-8186-ce3492c1afd2", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "qam1@gmail.com", false, "Male", false, null, "Mike The Duke", null, "qam1@gmail.com", "AQAAAAEAACcQAAAAEE2d74QaxePn713FTBrU5/wNdkr3SuNbeBJDYQspkxbJY02xDl6FGM5S4Ykk1XMvEw==", "0329226528", false, "cd939b59-1817-4a94-a050-4c91443c893b", false, "Mike The Duke" },
                    { "4", 0, "Somewhere in the big gray sky", "", "7c78645f-e28d-4058-b9d4-85b6e0a318a3", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "qac1@gmail.com", false, "Female", false, null, "Mai The Clone Duke", null, "qac1@gmail.com", "AQAAAAEAACcQAAAAELPkHagfPLZTKdFvb9xCADRSVHnP9dtsySogApMqLpmm9l1dvwGXwKGH1j/7sLKFaA==", "0329226528", false, "8c5a2d7b-f654-4e98-aa99-2afe07770912", false, "Mai The Duc" }
>>>>>>>> 682a7991b0d5e12b750af3b7d147d77e2ca6c1cc:COMP1640/Migrations/20230318070727_test.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "A", "1" },
                    { "B", "2" },
                    { "C", "3" },
                    { "D", "4" }
                });

            migrationBuilder.InsertData(
                table: "Ideas",
                columns: new[] { "IdeaId", "CategoryId", "EventId", "ProfileId", "ReactPointId", "created_date", "idea_anonymous", "idea_content", "idea_title", "idea_view" },
                values: new object[,]
                {
                    { 1, 1, 1, "1", 1, null, false, "This is a Test", "Test", 0 },
                    { 2, 1, 2, "2", 2, null, false, "This is a Test #2", "Test #2", 0 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ComId", "IdeaId", "ProfileId", "com_anonymous", "com_content", "created_date" },
                values: new object[] { 1, 1, "1", false, "This is a great idea", null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepId",
                table: "AspNetUsers",
                column: "DepId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_IdeaId",
                table: "Comments",
                column: "IdeaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProfileId",
                table: "Comments",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_IdeaId",
                table: "Documents",
                column: "IdeaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_CategoryId",
                table: "Ideas",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_EventId",
                table: "Ideas",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_ProfileId",
                table: "Ideas",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_ReactPointId",
                table: "Ideas",
                column: "ReactPointId");

            migrationBuilder.CreateIndex(
                name: "IX_React_IdeaId",
                table: "React",
                column: "IdeaId");

            migrationBuilder.CreateIndex(
                name: "IX_React_ProfileId",
                table: "React",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Views_ProfileId",
                table: "Views",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "React");

            migrationBuilder.DropTable(
                name: "Views");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ideas");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "ReactPoints");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}