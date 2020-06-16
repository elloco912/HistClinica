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
    [Migration("20200616160935_nuevamigracion")]
    partial class nuevamigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HistClinica.Models.D001_USUARIO", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("claveUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaMod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaRegistra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("loginUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuMod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuRegistra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("D001_USUARIO");
                });

            modelBuilder.Entity("HistClinica.Models.D002_PERFIL", b =>
                {
                    b.Property<int>("idPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<string>("nombrePerfil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPerfil");

                    b.ToTable("D002_PERFIL");
                });

            modelBuilder.Entity("HistClinica.Models.D008_CONSULTORIO", b =>
                {
                    b.Property<int>("idConsultorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEspecialidad")
                        .HasColumnType("int");

                    b.Property<int?>("nroConsultorio")
                        .HasColumnType("int");

                    b.Property<string>("piso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tpConsultorio")
                        .HasColumnType("int");

                    b.HasKey("idConsultorio");

                    b.ToTable("D008_CONSULTORIO");
                });

            modelBuilder.Entity("HistClinica.Models.D00_TBDETALLE", b =>
                {
                    b.Property<int>("idDet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("abrev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coddetTab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fuente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idTab")
                        .HasColumnType("int");

                    b.HasKey("idDet");

                    b.ToTable("D00_TBDETALLE");
                });

            modelBuilder.Entity("HistClinica.Models.D00_TBGENERAL", b =>
                {
                    b.Property<int>("idTab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codTab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuCreate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTab");

                    b.ToTable("D00_TBGENERAL");
                });

            modelBuilder.Entity("HistClinica.Models.D010_PACACOMPANA", b =>
                {
                    b.Property<int>("idPacAcom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apeMatAcom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apePatAcom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dniAcom")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<string>("nombresAcom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tpDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPacAcom");

                    b.ToTable("D010_PACACOMPANA");
                });

            modelBuilder.Entity("HistClinica.Models.D012_CRONOMEDICO", b =>
                {
                    b.Property<int>("idProgramMedica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaIni")
                        .HasColumnType("datetime2");

                    b.Property<string>("hrFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hrInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idConsultorio")
                        .HasColumnType("int");

                    b.Property<int?>("idEspecialidad")
                        .HasColumnType("int");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int?>("idMedico")
                        .HasColumnType("int");

                    b.Property<string>("mes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("semana")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProgramMedica");

                    b.ToTable("D012_CRONOMEDICO");
                });

            modelBuilder.Entity("HistClinica.Models.D015_PAGO", b =>
                {
                    b.Property<int>("idPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codTransacRetorno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codTransaccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fecOkPasarela")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fecRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idCita")
                        .HasColumnType("int");

                    b.Property<int?>("idFormaPago")
                        .HasColumnType("int");

                    b.Property<double?>("monto")
                        .HasColumnType("float");

                    b.HasKey("idPago");

                    b.ToTable("D015_PAGO");
                });

            modelBuilder.Entity("HistClinica.Models.D015_TPEMPLEADO", b =>
                {
                    b.Property<int>("idtpEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idtpEmpleado");

                    b.ToTable("D015_TPEMPLEADO");
                });

            modelBuilder.Entity("HistClinica.Models.D024_CAJA", b =>
                {
                    b.Property<int>("idCaja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nroCaja")
                        .HasColumnType("int");

                    b.HasKey("idCaja");

                    b.ToTable("D024_CAJA");
                });

            modelBuilder.Entity("HistClinica.Models.D025_ASIGNACAJA", b =>
                {
                    b.Property<int>("idCaja")
                        .HasColumnType("int");

                    b.Property<int>("idEmpleado")
                        .HasColumnType("int");

                    b.HasKey("idCaja", "idEmpleado");

                    b.ToTable("D025_ASIGNACAJA");
                });

            modelBuilder.Entity("HistClinica.Models.T000_PERSONA", b =>
                {
                    b.Property<int>("idPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apeMaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apePaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("centroEduca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicionRuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dniPersona")
                        .HasColumnType("int");

                    b.Property<string>("domiFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("edad")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoRuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEstCivil")
                        .HasColumnType("int");

                    b.Property<int?>("idEtnico")
                        .HasColumnType("int");

                    b.Property<int?>("idFactorrh")
                        .HasColumnType("int");

                    b.Property<int?>("idGrdInstruc")
                        .HasColumnType("int");

                    b.Property<int?>("idOcupacion")
                        .HasColumnType("int");

                    b.Property<int?>("idParentesco")
                        .HasColumnType("int");

                    b.Property<int?>("idReligion")
                        .HasColumnType("int");

                    b.Property<int?>("idSexo")
                        .HasColumnType("int");

                    b.Property<int?>("idUbigeoNace")
                        .HasColumnType("int");

                    b.Property<int?>("idUbigeoResi")
                        .HasColumnType("int");

                    b.Property<int?>("idciaSeguro")
                        .HasColumnType("int");

                    b.Property<int?>("iddatoSiteds")
                        .HasColumnType("int");

                    b.Property<int?>("idemprConvenio")
                        .HasColumnType("int");

                    b.Property<int?>("idgpoSangre")
                        .HasColumnType("int");

                    b.Property<int?>("idtipoIafa")
                        .HasColumnType("int");

                    b.Property<int?>("idtipoVia")
                        .HasColumnType("int");

                    b.Property<int?>("idtpDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("interior")
                        .HasColumnType("int");

                    b.Property<int?>("manzana")
                        .HasColumnType("int");

                    b.Property<string>("nombreVia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nroBlock")
                        .HasColumnType("int");

                    b.Property<int?>("nroDpto")
                        .HasColumnType("int");

                    b.Property<int?>("nroEtapa")
                        .HasColumnType("int");

                    b.Property<int?>("nroKm")
                        .HasColumnType("int");

                    b.Property<int?>("nroLote")
                        .HasColumnType("int");

                    b.Property<int?>("nroRuc")
                        .HasColumnType("int");

                    b.Property<int?>("nroVia")
                        .HasColumnType("int");

                    b.Property<string>("primerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("razonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tpPersona")
                        .HasColumnType("int");

                    b.HasKey("idPersona");

                    b.ToTable("T000_PERSONA");
                });

            modelBuilder.Entity("HistClinica.Models.T001_PACASEGURADO", b =>
                {
                    b.Property<int>("idAsegurado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("beneficio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cobertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codAsegurado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codCobertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("codTitular")
                        .HasColumnType("int");

                    b.Property<string>("convenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("copagoFijo")
                        .HasColumnType("int");

                    b.Property<int?>("copagoVariable")
                        .HasColumnType("int");

                    b.Property<double?>("descuento")
                        .HasColumnType("float");

                    b.Property<int?>("dniContratante")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoSeguro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fecAfiliacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("finCarencia")
                        .HasColumnType("int");

                    b.Property<DateTime?>("finVigencia")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("idParentesco")
                        .HasColumnType("int");

                    b.Property<int?>("idtpDocumento")
                        .HasColumnType("int");

                    b.Property<DateTime?>("iniVigencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("moneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomAseguradora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomContratante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nroplanSalud")
                        .HasColumnType("int");

                    b.Property<string>("ordenAtenMed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("planSalud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poliza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("restriccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tpAfiliacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tpPlanSalud")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAsegurado");

                    b.ToTable("T001_PACASEGURADO");
                });

            modelBuilder.Entity("HistClinica.Models.T001_PACCONVENIO", b =>
                {
                    b.Property<int>("idPacConvenio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("beneficio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cobertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("codTitular")
                        .HasColumnType("int");

                    b.Property<int?>("copagoFijo")
                        .HasColumnType("int");

                    b.Property<int?>("copagoVariable")
                        .HasColumnType("int");

                    b.Property<int?>("dniContratante")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoConvenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fecAfiliacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("finVigencia")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("idParentesco")
                        .HasColumnType("int");

                    b.Property<int?>("idtpDocumento")
                        .HasColumnType("int");

                    b.Property<DateTime?>("iniVigencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("moneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomContratante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ordAtenMedica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("restriccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tpAfiliacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPacConvenio");

                    b.ToTable("T001_PACCONVENIO");
                });

            modelBuilder.Entity("HistClinica.Models.T001_PACIENTE", b =>
                {
                    b.Property<int>("idPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codPaciente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dniAcom")
                        .HasColumnType("int");

                    b.Property<int?>("edadAcom")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idAsegurado")
                        .HasColumnType("int");

                    b.Property<int?>("idFactorrh")
                        .HasColumnType("int");

                    b.Property<int?>("idPacConvenio")
                        .HasColumnType("int");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<int?>("idgpoSangre")
                        .HasColumnType("int");

                    b.Property<int?>("idtpPaciente")
                        .HasColumnType("int");

                    b.Property<string>("nombreAcom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nrohc")
                        .HasColumnType("int");

                    b.HasKey("idPaciente");

                    b.ToTable("T001_PACIENTE");
                });

            modelBuilder.Entity("HistClinica.Models.T068_CITA", b =>
                {
                    b.Property<int>("idCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("coa")
                        .HasColumnType("float");

                    b.Property<int?>("codCita")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("descuento")
                        .HasColumnType("float");

                    b.Property<string>("ejecutado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoReprogram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaCita")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idConsultorio")
                        .HasColumnType("int");

                    b.Property<int?>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<int?>("idEstaGralPac")
                        .HasColumnType("int");

                    b.Property<int?>("idEstadoCita")
                        .HasColumnType("int");

                    b.Property<int?>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("idProgramMedica")
                        .HasColumnType("int");

                    b.Property<int?>("idservicioCli")
                        .HasColumnType("int");

                    b.Property<double?>("igv")
                        .HasColumnType("float");

                    b.Property<string>("motivoAnula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("motivoRepro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nroCita")
                        .HasColumnType("int");

                    b.Property<int?>("nroHC")
                        .HasColumnType("int");

                    b.Property<double?>("precio")
                        .HasColumnType("float");

                    b.Property<string>("prioridad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tipoCita")
                        .HasColumnType("int");

                    b.Property<int?>("tpAtencion")
                        .HasColumnType("int");

                    b.Property<string>("ultCie10")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCita");

                    b.ToTable("T068_CITA");
                });

            modelBuilder.Entity("HistClinica.Models.T109_ESTADOCITA", b =>
                {
                    b.Property<int>("idEstadoCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codEstadoCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEstadoCita");

                    b.ToTable("T109_ESTADOCITA");
                });

            modelBuilder.Entity("HistClinica.Models.T120_EMPLEADO", b =>
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

                    b.Property<DateTime?>("fecIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<int?>("idtpEmpleado")
                        .HasColumnType("int");

                    b.Property<double?>("precio")
                        .HasColumnType("float");

                    b.Property<int?>("salario")
                        .HasColumnType("int");

                    b.HasKey("idEmpleado");

                    b.ToTable("T120_EMPLEADO");
                });

            modelBuilder.Entity("HistClinica.Models.T120_ESPECIALIDAD", b =>
                {
                    b.Property<int>("idEspecialidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codEspecial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codSigesa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codSubEspecial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descSubEspecial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEspecialidad");

                    b.ToTable("T120_ESPECIALIDAD");
                });

            modelBuilder.Entity("HistClinica.Models.T212_MEDICO", b =>
                {
                    b.Property<int>("idMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codMedico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<int?>("idEspecialidad")
                        .HasColumnType("int");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<int?>("idtpDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("nroColegio")
                        .HasColumnType("int");

                    b.Property<string>("nroRne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nroRuc")
                        .HasColumnType("int");

                    b.HasKey("idMedico");

                    b.ToTable("T212_MEDICO");
                });

            modelBuilder.Entity("HistClinica.Models.T218_SERVICIOSCLI", b =>
                {
                    b.Property<int>("idservicioCli")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idservicioCli");

                    b.ToTable("T218_SERVICIOSCLI");
                });
#pragma warning restore 612, 618
        }
    }
}
