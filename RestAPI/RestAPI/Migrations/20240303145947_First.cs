using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestAPI.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intitulé = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialité = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Société = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nbpostes = table.Column<int>(type: "int", nullable: false),
                    Pays = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offre", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offre");
        }
    }
}
