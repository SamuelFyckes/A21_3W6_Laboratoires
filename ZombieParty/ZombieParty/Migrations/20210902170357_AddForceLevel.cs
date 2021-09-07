using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty.Migrations
{
    public partial class AddForceLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Zombie");

            migrationBuilder.AddColumn<int>(
                name: "ForceLevelId",
                table: "Zombie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForceLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForceLevelNiv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForceLevel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zombie_ForceLevelId",
                table: "Zombie",
                column: "ForceLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zombie_ForceLevel_ForceLevelId",
                table: "Zombie",
                column: "ForceLevelId",
                principalTable: "ForceLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zombie_ForceLevel_ForceLevelId",
                table: "Zombie");

            migrationBuilder.DropTable(
                name: "ForceLevel");

            migrationBuilder.DropIndex(
                name: "IX_Zombie_ForceLevelId",
                table: "Zombie");

            migrationBuilder.DropColumn(
                name: "ForceLevelId",
                table: "Zombie");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Zombie",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
