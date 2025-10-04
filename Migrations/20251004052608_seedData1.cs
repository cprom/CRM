using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class seedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(2750), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(3780), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(7180), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(6370), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(7350), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(7340), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadedAt",
                value: new DateTime(2025, 10, 4, 5, 26, 7, 733, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadedAt",
                value: new DateTime(2025, 10, 4, 5, 26, 7, 733, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(7730), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(8550), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ListingDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(5420), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ListingDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(5690), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(5700), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(8890), new DateTime(2025, 10, 7, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(9240), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(9870), new DateTime(2025, 10, 11, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(9870), new DateTime(2025, 10, 4, 5, 26, 7, 732, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 731, DateTimeKind.Utc).AddTicks(8180), new DateTime(2025, 10, 4, 5, 26, 7, 731, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 731, DateTimeKind.Utc).AddTicks(9220), new DateTime(2025, 10, 4, 5, 26, 7, 731, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 26, 7, 731, DateTimeKind.Utc).AddTicks(9230), new DateTime(2025, 10, 4, 5, 26, 7, 731, DateTimeKind.Utc).AddTicks(9230) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(3820), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(5040), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClosingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 11, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(8840), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7970), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClosingDate", "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(9050), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(9040), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadedAt",
                value: new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadedAt",
                value: new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(9460), new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(320), new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ListingDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(5660), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(6850), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ListingDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7100), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7100), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(680), new DateTime(2025, 10, 7, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(1040), new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(1690), new DateTime(2025, 10, 11, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(1690), new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(8480), new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(9650), new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(9650), new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(9660) });
        }
    }
}
