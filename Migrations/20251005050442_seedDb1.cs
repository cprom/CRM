using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class seedDb1 : Migration
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Users_AssignedAgentId",
                        column: x => x.AssignedAgentId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clients_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    ListingDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Users_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UserId = table.Column<int>(type: "int", nullable: true)
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ClientId1 = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deals_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deals_Clients_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "Clients",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ClientId1 = table.Column<int>(type: "int", nullable: true),
                    DealId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Clients_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Deals_DealId",
                        column: x => x.DealId,
                        principalTable: "Deals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Deals_DealId1",
                        column: x => x.DealId1,
                        principalTable: "Deals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_Users_UploadedById",
                        column: x => x.UploadedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedToId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DealId1 = table.Column<int>(type: "int", nullable: true)
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Deals_DealId1",
                        column: x => x.DealId1,
                        principalTable: "Deals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tasks_Users_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "Phone", "Role" },
                values: new object[,]
                {
                    { 1, "alice@crm.com", "Alice", "Johnson", "hashed_pw1", "555-1001", "Admin" },
                    { 2, "bob@crm.com", "Bob", "Smith", "hashed_pw2", "555-1002", "Agent" },
                    { 3, "charlie@crm.com", "Charlie", "Brown", "hashed_pw3", "555-1003", "Agent" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AssignedAgentId", "Email", "FirstName", "LastName", "Phone", "Source", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 2, "david.green@email.com", "David", "Green", "555-2001", "Website", "Lead", null },
                    { 2, 3, "eva.martinez@email.com", "Eva", "Martinez", "555-2002", "Referral", "Prospect", null }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "AgentId", "City", "ListingDate", "Price", "State", "Status", "Title", "Type", "UserId", "ZipCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", 2, "Los Angeles", new DateTime(2025, 10, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(5310), 750000m, "CA", "Available", "3-Bedroom House in LA", "Residential", null, "90001" },
                    { 2, "500 Business Rd", 3, "Los Angeles", new DateTime(2025, 10, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(5540), 1500000m, "CA", "Available", "Downtown Office Space", "Commercial", null, "90017" }
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "Id", "AgentId", "ClientId", "ClientId1", "ClosingDate", "ExpectedValue", "PropertyId", "Stage", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 1, null, new DateTime(2025, 11, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(6710), 740000m, 1, "Negotiation", null },
                    { 2, 3, 2, null, new DateTime(2025, 12, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(6870), 1490000m, 2, "Lead", null }
                });

            migrationBuilder.InsertData(
                table: "Interactions",
                columns: new[] { "Id", "AgentId", "ClientId", "Date", "Description", "Outcome", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2025, 10, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(7700), "Discussed financing options", "Interested", "Call", null },
                    { 2, 3, 2, new DateTime(2025, 10, 5, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(7930), "Sent property brochure", "Follow-up Needed", "Email", null }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "ClientId", "ClientId1", "DealId", "DealId1", "FileName", "FilePath", "UploadedAt", "UploadedById" },
                values: new object[,]
                {
                    { 1, 1, null, 1, null, "DavidGreen_Offer.pdf", "/docs/offers/DavidGreen_Offer.pdf", new DateTime(2025, 10, 5, 5, 4, 42, 311, DateTimeKind.Utc).AddTicks(150), 2 },
                    { 2, 2, null, 2, null, "EvaMartinez_Contract.pdf", "/docs/contracts/EvaMartinez_Contract.pdf", new DateTime(2025, 10, 5, 5, 4, 42, 311, DateTimeKind.Utc).AddTicks(270), 3 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AssignedToId", "ClientId", "DealId", "DealId1", "Description", "DueDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 2, 1, 1, null, "Book a house tour with David Green", new DateTime(2025, 10, 8, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(8570), "Pending", "Schedule Viewing" },
                    { 2, 3, 2, 2, null, "Prepare draft for Eva’s office space deal", new DateTime(2025, 10, 12, 5, 4, 42, 310, DateTimeKind.Utc).AddTicks(9150), "In Progress", "Prepare Contract Draft" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AssignedAgentId",
                table: "Clients",
                column: "AssignedAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_AgentId",
                table: "Deals",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_ClientId",
                table: "Deals",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_ClientId1",
                table: "Deals",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_PropertyId",
                table: "Deals",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_UserId",
                table: "Deals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ClientId",
                table: "Documents",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ClientId1",
                table: "Documents",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DealId",
                table: "Documents",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DealId1",
                table: "Documents",
                column: "DealId1");

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
                name: "IX_Interactions_UserId",
                table: "Interactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AgentId",
                table: "Properties",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserId",
                table: "Properties",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DealId1",
                table: "Tasks",
                column: "DealId1");
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
