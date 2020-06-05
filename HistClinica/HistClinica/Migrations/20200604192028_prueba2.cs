using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HistClinica.Migrations
{
    public partial class prueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idEmpleado",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "idMedico",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "idPaciente",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "idUsuario",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "salary",
                table: "Empleado");

            migrationBuilder.AddColumn<int>(
                name: "idEmpleado",
                table: "Medico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idPersona",
                table: "Medico",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idHorario",
                table: "Empleado",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "fecIngreso",
                table: "Empleado",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "genero",
                table: "Empleado",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idPersona",
                table: "Empleado",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombres",
                table: "Empleado",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "salario",
                table: "Empleado",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idEmpleado",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "idPersona",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "genero",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "idPersona",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "nombres",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "salario",
                table: "Empleado");

            migrationBuilder.AddColumn<int>(
                name: "idEmpleado",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idMedico",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idPaciente",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idUsuario",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idHorario",
                table: "Empleado",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecIngreso",
                table: "Empleado",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Empleado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Empleado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "salary",
                table: "Empleado",
                type: "int",
                nullable: true);
        }
    }
}
