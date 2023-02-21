using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP1640.Migrations
{
    public partial class testRun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "82e63bbf-b8e6-43e2-a672-fb7787c24afe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "a93c3845-bb09-4897-b5d9-bfbd5f8223da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "5dc18251-f730-4bc3-9851-fb8fa74c0e50");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D",
                column: "ConcurrencyStamp",
                value: "aeab76f0-99d6-44a4-aa54-170373db805a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2711c4ad-e6af-4322-a38c-20be586c5b82", "AQAAAAEAACcQAAAAENVth6kclPTWLMNDIz1BiliH8BAWu3b1qdASv6ludleCU3M4coEgNLR3BtO55qASFg==", "c11a48a4-5beb-42ef-8b27-04644cec047a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c96e999f-57bc-41cf-8113-8d5ff84a686f", "AQAAAAEAACcQAAAAEFwiUcTA/dV5SjiJaduH3n3cSHKymuz08eNIBYc59NGzwIVqskR6Ur9iCqLHhda4Aw==", "e7136041-0af9-42eb-9c2f-3a0c6c400953" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "c9a9bac8-29c5-4833-baa9-4d7068c5d9bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "f4bac571-a897-4f77-9246-5399e0ceee60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "e61519c9-0cd7-40ed-91e5-1fd581257992");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D",
                column: "ConcurrencyStamp",
                value: "b4f89682-5d68-4c2f-bc55-68302b13e2a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "197a748b-efcf-4cad-8dcd-b151a84f9565", "AQAAAAEAACcQAAAAEEUWhff2BVPYRAHRAgfARiloA3u/lXl5QU5jhKJWFGoA2drSCY+ZQ3Ijvg+ALF57Pg==", "9b757be5-16f0-4d51-bb78-540cb5bece68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "993ff4e5-d0e9-47b0-8c2d-6bbb40f474dc", "AQAAAAEAACcQAAAAENVW/3my4/T0RCY9XhqrmoPjBqlOYHG5BXnteGFsQ41JzOWKth1oqIIji2eJ3Ndfyw==", "24d315e7-2a75-4f36-875c-a99089d07ff8" });
        }
    }
}
