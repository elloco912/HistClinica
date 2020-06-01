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
    }
}
