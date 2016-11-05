﻿using DAL;
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
    }
}
