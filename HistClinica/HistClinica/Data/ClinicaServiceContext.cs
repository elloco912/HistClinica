﻿using HistClinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace HistClinica.Data
{
    public class ClinicaServiceContext:DbContext
    {
        public ClinicaServiceContext()
        {
        }

        public ClinicaServiceContext(DbContextOptions<ClinicaServiceContext> options)
       : base(options)
        { }

        public DbSet<T000_PERSONA> T000_PERSONA { get; set; }
        public DbSet<T120_EMPLEADO> T120_EMPLEADO { get; set; }
        public DbSet<T001_PACIENTE> T001_PACIENTE { get; set; }
        public DbSet<D012_CRONOMEDICO> D012_CRONOMEDICO { get; set; }
        public DbSet<T212_MEDICO> T212_MEDICO { get; set; }
        public DbSet<T120_ESPECIALIDAD> T120_ESPECIALIDAD { get; set; }
        public DbSet<T068_CITA> T068_CITA { get; set; }
        public DbSet<T109_ESTADOCITA> T109_ESTADOCITA { get; set; }
        public DbSet<D008_CONSULTORIO> D008_CONSULTORIO { get; set; }
        public DbSet<D015_TPEMPLEADO> D015_TPEMPLEADO { get; set; }
        public DbSet<D001_USUARIO> D001_USUARIO { get; set; }
        public DbSet<D002_PERFIL> D002_PERFIL { get; set; }
        public DbSet<D00_TBGENERAL> D00_TBGENERAL { get; set; }
        public DbSet<D00_TBDETALLE> D00_TBDETALLE { get; set; }
        public DbSet<D010_PACACOMPANA> D010_PACACOMPANA { get; set; }
        public DbSet<T001_PACASEGURADO> T001_PACASEGURADO { get; set; }
        public DbSet<T001_PACCONVENIO> T001_PACCONVENIO { get; set; }
        public DbSet<D024_CAJA> D024_CAJA { get; set; }
        public DbSet<D025_ASIGNACAJA> D025_ASIGNACAJA { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<D025_ASIGNACAJA>()
                .HasKey(o => new { o.idCaja, o.idEmpleado });
        }
        public DbSet<D015_PAGO> D015_PAGO { get; set; }
        public DbSet<T218_SERVICIOSCLI> T218_SERVICIOSCLI { get; set; }

    }
}
