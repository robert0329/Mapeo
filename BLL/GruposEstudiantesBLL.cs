using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class GruposEstudiantesBLL
    {
        public static List<GruposEstudiantes> GetLis(int grupoId)
        {
            var lista = new List<GruposEstudiantes>();
            using (var conexion = new DetallesMapeoDB())
            {
                try
                {
                    lista = conexion.GruposEstudiante.Where(ge => ge.GrupoId == grupoId).ToList();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return lista;
        }
        public static  bool Insertar(List<GruposEstudiantes>Nuevo)
        {
            bool Retorno = false;

            using (var Conn = new DetallesMapeoDB())
            {
                try
                {
                    foreach(var Estudiante in Nuevo)
                    {
                        Conn.GruposEstudiante.Add(Estudiante);
                    }
                    Conn.SaveChanges();

                    Retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Retorno;
        }
        public static List<GruposEstudiantes> GetLisE(int EstId)
        {
            var lista = new List<GruposEstudiantes>();

            using (var conexion = new DetallesMapeoDB())
            {
                try
                {
                    lista = conexion.GruposEstudiante.Where(ge => ge.EstudianteId == EstId).ToList();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return lista;
        }
    }
}
