using Microsoft.EntityFrameworkCore.Migrations;

namespace HistClinica.Migrations
{
    public partial class prueba : Migration
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
                name: "CronoMedico",
                columns: table => new
                {
                    idProgramMedica = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mes = table.Column<string>(nullable: true),
                    semana = table.Column<string>(nullable: true),
                    dia = table.Column<string>(nullable: true),
                    fecProgramMedica = table.Column<string>(nullable: true),
                    idMedico = table.Column<int>(nullable: false),
                    dsMedico = table.Column<string>(nullable: true),
                    idEspecialidad = table.Column<int>(nullable: false),
                    dsEspecialidad = table.Column<string>(nullable: true),
                    idConsultorio = table.Column<int>(nullable: false),
                    dsConsultorio = table.Column<string>(nullable: true),
                    dsHrInicio = table.Column<string>(nullable: true),
                    dsHrFin = table.Column<string>(nullable: true),
                    idEstado = table.Column<int>(nullable: false),
                    dsEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CronoMedico", x => x.idProgramMedica);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    idEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(nullable: true),
                    genero = table.Column<string>(nullable: true),
                    salario = table.Column<int>(nullable: true),
                    precio = table.Column<double>(nullable: true),
                    fecIngreso = table.Column<string>(nullable: true),
                    idTipoEmpleado = table.Column<int>(nullable: true),
                    idHorario = table.Column<int>(nullable: true),
                    codEmpleado = table.Column<string>(nullable: true),
                    descArea = table.Column<string>(nullable: true),
                    cargo = table.Column<string>(nullable: true),
                    nroDni = table.Column<int>(nullable: true),
                    idPersona = table.Column<int>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.idEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    idEspecialidad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codEspecialidad = table.Column<string>(nullable: true),
                    codSigesa = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    codSubEspecial = table.Column<string>(nullable: true),
                    descSubEspecial = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.idEspecialidad);
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

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    idMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codMedico = table.Column<string>(nullable: true),
                    especialidad = table.Column<string>(nullable: true),
                    cargo = table.Column<string>(nullable: true),
                    nombres = table.Column<string>(nullable: true),
                    apellidos = table.Column<string>(nullable: true),
                    nroColegio = table.Column<int>(nullable: true),
                    nroRne = table.Column<string>(nullable: true),
                    nroRuc = table.Column<int>(nullable: true),
                    tpDocumento = table.Column<int>(nullable: true),
                    nroDni = table.Column<int>(nullable: true),
                    area = table.Column<string>(nullable: true),
                    condicion = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    fecIngreso = table.Column<string>(nullable: true),
                    idEmpleado = table.Column<int>(nullable: true),
                    idEspecialidad = table.Column<int>(nullable: true),
                    idPersona = table.Column<int>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.idMedico);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    idPaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idtpPaciente = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(nullable: true),
                    idAsegurado = table.Column<string>(nullable: true),
                    nrohc = table.Column<int>(nullable: false),
                    nomAcompana = table.Column<string>(nullable: true),
                    edadAcompana = table.Column<int>(nullable: false),
                    dniAcompana = table.Column<int>(nullable: false),
                    idgpoSangre = table.Column<int>(nullable: false),
                    idFactorrh = table.Column<int>(nullable: false),
                    idPersona = table.Column<int>(nullable: false),
                    idPacConvenio = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.idPaciente);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    idPersona = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apePaterno = table.Column<string>(nullable: true),
                    apeMaterno = table.Column<string>(nullable: true),
                    nombres = table.Column<string>(nullable: true),
                    idtpDocumento = table.Column<int>(nullable: true),
                    dniPersona = table.Column<int>(nullable: true),
                    idSexo = table.Column<int>(nullable: true),
                    idEtnico = table.Column<int>(nullable: true),
                    fecNacimiento = table.Column<string>(nullable: true),
                    idUbigeoResi = table.Column<int>(nullable: true),
                    idtipoVia = table.Column<int>(nullable: true),
                    nombreVia = table.Column<string>(nullable: true),
                    nroVia = table.Column<int>(nullable: true),
                    nroDpto = table.Column<int>(nullable: true),
                    interior = table.Column<int>(nullable: true),
                    manzana = table.Column<int>(nullable: true),
                    nroLote = table.Column<int>(nullable: true),
                    nroKm = table.Column<int>(nullable: true),
                    nroBlock = table.Column<int>(nullable: true),
                    nroEtapa = table.Column<int>(nullable: true),
                    edad = table.Column<int>(nullable: true),
                    idUbigeoNace = table.Column<int>(nullable: true),
                    fotografia = table.Column<string>(nullable: true),
                    idGrdInstruc = table.Column<int>(nullable: true),
                    idReligion = table.Column<int>(nullable: true),
                    centroEduca = table.Column<string>(nullable: true),
                    idEstCivil = table.Column<int>(nullable: true),
                    idOcupacion = table.Column<int>(nullable: true),
                    idgpoSangre = table.Column<int>(nullable: true),
                    idFactorrh = table.Column<int>(nullable: true),
                    nroRuc = table.Column<int>(nullable: true),
                    razonSocial = table.Column<string>(nullable: true),
                    estadoRuc = table.Column<string>(nullable: true),
                    condicionRuc = table.Column<string>(nullable: true),
                    domiFiscal = table.Column<string>(nullable: true),
                    idParentesco = table.Column<int>(nullable: true),
                    telefono = table.Column<int>(nullable: true),
                    celular = table.Column<int>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    iddatoReniec = table.Column<int>(nullable: true),
                    iddatoSunat = table.Column<int>(nullable: true),
                    iddatoSiteds = table.Column<int>(nullable: true),
                    idemprConvenio = table.Column<int>(nullable: true),
                    idciaSeguro = table.Column<int>(nullable: true),
                    idtipoIafa = table.Column<int>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.idPersona);
                });

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
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Consultorio");

            migrationBuilder.DropTable(
                name: "CronoMedico");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "EstadoCita");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "TipoEmpleado");
        }
    }
}
