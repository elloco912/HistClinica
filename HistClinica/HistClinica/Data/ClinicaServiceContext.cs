﻿using HistClinica.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HistClinica.Data
{
    public class ClinicaServiceContext:DbContext
    {
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
    }
}
