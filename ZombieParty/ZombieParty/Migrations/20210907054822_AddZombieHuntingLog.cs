using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty.Migrations
{
    public partial class AddZombieHuntingLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZombieHuntingLog",
                columns: table => new
                {
                    Zombie_Id = table.Column<int>(type: "int", nullable: false),
                    HuntingLog_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZombieHuntingLog", x => new { x.Zombie_Id, x.HuntingLog_Id });
                    table.ForeignKey(
                        name: "FK_ZombieHuntingLog_HuntingLog_HuntingLog_Id",
                        column: x => x.HuntingLog_Id,
                        principalTable: "HuntingLog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZombieHuntingLog_Zombie_Zombie_Id",
                        column: x => x.Zombie_Id,
                        principalTable: "Zombie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ZombieHuntingLog_HuntingLog_Id",
                table: "ZombieHuntingLog",
                column: "HuntingLog_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZombieHuntingLog");
        }
    }
}
