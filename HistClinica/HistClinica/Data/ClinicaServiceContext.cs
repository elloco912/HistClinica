using HistClinica.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HistClinica.Data
{
    public class ClinicaServiceContext:DbContext
    {
        public ClinicaServiceContext(DbContextOptions<ClinicaServiceContext> options)
       : base(options)
        { }

        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Cita> Cita { get; set; }
        public DbSet<CronoMedico> CronoMedico { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
    }
}
