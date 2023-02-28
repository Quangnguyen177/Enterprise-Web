using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
<<<<<<<< HEAD:COMP1640/Migrations/20230228105053_media.cs
    public partial class media : Migration
========
    public partial class test : Migration
>>>>>>>> 756ba90 (hte almost ultimate interact react):COMP1640/Migrations/20230228205007_test.cs
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
                    DepId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    dep_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepId);
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
                    DepId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    first_closure = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_closure = table.Column<DateTime>(type: "datetime2", nullable: true),
                    idea_anonymous = table.Column<bool>(type: "bit", nullable: false),
                    idea_view = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ReactPointId = table.Column<int>(type: "int", nullable: false)
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
                    ComId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    com_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    doc_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doc_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
<<<<<<<< HEAD:COMP1640/Migrations/20230228105053_media.cs
                    { "A", "fab74328-490a-4e7f-a021-d5807cdf1bfa", "Administrator", "Administrator" },
                    { "B", "6291f2f5-c8a6-45be-937c-119649d89596", "Staff", "Staff" },
                    { "C", "a0d242c7-2bae-47f9-ba4d-4a8da36c89d4", "Quality Assurance Manager", "Quality Assurance Manager" },
                    { "D", "04d9c1ed-cefc-43c5-b300-d67ca8efb4f6", "Quality Assurance Coordinator", "Quality Assurance Coordinator" }
========
                    { "A", "52dd1c30-57d0-47a2-ae88-b89fe312b05c", "Administrator", "Administrator" },
                    { "B", "8a4accef-b7aa-481d-9539-04cce5f9e785", "Staff", "Staff" },
                    { "C", "154266d7-0d69-4b47-a0fe-0f8d7e613f1f", "Quality Assurance Manager", "Quality Assurance Manager" },
                    { "D", "1a98becc-54f8-4028-ae1b-bdf42f470de6", "Quality Assurance Coordinator", "Quality Assurance Coordinator" }
>>>>>>>> 756ba90 (hte almost ultimate interact react):COMP1640/Migrations/20230228205007_test.cs
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "category_name" },
                values: new object[] { 1, "Human Resource" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepId", "dep_name" },
                values: new object[] { "1", "Academic" });

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
<<<<<<<< HEAD:COMP1640/Migrations/20230228105053_media.cs
                values: new object[] { "1", 0, "Somewhere in the big gray sky", "", "1c9222a2-5497-4226-9729-ac4375ddf9f3", "1", new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Male", false, null, "Truong Dep Zai", null, "admin@gmail.com", "AQAAAAEAACcQAAAAEJAZR6da0uKTFIo+bWgL3GG/LJKceb6mmX/w9Rw3rQx49CUiMkvyyDZS7lBlYwhMHw==", "0983337621", false, "d1522749-89fd-4e12-adf9-a66e5593d20c", false, "Truong" });
========
                values: new object[] { "1", 0, "Somewhere in the big gray sky", "", "626a06c0-9288-469d-83e7-c13698d8b207", "1", new DateTime(2002, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Male", false, null, "Truong Dep Zai", null, "admin@gmail.com", "AQAAAAEAACcQAAAAEFjB1yFMntA1ZHYJ31Zbsrk+8j34B5A8KUazTVbwK0ZQLUPto72Ufzygvs5KIY95AA==", "0983337621", false, "120db52f-174f-4837-85e7-b75177b9a2e0", false, "Truong" });
>>>>>>>> 756ba90 (hte almost ultimate interact react):COMP1640/Migrations/20230228205007_test.cs

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "DepId", "DoB", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
<<<<<<<< HEAD:COMP1640/Migrations/20230228105053_media.cs
                values: new object[] { "2", 0, "Somewhere in the big gray sky", "", "c179a154-c322-4850-877b-3b3897ce1a09", "1", new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", false, "Male", false, null, "Duke Mike The", null, "staff1@gmail.com", "AQAAAAEAACcQAAAAEAivOnr928u2i5fWaZ0Dhnp+kGlFTBawvI2rlhEEYfTIkaVn/aXR4YmwZqIS2lldBA==", "0329226528", false, "7e06299b-84ea-499c-b609-2a86c1c443d7", false, "Duke Mike The" });
========
                values: new object[] { "2", 0, "Somewhere in the big gray sky", "", "e56a1778-9935-4756-b6db-18a0baea3ba9", "1", new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff1@gmail.com", false, "Male", false, null, "Duke Mike The", null, "staff1@gmail.com", "AQAAAAEAACcQAAAAENXptOT87yelq1D1IYK6PoBNljV9r9dMUvcjcPq+2Fs0LI9pQe5KMC1Mjh0/Vd/p+w==", "0329226528", false, "ca589120-03b6-4b17-8983-176168141c71", false, "Duke Mike The" });
>>>>>>>> 756ba90 (hte almost ultimate interact react):COMP1640/Migrations/20230228205007_test.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "A", "1" },
                    { "B", "2" }
                });

            migrationBuilder.InsertData(
                table: "Ideas",
                columns: new[] { "IdeaId", "CategoryId", "ProfileId", "ReactPointId", "created_date", "first_closure", "idea_anonymous", "idea_content", "idea_title", "idea_view", "last_closure" },
                values: new object[,]
                {
                    { 1, 1, "1", 1, null, null, false, "This is a Test", "Test", 0, null },
                    { 2, 1, "2", 2, null, null, false, "This is a Test #2", "Test #2", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ComId", "IdeaId", "ProfileId", "com_anonymous", "com_content" },
                values: new object[] { "1", 1, "1", false, "This is a great idea" });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "DocId", "IdeaId", "doc_content", "doc_type" },
                values: new object[] { 1, 1, "This is a word or pdf, it can be a file", "Word" });

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
                name: "ReactPoints");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
