using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public string Nombres { get; set; }
        public List<Estudiantes>Estudiante { get; set; }

        public Grupos()
        {
            this.Estudiante = new List<Estudiantes>();
        }
        public Grupos(int GrupoId , string nombreGrupos)
        {
            this.GrupoId = GrupoId;
            this.Nombres = nombreGrupos;
            this.Estudiante = new List<Estudiantes>();
        }
    }
}
