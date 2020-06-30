﻿// <auto-generated />
using System;
using HistClinica.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HistClinica.Migrations
{
    [DbContext(typeof(ClinicaServiceContext))]
    partial class ClinicaServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HistClinica.Models.D001_USUARIO", b =>
                {
                    b.Property<int?>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("loginUser")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("claveUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaBaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaCrea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaMod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuCrea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuMod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEmpleado", "loginUser");

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

            modelBuilder.Entity("HistClinica.Models.D00_TBDETALLE", b =>
                {
                    b.Property<int>("idDet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("abrev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coddetTab")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechabaja")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechabaja")
                        .HasColumnType("datetime2");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuCreate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTab");

                    b.ToTable("D00_TBGENERAL");
                });

            modelBuilder.Entity("HistClinica.Models.D012_CRONOMEDICO", b =>
                {
                    b.Property<int>("idProgramMedica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaBaja")
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

                    b.Property<string>("fechaBaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idCita")
                        .HasColumnType("int");

                    b.Property<int?>("idFormaPago")
                        .HasColumnType("int");

                    b.Property<double?>("monto")
                        .HasColumnType("float");

                    b.HasKey("idPago");

                    b.ToTable("D015_PAGO");
                });

            modelBuilder.Entity("HistClinica.Models.D024_CAJA", b =>
                {
                    b.Property<int>("idCaja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("divisa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modopago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("montoAper")
                        .HasColumnType("float");

                    b.Property<double?>("montoCierre")
                        .HasColumnType("float");

                    b.Property<string>("motivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nroCaja")
                        .HasColumnType("int");

                    b.Property<bool?>("pos")
                        .HasColumnType("bit");

                    b.Property<string>("proveedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("turno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCaja");

                    b.ToTable("D024_CAJA");
                });

            modelBuilder.Entity("HistClinica.Models.D025_ASIGNACAJA", b =>
                {
                    b.Property<int?>("idCaja")
                        .HasColumnType("int");

                    b.Property<int?>("idEmpleado")
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

                    b.Property<string>("fecNace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechabaja")
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

                    b.Property<string>("nombres")
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

                    b.Property<string>("razonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tpPersona")
                        .HasColumnType("int");

                    b.HasKey("idPersona");

                    b.ToTable("T000_PERSONA");
                });

            modelBuilder.Entity("HistClinica.Models.T001_PACIENTE", b =>
                {
                    b.Property<int>("idPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("beneficio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cobertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codAsegurado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("codCobertura")
                        .HasColumnType("int");

                    b.Property<string>("codPaConvenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codPacSoat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codPaciente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("codTitular")
                        .HasColumnType("int");

                    b.Property<string>("codpacExterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("concienteDato")
                        .HasColumnType("bit");

                    b.Property<string>("convenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("copagoFijo")
                        .HasColumnType("int");

                    b.Property<int?>("copagoVariable")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("descuento")
                        .HasColumnType("float");

                    b.Property<int?>("dniAcom")
                        .HasColumnType("int");

                    b.Property<int?>("dniContratante")
                        .HasColumnType("int");

                    b.Property<string>("dsPacConv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dsPacSoat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dspacExter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("edadAcom")
                        .HasColumnType("int");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int?>("estadoSeguro")
                        .HasColumnType("int");

                    b.Property<string>("fecAfiliacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechabaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("finCarencia")
                        .HasColumnType("int");

                    b.Property<DateTime?>("finVigencia")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("hojafiliacion")
                        .HasColumnType("bit");

                    b.Property<int?>("idFactorrh")
                        .HasColumnType("int");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<int?>("idgpoSangre")
                        .HasColumnType("int");

                    b.Property<DateTime?>("iniVigencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("moneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomAsegurado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomContratante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreAcom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nroPlanSalud")
                        .HasColumnType("int");

                    b.Property<string>("nrohc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ordenAtenMed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("parentesco")
                        .HasColumnType("int");

                    b.Property<string>("planSalud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poliza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("restriccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stapacexter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statPacSoat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statPaconv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tpAfiliacion")
                        .HasColumnType("int");

                    b.Property<int?>("tpDocumento")
                        .HasColumnType("int");

                    b.Property<int>("tpPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("tpPlanSalud")
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

                    b.Property<int?>("estado")
                        .HasColumnType("int");

                    b.Property<string>("estadoReprogram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaCita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechabaja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idConsultorio")
                        .HasColumnType("int");

                    b.Property<int?>("idEmpleado")
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

                    b.Property<string>("nroHC")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int?>("estado")
                        .HasColumnType("int");

                    b.Property<DateTime?>("fecIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("fechabaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("genero")
                        .HasColumnType("int");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<int?>("idtpEmpleado")
                        .HasColumnType("int");

                    b.Property<int?>("salario")
                        .HasColumnType("int");

                    b.HasKey("idEmpleado");

                    b.ToTable("T120_EMPLEADO");
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

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("fechabaja")
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
#pragma warning restore 612, 618
        }
    }
}
