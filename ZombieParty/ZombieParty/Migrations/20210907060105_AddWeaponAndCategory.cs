using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty.Migrations
{
    public partial class AddWeaponAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HunterId",
                table: "HuntingLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hunter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hunter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapon_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeaponHunter",
                columns: table => new
                {
                    Hunter_Id = table.Column<int>(type: "int", nullable: false),
                    Weapon_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponHunter", x => new { x.Weapon_Id, x.Hunter_Id });
                    table.ForeignKey(
                        name: "FK_WeaponHunter_Hunter_Hunter_Id",
                        column: x => x.Hunter_Id,
                        principalTable: "Hunter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponHunter_Weapon_Weapon_Id",
                        column: x => x.Weapon_Id,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntingLog_HunterId",
                table: "HuntingLog",
                column: "HunterId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_CategoryId",
                table: "Weapon",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponHunter_Hunter_Id",
                table: "WeaponHunter",
                column: "Hunter_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HuntingLog_Hunter_HunterId",
                table: "HuntingLog",
                column: "HunterId",
                principalTable: "Hunter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuntingLog_Hunter_HunterId",
                table: "HuntingLog");

            migrationBuilder.DropTable(
                name: "WeaponHunter");

            migrationBuilder.DropTable(
                name: "Hunter");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_HuntingLog_HunterId",
                table: "HuntingLog");

            migrationBuilder.DropColumn(
                name: "HunterId",
                table: "HuntingLog");
        }
    }
}
