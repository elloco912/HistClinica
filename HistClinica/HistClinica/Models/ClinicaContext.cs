using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HistClinica.Clases;

namespace HistClinica.Models
{
    public partial class ClinicaContext : DbContext
    {
        public ClinicaContext()
        {
        }

        public ClinicaContext(DbContextOptions<ClinicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<D001Usuario> D001Usuario { get; set; }
        public virtual DbSet<D002Perfil> D002Perfil { get; set; }
        public virtual DbSet<D008Consultorio> D008Consultorio { get; set; }
        public virtual DbSet<D00Tbdetalle> D00Tbdetalle { get; set; }
        public virtual DbSet<D00Tbgeneral> D00Tbgeneral { get; set; }
        public virtual DbSet<D010Pacacompana> D010Pacacompana { get; set; }
        public virtual DbSet<D012Cronomedico> D012Cronomedico { get; set; }
        public virtual DbSet<D015Tpempleado> D015Tpempleado { get; set; }
        public virtual DbSet<DetalleCls> DetalleCls { get; set; }
        public virtual DbSet<T000Persona> T000Persona { get; set; }
        public virtual DbSet<T001Pacasegurado> T001Pacasegurado { get; set; }
        public virtual DbSet<T001Pacconvenio> T001Pacconvenio { get; set; }
        public virtual DbSet<T001Paciente> T001Paciente { get; set; }
        public virtual DbSet<T068Cita> T068Cita { get; set; }
        public virtual DbSet<T109Estadocita> T109Estadocita { get; set; }
        public virtual DbSet<T120Empleado> T120Empleado { get; set; }
        public virtual DbSet<T120Especialidad> T120Especialidad { get; set; }
        public virtual DbSet<T212Medico> T212Medico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=LAPTOP-INN02A85\\SQLEXPRESS;database=Clinica;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<D001Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("D001_USUARIO");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.ClaveUser).HasColumnName("claveUser");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(1);

                entity.Property(e => e.FechaMod).HasColumnName("fechaMod");

                entity.Property(e => e.FechaRegistra).HasColumnName("fechaRegistra");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.LoginUser).HasColumnName("loginUser");

                entity.Property(e => e.UsuMod).HasColumnName("usuMod");

