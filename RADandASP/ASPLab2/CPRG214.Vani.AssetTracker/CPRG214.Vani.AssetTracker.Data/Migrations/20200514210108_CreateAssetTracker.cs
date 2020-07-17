using Microsoft.EntityFrameworkCore.Migrations;

namespace CPRG214.Vani.AssetTracker.Data.Migrations
{
    public partial class CreateAssetTracker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagNo = table.Column<string>(nullable: false),
                    AssetTypeId = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    SNo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Computer" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Monitors" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Phone" });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "AssetTypeId", "Description", "Manufacturer", "Model", "SNo", "TagNo" },
                values: new object[,]
                {
                    { 1, 1, "Computers by Dell", "Computer", "Dell", "C2DELL", "1234" },
                    { 2, 1, "Computers by HP", "Computer", "HP", "C1HP", "1034" },
                    { 3, 1, "Computers by Acer", "Computer", "Acer", "C1ACER", "1205" },
                    { 4, 2, "Monitors by Acer", "Monitor", "Acer", "M2ACER", "5401" },
                    { 5, 2, "Monitors By LG", "Monitor", "LG", "M3LG", "1204" },
                    { 6, 2, "Monitors By HP", "Monitor", "HP", "M1HP", "1001" },
                    { 7, 3, "Phones By Avaya", "Phone", "Avaya", "P4AVAYA", "1308" },
                    { 8, 3, "Phones By Polycom", "Phone", "Polycom", "P3PPLY", "1400" },
                    { 9, 3, "Phones By Cisco", "Phone", "Cisco", "P9CISCO", "1604" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "AssetType");
        }
    }
}
