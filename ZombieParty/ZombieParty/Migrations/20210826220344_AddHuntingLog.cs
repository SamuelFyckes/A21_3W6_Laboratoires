using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty.Migrations
{
    public partial class AddHuntingLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZombieTypeId",
                table: "Zombie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HuntingLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntingLog", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zombie_ZombieTypeId",
                table: "Zombie",
                column: "ZombieTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zombie_ZombieType_ZombieTypeId",
                table: "Zombie",
                column: "ZombieTypeId",
                principalTable: "ZombieType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zombie_ZombieType_ZombieTypeId",
                table: "Zombie");

            migrationBuilder.DropTable(
                name: "HuntingLog");

            migrationBuilder.DropIndex(
                name: "IX_Zombie_ZombieTypeId",
                table: "Zombie");

            migrationBuilder.DropColumn(
                name: "ZombieTypeId",
                table: "Zombie");
        }
    }
}
