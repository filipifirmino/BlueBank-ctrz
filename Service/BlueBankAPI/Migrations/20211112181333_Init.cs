using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueBankAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NM_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DS_PHONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DS_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DS_CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_ACCOUNT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DT_CREATED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DT_UPDATED = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VL_BALANCE = table.Column<double>(type: "float", nullable: false),
                    ST_STATUS = table.Column<bool>(type: "bit", nullable: false),
                    ST_TYPE = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DT_CREATED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DT_UPDATED = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Accounts_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VL_VALUE = table.Column<double>(type: "float", nullable: false),
                    ID_CLIENT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_ACCOUNT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TP_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_CREATED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DT_UPDATED = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transactions_Accounts_ID_ACCOUNT",
                        column: x => x.ID_ACCOUNT,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ClientId",
                table: "Accounts",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ID_ACCOUNT",
                table: "Transactions",
                column: "ID_ACCOUNT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
