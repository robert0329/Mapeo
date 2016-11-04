using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class DetallesMapeoDB : DbContext
    {
        public DetallesMapeoDB() : base("name=ConStr")
        {

        }
        public DbSet <Estudiantes>Estudiante { get; set; }
        public DbSet<Grupos>grupo { get; set; }
        public DbSet<GruposEstudiantes>GruposEstudiante { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .HasMany<Estudiantes>(g => g.Estudiante)
                .WithMany(e => e.Grupos)
                .Map(Ge =>
                {
                    Ge.MapLeftKey("GrupoId");
                    Ge.MapRightKey("EstudianteId");
                    Ge.ToTable("GruposEstudiantes");
                });
        }
    }
}
