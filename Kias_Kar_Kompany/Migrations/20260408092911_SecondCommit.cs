using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kias_Kar_Kompany.Migrations
{
    /// <inheritdoc />
    public partial class SecondCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Manufacturer_ManufacturerId",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "Vehicle",
                newName: "Manufacturerid");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_ManufacturerId",
                table: "Vehicle",
                newName: "IX_Vehicle_Manufacturerid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Manufacturer",
                newName: "Manufacturerid");

            migrationBuilder.AddColumn<int>(
                name: "Ownerid",
                table: "Vehicle",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Ownerid",
                table: "Vehicle",
                column: "Ownerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Manufacturer_Manufacturerid",
                table: "Vehicle",
                column: "Manufacturerid",
                principalTable: "Manufacturer",
                principalColumn: "Manufacturerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Owner_Ownerid",
                table: "Vehicle",
                column: "Ownerid",
                principalTable: "Owner",
                principalColumn: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Manufacturer_Manufacturerid",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Owner_Ownerid",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_Ownerid",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Ownerid",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "Manufacturerid",
                table: "Vehicle",
                newName: "ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_Manufacturerid",
                table: "Vehicle",
                newName: "IX_Vehicle_ManufacturerId");

            migrationBuilder.RenameColumn(
                name: "Manufacturerid",
                table: "Manufacturer",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Manufacturer_ManufacturerId",
                table: "Vehicle",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id");
        }
    }
}
