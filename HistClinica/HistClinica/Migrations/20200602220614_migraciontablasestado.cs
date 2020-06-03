using Microsoft.EntityFrameworkCore.Migrations;

namespace HistClinica.Migrations
{
    public partial class migraciontablasestado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    idCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codCita = table.Column<int>(nullable: false),
                    nroCita = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(nullable: true),
                    fechaCita = table.Column<string>(nullable: true),
                    ultCie10 = table.Column<string>(nullable: true),
                    servicio = table.Column<string>(nullable: true),
                    tpAtencion = table.Column<string>(nullable: true),
                    nroHC = table.Column<int>(nullable: false),
                    idEstadoCita = table.Column<int>(nullable: false),
                    idEstaGralPac = table.Column<int>(nullable: false),
                    estadoReprogram = table.Column<string>(nullable: true),
                    ejecutado = table.Column<string>(nullable: true),
                    prioridad = table.Column<string>(nullable: true),
                    precio = table.Column<double>(nullable: false),
                    descuento = table.Column<double>(nullable: false),
                    coa = table.Column<double>(nullable: false),
                    igv = table.Column<double>(nullable: false),
                    idPaciente = table.Column<int>(nullable: false),
                    idEmpleado = table.Column<int>(nullable: false),
                    idConsultorio = table.Column<int>(nullable: false),
                    idProgramMedica = table.Column<int>(nullable: false),
                    idTpAtencion = table.Column<int>(nullable: false),
                    idEstAtencion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.idCita);
                });

            migrationBuilder.CreateTable(
                name: "Consultorio",
                columns: table => new
                {
                    idConsultorio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroConsultorio = table.Column<string>(nullable: true),
                    tpConsultorio = table.Column<int>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    area = table.Column<string>(nullable: true),
                    piso = table.Column<string>(nullable: true),
                    idEspecialidad = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorio", x => x.idConsultorio);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCita",
                columns: table => new
                {
                    idEstadoCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codEstadoCita = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    origen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCita", x => x.idEstadoCita);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Consultorio");

            migrationBuilder.DropTable(
                name: "EstadoCita");
        }
    }
}
