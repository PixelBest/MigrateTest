using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MigrateTest.Migrations
{
    /// <inheritdoc />
    public partial class migrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Gost = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokazatels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GostsId = table.Column<int>(type: "integer", nullable: false),
                    Pokazatel = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokazatels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokazatels_Gosts_GostsId",
                        column: x => x.GostsId,
                        principalTable: "Gosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EIs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PokazatelsId = table.Column<int>(type: "integer", nullable: false),
                    EI = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EIs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EIs_Pokazatels_PokazatelsId",
                        column: x => x.PokazatelsId,
                        principalTable: "Pokazatels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EIs_PokazatelsId",
                table: "EIs",
                column: "PokazatelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokazatels_GostsId",
                table: "Pokazatels",
                column: "GostsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EIs");

            migrationBuilder.DropTable(
                name: "Pokazatels");

            migrationBuilder.DropTable(
                name: "Gosts");
        }
    }
}
