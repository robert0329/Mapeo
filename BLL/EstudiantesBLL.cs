using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstudiantesBLL
    {
        public static bool Insertar(Estudiantes Est)
        {
            bool retorno = false;
            using (var Conn = new DetallesMapeoDB())
            {
                try
                {
                    Conn.Estudiante.Add(Est);
                    Conn.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }
        public static Estudiantes Buscar(int Id)
        {
            var Estudiante = new Estudiantes();
            using (var Conn = new DetallesMapeoDB())
            {
                try
                {
                    Conn.Estudiante.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Estudiante;
        }

        public static List<Estudiantes> GetList()
        {
            var Lista = new List<Estudiantes>();
            using (var Conn = new DetallesMapeoDB())
            {
                try
                {
                    Lista = Conn.Estudiante.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Lista;
        }
    }
}
