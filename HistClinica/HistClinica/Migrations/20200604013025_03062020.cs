using Microsoft.EntityFrameworkCore.Migrations;

namespace HistClinica.Migrations
{
    public partial class _03062020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apeMaterno",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "apePaterno",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "celular",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "centroEduca",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "condicionRuc",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "dniAcom",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "dniPac",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "domiFiscal",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "edad",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "edadAcom",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "estadoRuc",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "fecNacimiento",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "fonoFijo",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "fotografia",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idEstCivil",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idEtnico",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idGrdInstruc",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idOcupacion",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idParentesco",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idReligion",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idSexo",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idUbigeoNace",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idUbigeoResi",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idciaSeguro",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "iddatoReniec",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "iddatoSiteds",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "iddatoSunat",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idemprConvenio",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idtipoIafa",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idtipoVia",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idtpDocumento",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "interior",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "manzana",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nombreAcom",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nombreVia",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nombres",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nroBlock",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nroDpto",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nroEtapa",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nroKm",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nroLote",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nroRuc",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nroVia",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "razonSocial",
                table: "Paciente");

            migrationBuilder.AlterColumn<string>(
                name: "idAsegurado",
                table: "Paciente",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "dniAcompana",
                table: "Paciente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "edadAcompana",
                table: "Paciente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idPersona",
                table: "Paciente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "nomAcompana",
                table: "Paciente",
                nullable: true);

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
                    name = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    salary = table.Column<int>(nullable: false),
                    precio = table.Column<double>(nullable: false),
                    fecIngreso = table.Column<string>(nullable: true),
                    idTipoEmpleado = table.Column<int>(nullable: false),
                    idHorario = table.Column<int>(nullable: false),
                    codEmpleado = table.Column<string>(nullable: true),
                    descArea = table.Column<string>(nullable: true),
                    cargo = table.Column<string>(nullable: true),
                    nroDni = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.idEmpleado);
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
                    nroColegio = table.Column<int>(nullable: false),
                    nroRne = table.Column<string>(nullable: true),
                    nroRuc = table.Column<int>(nullable: false),
                    tpDocumento = table.Column<int>(nullable: false),
                    nroDni = table.Column<int>(nullable: false),
                    area = table.Column<string>(nullable: true),
                    condicion = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    fecIngreso = table.Column<string>(nullable: true),
                    idEmpleado = table.Column<int>(nullable: false),
                    idEspecialidad = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.idMedico);
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
                    idtpDocumento = table.Column<int>(nullable: false),
                    dniPersona = table.Column<int>(nullable: false),
                    idSexo = table.Column<int>(nullable: false),
                    idEtnico = table.Column<int>(nullable: false),
                    fecNacimiento = table.Column<string>(nullable: true),
                    idUbigeoResi = table.Column<int>(nullable: false),
                    idtipoVia = table.Column<int>(nullable: false),
                    nombreVia = table.Column<string>(nullable: true),
                    nroVia = table.Column<int>(nullable: false),
                    nroDpto = table.Column<int>(nullable: false),
                    interior = table.Column<int>(nullable: false),
                    manzana = table.Column<int>(nullable: false),
                    nroLote = table.Column<int>(nullable: false),
                    nroKm = table.Column<int>(nullable: false),
                    nroBlock = table.Column<int>(nullable: false),
                    nroEtapa = table.Column<int>(nullable: false),
                    edad = table.Column<int>(nullable: false),
                    idUbigeoNace = table.Column<int>(nullable: false),
                    fotografia = table.Column<string>(nullable: true),
                    idGrdInstruc = table.Column<int>(nullable: false),
                    idReligion = table.Column<int>(nullable: false),
                    centroEduca = table.Column<string>(nullable: true),
                    idEstCivil = table.Column<int>(nullable: false),
                    idOcupacion = table.Column<int>(nullable: false),
                    idgpoSangre = table.Column<int>(nullable: false),
                    idFactorrh = table.Column<int>(nullable: false),
                    nroRuc = table.Column<int>(nullable: false),
                    razonSocial = table.Column<string>(nullable: true),
                    estadoRuc = table.Column<string>(nullable: true),
                    condicionRuc = table.Column<string>(nullable: true),
                    domiFiscal = table.Column<string>(nullable: true),
                    idParentesco = table.Column<int>(nullable: false),
                    telefono = table.Column<int>(nullable: false),
                    celular = table.Column<int>(nullable: false),
                    correo = table.Column<string>(nullable: true),
                    idPaciente = table.Column<int>(nullable: false),
                    idEmpleado = table.Column<int>(nullable: false),
                    idMedico = table.Column<int>(nullable: true),
                    idUsuario = table.Column<int>(nullable: false),
                    iddatoReniec = table.Column<int>(nullable: false),
                    iddatoSunat = table.Column<int>(nullable: false),
                    iddatoSiteds = table.Column<int>(nullable: false),
                    idemprConvenio = table.Column<int>(nullable: false),
                    idciaSeguro = table.Column<int>(nullable: false),
                    idtipoIafa = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.idPersona);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "CronoMedico");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "dniAcompana",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "edadAcompana",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "idPersona",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "nomAcompana",
                table: "Paciente");

            migrationBuilder.AlterColumn<int>(
                name: "idAsegurado",
                table: "Paciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "apeMaterno",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "apePaterno",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "celular",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "centroEduca",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "condicionRuc",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "dniAcom",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "dniPac",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "domiFiscal",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "edad",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "edadAcom",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "estadoRuc",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fecNacimiento",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fonoFijo",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "fotografia",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idEstCivil",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idEtnico",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idGrdInstruc",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idOcupacion",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idParentesco",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idReligion",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSexo",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUbigeoNace",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUbigeoResi",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idciaSeguro",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iddatoReniec",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iddatoSiteds",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iddatoSunat",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idemprConvenio",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipoIafa",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipoVia",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtpDocumento",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "interior",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "manzana",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "nombreAcom",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombreVia",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombres",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "nroBlock",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nroDpto",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nroEtapa",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nroKm",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nroLote",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nroRuc",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "nroVia",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "razonSocial",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
