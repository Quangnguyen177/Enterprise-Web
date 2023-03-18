using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class run : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Username);
                });

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
<<<<<<<< HEAD:COMP1640/Migrations/20230317180600_run.cs
                    { "A", "4ba9bdc9-bc4d-4df9-b80f-3d592eba266d", "Administrator", "Administrator" },
                    { "B", "aa2ef90c-b8ea-4f04-b1d8-339220f68b7d", "Staff", "Staff" },
                    { "C", "916736a1-e41e-4072-83d0-04614c31e672", "Quality Assurance Manager", "Quality Assurance Manager" },
                    { "D", "1830107b-724c-469e-bcef-9c1968b58f2e", "Quality Assurance Coordinator", "Quality Assurance Coordinator" }
========
                    { "A", "0ebecbdc-2980-4642-884b-c9cacf772254", "Administrator", "Administrator" },
                    { "B", "3bf51cfe-a75f-4fbb-bc8e-74deb34a36bc", "Staff", "Staff" },
                    { "C", "d86e4be2-9a44-4f67-9605-151f6428da75", "Quality Assurance Manager", "Quality Assurance Manager" },
                    { "D", "15965257-caf5-4055-8111-9159bef25c01", "Quality Assurance Coordinator", "Quality Assurance Coordinator" }
>>>>>>>> 39611da (Finish the update without avatar):COMP1640/Migrations/20230317074216_test.cs
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
<<<<<<<< HEAD:COMP1640/Migrations/20230317180600_run.cs
                    { "1", 0, "Somewhere in the big gray sky", "", "dcf4ba1d-f464-4174-bb71-1a38614fe6e9", 1, new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Male", false, null, "Truong Dep Zai", null, "admin@gmail.com", "AQAAAAEAACcQAAAAEEEi8AylXkqlQOY3FcYQlXSowXqw734cNd05H0SN7VVwuYwV/x/V6uq2sSJHgfWCSw==", "0983337621", false, "f753d898-70b7-46e4-acbc-b8369bc8693c", false, "Truong" },
                    { "2", 0, "Somewhere in the big gray sky", "", "9ef2a3ec-19a8-4e30-94c6-b094071873fd", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", false, "Male", false, null, "Duke Mike The", null, "staff1@gmail.com", "AQAAAAEAACcQAAAAEImmLL8vxX8nz+rxhHcM8K+l3akz8V1D2dUzh087LLNZxolFDzUyGcQU9mZkIX9/OA==", "0329226528", false, "70f790df-9fd7-4b52-925d-df3150895c54", false, "Duke Mike The" },
                    { "3", 0, "Somewhere in the big gray sky", "", "fd6909cb-ecbf-4455-9a21-c5a15d3ed930", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "qam1@gmail.com", false, "Male", false, null, "Mike The Duke", null, "qam1@gmail.com", "AQAAAAEAACcQAAAAEMthVnZbg7V44OtvOuWofhcz64tzqU4HbDS61wGhrs9FwcLrrZRxtwSVc7DSpA09OA==", "0329226528", false, "9eb5bea2-25ed-417e-85a7-e4f4f69d4642", false, "Mike The Duke" },
                    { "4", 0, "Somewhere in the big gray sky", "", "5ef1d074-fe1e-4553-9ed6-ea481c78dd40", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "qac1@gmail.com", false, "Female", false, null, "Mai The Clone Duke", null, "qac1@gmail.com", "AQAAAAEAACcQAAAAENzEw3fVM7dnjhZJSY4Yc87mLxqmQ33etIG4+WkhTsXPTrm7mRPFiS5BquInoVqtiQ==", "0329226528", false, "f22bdaf6-7f29-4baf-8eb8-24f4892b75a2", false, "Mai The Duc" }
========
                    { "1", 0, "Somewhere in the big gray sky", "", "b1893b10-1bcc-4478-8db6-94b6f24fe257", 1, new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Male", false, null, "Truong Dep Zai", null, "admin@gmail.com", "AQAAAAEAACcQAAAAEAyVQkiePSAp2CQ6rzmJm/kgNphuV/1WROr09k+dL4jl73mynXeImzYogG9qwWWvEQ==", "0983337621", false, "b8896ae4-5852-4032-8b47-36fce75bdb70", false, "Truong" },
                    { "2", 0, "Somewhere in the big gray sky", "", "8c225a44-5cb3-4ab0-808b-66dd046f01b3", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", false, "Male", false, null, "Duke Mike The", null, "staff1@gmail.com", "AQAAAAEAACcQAAAAEHAlOm/CGcTW9jnlLa2wzq3osHJMP6TdjG26lUklGDigRi2qwJWmNb75OjGo8qudaw==", "0329226528", false, "badb7af3-8133-47f5-a25e-f834ba018bc4", false, "Duke Mike The" },
                    { "3", 0, "Somewhere in the big gray sky", "", "2dc94e66-439d-4332-8026-0bd414ea3688", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "qam1@gmail.com", false, "Male", false, null, "Mike The Duke", null, "qam1@gmail.com", "AQAAAAEAACcQAAAAEDE3OXlXCuVuLRX5rRMCZEJfA+3EElrRglXf5JI+/RlsxSnhTTqOFSvoK/80MDtp8g==", "0329226528", false, "26d99d4d-a92e-418d-b92a-46e32da2197e", false, "Mike The Duke" },
                    { "4", 0, "Somewhere in the big gray sky", "", "9bcc01fd-f2b7-4be2-8e6d-a3787b5f3ed5", 1, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "qac1@gmail.com", false, "Female", false, null, "Mai The Clone Duke", null, "qac1@gmail.com", "AQAAAAEAACcQAAAAEGVm6eSVqBm8/shNx/WAkZjy18lKcGShBdKgeOSRk1d4vba5+EM3tcG9gqCwXiVMdw==", "0329226528", false, "f5ab6e52-2a2a-446e-8eea-6023abdeec8a", false, "Mai The Duc" }
>>>>>>>> 39611da (Finish the update without avatar):COMP1640/Migrations/20230317074216_test.cs
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
                name: "Accounts");

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
