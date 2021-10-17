using loganta.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loganta.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<AreaUsuaria> AreaUsuariasT { get; set; }
        public DbSet<CuadroDeNecesidades> CuadroDeNecesidadesT { get; set; }
        public DbSet<Presupuesto> PresupuestosT { get; set; }
        public DbSet<Proyecto> ProyectosT { get; set; }
        public DbSet<Requerimiento> RequerimientosT { get; set; }
        public DbSet<Usuario> UsuariosT { get; set; }
    }
}
