using Microsoft.EntityFrameworkCore.Migrations;

namespace HistClinica.Migrations
{
    public partial class othertables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoEmpleado",
                columns: table => new
                {
                    idTipoEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmpleado", x => x.idTipoEmpleado);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoEmpleado");
        }
    }
}
