﻿// <auto-generated />
using System;
using HistClinica.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HistClinica.Migrations
{
    [DbContext(typeof(ClinicaServiceContext))]
    [Migration("20200604013025_03062020")]
    partial class _03062020
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HistClinica.Models.Cita", b =>
                {
                    b.Property<int>("idCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("coa")
                        .HasColumnType("float");

                    b.Property<int>("codCita")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("descuento")
                        .HasColumnType("float");

                    b.Property<string>("ejecutado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoReprogram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idConsultorio")
                        .HasColumnType("int");

                    b.Property<int>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("idEstAtencion")
                        .HasColumnType("int");

                    b.Property<int>("idEstaGralPac")
                        .HasColumnType("int");

                    b.Property<int>("idEstadoCita")
                        .HasColumnType("int");

                    b.Property<int>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int>("idProgramMedica")
                        .HasColumnType("int");

                    b.Property<int>("idTpAtencion")
                        .HasColumnType("int");

                    b.Property<double>("igv")
                        .HasColumnType("float");

                    b.Property<int>("nroCita")
                        .HasColumnType("int");

                    b.Property<int>("nroHC")
                        .HasColumnType("int");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<string>("prioridad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tpAtencion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ultCie10")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCita");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("HistClinica.Models.CronoMedico", b =>
                {
                    b.Property<int>("idProgramMedica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsConsultorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsEspecialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsHrFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsHrInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsMedico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecProgramMedica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idConsultorio")
                        .HasColumnType("int");

                    b.Property<int>("idEspecialidad")
                        .HasColumnType("int");

                    b.Property<int>("idEstado")
                        .HasColumnType("int");

                    b.Property<int>("idMedico")
                        .HasColumnType("int");

                    b.Property<string>("mes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("semana")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProgramMedica");

                    b.ToTable("CronoMedico");
                });

            modelBuilder.Entity("HistClinica.Models.Empleado", b =>
                {
                    b.Property<int>("idEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codEmpleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecIngreso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idHorario")
                        .HasColumnType("int");

                    b.Property<int>("idTipoEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroDni")
                        .HasColumnType("int");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("idEmpleado");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("HistClinica.Models.Medico", b =>
                {
                    b.Property<int>("idMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codMedico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecIngreso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("idEspecialidad")
                        .HasColumnType("int");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroColegio")
                        .HasColumnType("int");

                    b.Property<int>("nroDni")
                        .HasColumnType("int");

                    b.Property<string>("nroRne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroRuc")
                        .HasColumnType("int");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tpDocumento")
                        .HasColumnType("int");

                    b.HasKey("idMedico");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("HistClinica.Models.Paciente", b =>
                {
                    b.Property<int>("idPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dniAcompana")
                        .HasColumnType("int");

                    b.Property<int>("edadAcompana")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idAsegurado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idFactorrh")
                        .HasColumnType("int");

                    b.Property<int>("idPacConvenio")
                        .HasColumnType("int");

                    b.Property<int>("idPersona")
                        .HasColumnType("int");

                    b.Property<int>("idgpoSangre")
                        .HasColumnType("int");

                    b.Property<int>("idtpPaciente")
                        .HasColumnType("int");

                    b.Property<string>("nomAcompana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nrohc")
                        .HasColumnType("int");

                    b.HasKey("idPaciente");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("HistClinica.Models.Persona", b =>
                {
                    b.Property<int>("idPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apeMaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apePaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("celular")
                        .HasColumnType("int");

                    b.Property<string>("centroEduca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicionRuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dniPersona")
                        .HasColumnType("int");

                    b.Property<string>("domiFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoRuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("idEstCivil")
                        .HasColumnType("int");

                    b.Property<int>("idEtnico")
                        .HasColumnType("int");

                    b.Property<int>("idFactorrh")
                        .HasColumnType("int");

                    b.Property<int>("idGrdInstruc")
                        .HasColumnType("int");

                    b.Property<int?>("idMedico")
                        .HasColumnType("int");

                    b.Property<int>("idOcupacion")
                        .HasColumnType("int");

                    b.Property<int>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int>("idParentesco")
                        .HasColumnType("int");

                    b.Property<int>("idReligion")
                        .HasColumnType("int");

                    b.Property<int>("idSexo")
                        .HasColumnType("int");

                    b.Property<int>("idUbigeoNace")
                        .HasColumnType("int");

                    b.Property<int>("idUbigeoResi")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<int>("idciaSeguro")
                        .HasColumnType("int");

                    b.Property<int>("iddatoReniec")
                        .HasColumnType("int");

                    b.Property<int>("iddatoSiteds")
                        .HasColumnType("int");

                    b.Property<int>("iddatoSunat")
                        .HasColumnType("int");

                    b.Property<int>("idemprConvenio")
                        .HasColumnType("int");

                    b.Property<int>("idgpoSangre")
                        .HasColumnType("int");

                    b.Property<int>("idtipoIafa")
                        .HasColumnType("int");

                    b.Property<int>("idtipoVia")
                        .HasColumnType("int");

                    b.Property<int>("idtpDocumento")
                        .HasColumnType("int");

                    b.Property<int>("interior")
                        .HasColumnType("int");

                    b.Property<int>("manzana")
                        .HasColumnType("int");

                    b.Property<string>("nombreVia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nroBlock")
                        .HasColumnType("int");

                    b.Property<int>("nroDpto")
                        .HasColumnType("int");

                    b.Property<int>("nroEtapa")
                        .HasColumnType("int");

                    b.Property<int>("nroKm")
                        .HasColumnType("int");

                    b.Property<int>("nroLote")
                        .HasColumnType("int");

                    b.Property<int>("nroRuc")
                        .HasColumnType("int");

                    b.Property<int>("nroVia")
                        .HasColumnType("int");

                    b.Property<string>("razonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefono")
                        .HasColumnType("int");

                    b.HasKey("idPersona");

                    b.ToTable("Persona");
                });
#pragma warning restore 612, 618
        }
    }
}