                entity.Property(e => e.UsuRegistra).HasColumnName("usuRegistra");
            });

            modelBuilder.Entity<D002Perfil>(entity =>
            {
                entity.HasKey(e => e.IdPerfil);

                entity.ToTable("D002_PERFIL");

                entity.Property(e => e.IdPerfil).HasColumnName("idPerfil");

                entity.Property(e => e.CodPerfil).HasColumnName("codPerfil");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NombrePerfil).HasColumnName("nombrePerfil");
            });

            modelBuilder.Entity<D008Consultorio>(entity =>
            {
                entity.HasKey(e => e.IdConsultorio);

                entity.ToTable("D008_CONSULTORIO");

                entity.Property(e => e.IdConsultorio).HasColumnName("idConsultorio");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");

                entity.Property(e => e.NroConsultorio).HasColumnName("nroConsultorio");

                entity.Property(e => e.Piso).HasColumnName("piso");

                entity.Property(e => e.TpConsultorio).HasColumnName("tpConsultorio");
            });

            modelBuilder.Entity<D00Tbdetalle>(entity =>
            {
                entity.HasKey(e => e.IdDet);

                entity.ToTable("D00_TBDETALLE");

                entity.Property(e => e.IdDet).HasColumnName("idDet");

                entity.Property(e => e.Abrev).HasColumnName("abrev");

                entity.Property(e => e.CoddetTab).HasColumnName("coddetTab");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fuente).HasColumnName("fuente");

                entity.Property(e => e.IdTab).HasColumnName("idTab");
            });

            modelBuilder.Entity<D00Tbgeneral>(entity =>
            {
                entity.HasKey(e => e.IdTab);

                entity.ToTable("D00_TBGENERAL");

                entity.Property(e => e.IdTab).HasColumnName("idTab");

                entity.Property(e => e.CodTab).HasColumnName("codTab");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaCreate).HasColumnName("fechaCreate");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.UsuCreate).HasColumnName("usuCreate");
            });

            modelBuilder.Entity<D010Pacacompana>(entity =>
            {
                entity.HasKey(e => e.IdPacAcom);

                entity.ToTable("D010_PACACOMPANA");

                entity.Property(e => e.IdPacAcom).HasColumnName("idPacAcom");

                entity.Property(e => e.ApeMatAcom).HasColumnName("apeMatAcom");

                entity.Property(e => e.ApePatAcom).HasColumnName("apePatAcom");

                entity.Property(e => e.DniAcom).HasColumnName("dniAcom");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.NombresAcom).HasColumnName("nombresAcom");

                entity.Property(e => e.Parentesco).HasColumnName("parentesco");

                entity.Property(e => e.TpDocumento).HasColumnName("tpDocumento");
            });

            modelBuilder.Entity<D012Cronomedico>(entity =>
            {
                entity.HasKey(e => e.IdProgramMedica);

                entity.ToTable("D012_CRONOMEDICO");

                entity.Property(e => e.IdProgramMedica).HasColumnName("idProgramMedica");

                entity.Property(e => e.Dia).HasColumnName("dia");

                entity.Property(e => e.FecProgramMedica).HasColumnName("fecProgramMedica");

                entity.Property(e => e.HrFin).HasColumnName("hrFin");

                entity.Property(e => e.HrInicio).HasColumnName("hrInicio");

                entity.Property(e => e.IdConsultorio).HasColumnName("idConsultorio");

                entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Semana).HasColumnName("semana");
            });

            modelBuilder.Entity<D015Tpempleado>(entity =>
            {
                entity.HasKey(e => e.IdtpEmpleado);

                entity.ToTable("D015_TPEMPLEADO");

                entity.Property(e => e.IdtpEmpleado).HasColumnName("idtpEmpleado");
            });

            modelBuilder.Entity<DetalleCls>(entity =>
            {
                entity.HasKey(e => e.IdDet);

                entity.ToTable("DetalleCLS");

                entity.Property(e => e.IdDet).HasColumnName("idDet");

                entity.Property(e => e.CoddetTab)
                    .IsRequired()
                    .HasColumnName("coddetTab");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.DescripcionGeneral)
                    .IsRequired()
                    .HasColumnName("descripcionGeneral");
            });

            modelBuilder.Entity<T000Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.ToTable("T000_PERSONA");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.ApeMaterno).HasColumnName("apeMaterno");

                entity.Property(e => e.ApePaterno).HasColumnName("apePaterno");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.CentroEduca).HasColumnName("centroEduca");

                entity.Property(e => e.CondicionRuc).HasColumnName("condicionRuc");

                entity.Property(e => e.Correo).HasColumnName("correo");

                entity.Property(e => e.DniPersona).HasColumnName("dniPersona");

                entity.Property(e => e.DomiFiscal).HasColumnName("domiFiscal");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.EstadoRuc).HasColumnName("estadoRuc");

                entity.Property(e => e.FecNacimiento).HasColumnName("fecNacimiento");

                entity.Property(e => e.Fotografia).HasColumnName("fotografia");

                entity.Property(e => e.IdEstCivil).HasColumnName("idEstCivil");

                entity.Property(e => e.IdEtnico).HasColumnName("idEtnico");

                entity.Property(e => e.IdFactorrh).HasColumnName("idFactorrh");

                entity.Property(e => e.IdGrdInstruc).HasColumnName("idGrdInstruc");

                entity.Property(e => e.IdOcupacion).HasColumnName("idOcupacion");

                entity.Property(e => e.IdParentesco).HasColumnName("idParentesco");

                entity.Property(e => e.IdReligion).HasColumnName("idReligion");

                entity.Property(e => e.IdSexo).HasColumnName("idSexo");

                entity.Property(e => e.IdUbigeoNace).HasColumnName("idUbigeoNace");

                entity.Property(e => e.IdUbigeoResi).HasColumnName("idUbigeoResi");

                entity.Property(e => e.IdciaSeguro).HasColumnName("idciaSeguro");

                entity.Property(e => e.IddatoSiteds).HasColumnName("iddatoSiteds");

                entity.Property(e => e.IdemprConvenio).HasColumnName("idemprConvenio");

                entity.Property(e => e.IdgpoSangre).HasColumnName("idgpoSangre");

                entity.Property(e => e.IdtipoIafa).HasColumnName("idtipoIafa");

                entity.Property(e => e.IdtipoVia).HasColumnName("idtipoVia");

                entity.Property(e => e.IdtpDocumento).HasColumnName("idtpDocumento");

                entity.Property(e => e.Interior).HasColumnName("interior");

                entity.Property(e => e.Manzana).HasColumnName("manzana");

                entity.Property(e => e.NombreVia).HasColumnName("nombreVia");

                entity.Property(e => e.Nombres).HasColumnName("nombres");

                entity.Property(e => e.NroBlock).HasColumnName("nroBlock");

                entity.Property(e => e.NroDpto).HasColumnName("nroDpto");

                entity.Property(e => e.NroEtapa).HasColumnName("nroEtapa");

                entity.Property(e => e.NroKm).HasColumnName("nroKm");

                entity.Property(e => e.NroLote).HasColumnName("nroLote");

                entity.Property(e => e.NroRuc).HasColumnName("nroRuc");

                entity.Property(e => e.NroVia).HasColumnName("nroVia");

                entity.Property(e => e.RazonSocial).HasColumnName("razonSocial");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.Property(e => e.TpPersona).HasColumnName("tpPersona");
            });

            modelBuilder.Entity<T001Pacasegurado>(entity =>
            {
                entity.HasKey(e => e.IdAsegurado);

                entity.ToTable("T001_PACASEGURADO");

                entity.Property(e => e.IdAsegurado).HasColumnName("idAsegurado");

                entity.Property(e => e.Beneficio).HasColumnName("beneficio");

                entity.Property(e => e.Cobertura).HasColumnName("cobertura");

                entity.Property(e => e.CodAsegurado).HasColumnName("codAsegurado");

                entity.Property(e => e.CodCobertura).HasColumnName("codCobertura");

                entity.Property(e => e.CodTitular).HasColumnName("codTitular");

                entity.Property(e => e.Convenio).HasColumnName("convenio");

                entity.Property(e => e.CopagoFijo).HasColumnName("copagoFijo");

                entity.Property(e => e.CopagoVariable).HasColumnName("copagoVariable");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.DniContratante).HasColumnName("dniContratante");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.EstadoSeguro).HasColumnName("estadoSeguro");

                entity.Property(e => e.FecAfiliacion).HasColumnName("fecAfiliacion");

                entity.Property(e => e.FinCarencia).HasColumnName("finCarencia");

                entity.Property(e => e.FinVigencia).HasColumnName("finVigencia");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.IdParentesco).HasColumnName("idParentesco");

                entity.Property(e => e.IdtpDocumento).HasColumnName("idtpDocumento");

                entity.Property(e => e.IniVigencia).HasColumnName("iniVigencia");

                entity.Property(e => e.Moneda).HasColumnName("moneda");

                entity.Property(e => e.NomAseguradora).HasColumnName("nomAseguradora");

                entity.Property(e => e.NomContratante).HasColumnName("nomContratante");

                entity.Property(e => e.NroplanSalud).HasColumnName("nroplanSalud");

                entity.Property(e => e.OrdenAtenMed).HasColumnName("ordenAtenMed");

                entity.Property(e => e.PlanSalud).HasColumnName("planSalud");

                entity.Property(e => e.Poliza).HasColumnName("poliza");

                entity.Property(e => e.Restriccion).HasColumnName("restriccion");

                entity.Property(e => e.TpAfiliacion).HasColumnName("tpAfiliacion");

                entity.Property(e => e.TpPlanSalud).HasColumnName("tpPlanSalud");
            });

            modelBuilder.Entity<T001Pacconvenio>(entity =>
            {
                entity.HasKey(e => e.IdPacConvenio);

                entity.ToTable("T001_PACCONVENIO");

                entity.Property(e => e.IdPacConvenio).HasColumnName("idPacConvenio");

                entity.Property(e => e.Beneficio).HasColumnName("beneficio");

                entity.Property(e => e.Cobertura).HasColumnName("cobertura");

                entity.Property(e => e.CodTitular).HasColumnName("codTitular");

                entity.Property(e => e.CopagoFijo).HasColumnName("copagoFijo");

                entity.Property(e => e.CopagoVariable).HasColumnName("copagoVariable");

                entity.Property(e => e.DniContratante).HasColumnName("dniContratante");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.EstadoConvenio).HasColumnName("estadoConvenio");

                entity.Property(e => e.FecAfiliacion).HasColumnName("fecAfiliacion");

                entity.Property(e => e.FinVigencia).HasColumnName("finVigencia");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.IdParentesco).HasColumnName("idParentesco");

                entity.Property(e => e.IdtpDocumento).HasColumnName("idtpDocumento");

                entity.Property(e => e.IniVigencia).HasColumnName("iniVigencia");

                entity.Property(e => e.Moneda).HasColumnName("moneda");

                entity.Property(e => e.NomContratante).HasColumnName("nomContratante");

                entity.Property(e => e.OrdAtenMedica).HasColumnName("ordAtenMedica");

                entity.Property(e => e.Restriccion).HasColumnName("restriccion");

                entity.Property(e => e.TpAfiliacion).HasColumnName("tpAfiliacion");
            });

            modelBuilder.Entity<T001Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente);

                entity.ToTable("T001_PACIENTE");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.CodPaciente).HasColumnName("codPaciente");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.DniAcom).HasColumnName("dniAcom");

                entity.Property(e => e.EdadAcom).HasColumnName("edadAcom");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdAsegurado).HasColumnName("idAsegurado");

                entity.Property(e => e.IdFactorrh).HasColumnName("idFactorrh");

                entity.Property(e => e.IdPacConvenio).HasColumnName("idPacConvenio");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdgpoSangre).HasColumnName("idgpoSangre");

                entity.Property(e => e.IdtpPaciente).HasColumnName("idtpPaciente");

                entity.Property(e => e.NombreAcom).HasColumnName("nombreAcom");

                entity.Property(e => e.Nrohc).HasColumnName("nrohc");
            });

            modelBuilder.Entity<T068Cita>(entity =>
            {
                entity.HasKey(e => e.IdCita);

                entity.ToTable("T068_CITA");

                entity.Property(e => e.IdCita).HasColumnName("idCita");

                entity.Property(e => e.Coa).HasColumnName("coa");

                entity.Property(e => e.CodCita).HasColumnName("codCita");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Ejecutado).HasColumnName("ejecutado");

                entity.Property(e => e.EstadoReprogram).HasColumnName("estadoReprogram");

                entity.Property(e => e.FechaCita).HasColumnName("fechaCita");

                entity.Property(e => e.IdConsultorio).HasColumnName("idConsultorio");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdEstAtencion).HasColumnName("idEstAtencion");

                entity.Property(e => e.IdEstaGralPac).HasColumnName("idEstaGralPac");

                entity.Property(e => e.IdEstadoCita).HasColumnName("idEstadoCita");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.IdProgramMedica).HasColumnName("idProgramMedica");

                entity.Property(e => e.IdTpAtencion).HasColumnName("idTpAtencion");

                entity.Property(e => e.Igv).HasColumnName("igv");

                entity.Property(e => e.NroCita).HasColumnName("nroCita");

                entity.Property(e => e.NroHc).HasColumnName("nroHC");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Prioridad).HasColumnName("prioridad");

                entity.Property(e => e.Servicio).HasColumnName("servicio");

                entity.Property(e => e.TpAtencion).HasColumnName("tpAtencion");

                entity.Property(e => e.UltCie10).HasColumnName("ultCie10");
            });

            modelBuilder.Entity<T109Estadocita>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCita);

                entity.ToTable("T109_ESTADOCITA");

                entity.Property(e => e.IdEstadoCita).HasColumnName("idEstadoCita");

                entity.Property(e => e.CodEstadoCita).HasColumnName("codEstadoCita");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Origen).HasColumnName("origen");
            });

            modelBuilder.Entity<T120Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.ToTable("T120_EMPLEADO");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.Cargo).HasColumnName("cargo");

                entity.Property(e => e.CodEmpleado).HasColumnName("codEmpleado");

                entity.Property(e => e.DescArea).HasColumnName("descArea");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FecIngreso).HasColumnName("fecIngreso");

                entity.Property(e => e.Genero).HasColumnName("genero");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdtpEmpleado).HasColumnName("idtpEmpleado");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Salario).HasColumnName("salario");
            });

            modelBuilder.Entity<T120Especialidad>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidad);

                entity.ToTable("T120_ESPECIALIDAD");

                entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");

                entity.Property(e => e.CodEspecial).HasColumnName("codEspecial");

                entity.Property(e => e.CodSigesa).HasColumnName("codSigesa");

                entity.Property(e => e.CodSubEspecial).HasColumnName("codSubEspecial");

                entity.Property(e => e.DescSubEspecial).HasColumnName("descSubEspecial");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            });

            modelBuilder.Entity<T212Medico>(entity =>
            {
                entity.HasKey(e => e.IdMedico);

                entity.ToTable("T212_MEDICO");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.CodMedico).HasColumnName("codMedico");

                entity.Property(e => e.Condicion).HasColumnName("condicion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdtpDocumento).HasColumnName("idtpDocumento");

                entity.Property(e => e.NroColegio).HasColumnName("nroColegio");

                entity.Property(e => e.NroRne).HasColumnName("nroRne");

                entity.Property(e => e.NroRuc).HasColumnName("nroRuc");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<HistClinica.Clases.Detalle> Detalle { get; set; }
    }
}
