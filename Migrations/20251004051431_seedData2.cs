using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class seedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedAgentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Users_AssignedAgentId",
                        column: x => x.AssignedAgentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ListingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Users_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interactions_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interactions_Users_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deals_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deals_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deals_Users_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadedById = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: true),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Documents_Deals_DealId",
                        column: x => x.DealId,
                        principalTable: "Deals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Documents_Users_UploadedById",
                        column: x => x.UploadedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedToId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Deals_DealId",
                        column: x => x.DealId,
                        principalTable: "Deals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(8480), "alice@crm.com", "Alice", "Johnson", "hashed_pw1", "555-1001", "Admin", new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(8490) },
                    { 2, new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(9650), "bob@crm.com", "Bob", "Smith", "hashed_pw2", "555-1002", "Agent", new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(9650) },
                    { 3, new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(9650), "charlie@crm.com", "Charlie", "Brown", "hashed_pw3", "555-1003", "Agent", new DateTime(2025, 10, 4, 5, 14, 31, 247, DateTimeKind.Utc).AddTicks(9660) }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AssignedAgentId", "CreatedAt", "Email", "FirstName", "LastName", "Phone", "Source", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(3820), "david.green@email.com", "David", "Green", "555-2001", "Website", "Lead", new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(3820) },
                    { 2, 3, new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(5040), "eva.martinez@email.com", "Eva", "Martinez", "555-2002", "Referral", "Prospect", new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(5040) }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "AgentId", "City", "CreatedAt", "ListingDate", "Price", "State", "Status", "Title", "Type", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", 2, "Los Angeles", new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(5660), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(6850), 750000m, "CA", "Available", "3-Bedroom House in LA", "Residential", new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(5660), "90001" },
                    { 2, "500 Business Rd", 3, "Los Angeles", new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7100), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7100), 1500000m, "CA", "Available", "Downtown Office Space", "Commercial", new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7100), "90017" }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "AgentId", "ClientId", "ClosingDate", "CreatedAt", "ExpectedValue", "PropertyId", "Stage", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2025, 11, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(8840), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7970), 740000m, 1, "Negotiation", new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(7970) },
                    { 2, 3, 2, new DateTime(2025, 12, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(9050), new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(9040), 1490000m, 2, "Lead", new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(9040) }
                });

            migrationBuilder.InsertData(
                table: "Interactions",
                columns: new[] { "Id", "AgentId", "ClientId", "CreatedAt", "Date", "Description", "Outcome", "Type" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2025, 10, 4, 5, 14, 31, 248, DateTimeKind.Utc).AddTicks(9460), new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(60), "Discussed financing options", "Interested", "Call" },
                    { 2, 3, 2, new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(320), new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(320), "Sent property brochure", "Follow-up Needed", "Email" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "ClientId", "DealId", "FileName", "FilePath", "UploadedAt", "UploadedById" },
                values: new object[,]
                {
                    { 1, 1, 1, "DavidGreen_Offer.pdf", "/docs/offers/DavidGreen_Offer.pdf", new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(2770), 2 },
                    { 2, 2, 2, "EvaMartinez_Contract.pdf", "/docs/contracts/EvaMartinez_Contract.pdf", new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(4400), 3 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AssignedToId", "ClientId", "CreatedAt", "DealId", "Description", "DueDate", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(680), 1, "Book a house tour with David Green", new DateTime(2025, 10, 7, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(1040), "Pending", "Schedule Viewing", new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(680) },
                    { 2, 3, 2, new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(1690), 2, "Prepare draft for Eva’s office space deal", new DateTime(2025, 10, 11, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(1690), "In Progress", "Prepare Contract Draft", new DateTime(2025, 10, 4, 5, 14, 31, 249, DateTimeKind.Utc).AddTicks(1690) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AssignedAgentId",
                table: "Clients",
                column: "AssignedAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_AgentId",
                table: "Deals",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_ClientId",
                table: "Deals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_PropertyId",
                table: "Deals",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ClientId",
                table: "Documents",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DealId",
                table: "Documents",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UploadedById",
                table: "Documents",
                column: "UploadedById");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_AgentId",
                table: "Interactions",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Interactions_ClientId",
                table: "Interactions",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AgentId",
                table: "Properties",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AssignedToId",
                table: "Tasks",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ClientId",
                table: "Tasks",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DealId",
                table: "Tasks",
                column: "DealId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Interactions");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Deals");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
