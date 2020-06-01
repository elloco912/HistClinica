using Microsoft.EntityFrameworkCore.Migrations;

namespace HistClinica.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    idPaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apePaterno = table.Column<string>(nullable: true),
                    apeMaterno = table.Column<string>(nullable: true),
                    nombres = table.Column<string>(nullable: true),
                    idtpDocumento = table.Column<int>(nullable: false),
                    dniPac = table.Column<int>(nullable: false),
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
                    nrohc = table.Column<int>(nullable: false),
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
                    nombreAcom = table.Column<string>(nullable: true),
                    edadAcom = table.Column<int>(nullable: false),
                    dniAcom = table.Column<int>(nullable: false),
                    fonoFijo = table.Column<int>(nullable: false),
                    celular = table.Column<int>(nullable: false),
                    correo = table.Column<string>(nullable: true),
                    idtpPaciente = table.Column<int>(nullable: false),
                    idAsegurado = table.Column<int>(nullable: false),
                    idPacConvenio = table.Column<int>(nullable: false),
                    iddatoReniec = table.Column<int>(nullable: false),
                    iddatoSunat = table.Column<int>(nullable: false),
                    iddatoSiteds = table.Column<int>(nullable: false),
                    idemprConvenio = table.Column<int>(nullable: false),
                    idciaSeguro = table.Column<int>(nullable: false),
                    idtipoIafa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.idPaciente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
