using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Qita",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qita", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Davlatlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qita_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Davlatlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Davlatlar_Qita_Qita_Id",
                        column: x => x.Qita_Id,
                        principalTable: "Qita",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shaharlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Davlat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shaharlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shaharlar_Davlatlar_Davlat_id",
                        column: x => x.Davlat_id,
                        principalTable: "Davlatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Davlatlar_Qita_Id",
                table: "Davlatlar",
                column: "Qita_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shaharlar_Davlat_id",
                table: "Shaharlar",
                column: "Davlat_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shaharlar");

            migrationBuilder.DropTable(
                name: "Davlatlar");

            migrationBuilder.DropTable(
                name: "Qita");
        }
    }
}
