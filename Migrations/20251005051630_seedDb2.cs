using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class seedDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClosingDate",
                value: new DateTime(2025, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClosingDate",
                value: new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadedAt",
                value: new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadedAt",
                value: new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "ListingDate",
                value: new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "ListingDate",
                value: new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2025, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClosingDate",
                value: new DateTime(2025, 11, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClosingDate",
                value: new DateTime(2025, 12, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadedAt",
                value: new DateTime(2025, 10, 5, 5, 4, 42, 311, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadedAt",
                value: new DateTime(2025, 10, 5, 5, 4, 42, 311, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 10, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 10, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "ListingDate",
                value: new DateTime(2025, 10, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "ListingDate",
                value: new DateTime(2025, 10, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2025, 10, 8, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2025, 10, 12, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(9150));
        }
    }
}
