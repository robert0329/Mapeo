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
    public class GruposBLL
    {
        public static bool Insertar(Grupos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new DetallesMapeoDB())
            {
                try
                {
                    conexion.grupo.Add(Nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            return resultado;
        }
        public static Grupos Buscar(int GrupoId)
        {
            var grupo = new Grupos();
            using (var conexion = new DetallesMapeoDB())
            {
                try
                {
                    grupo = conexion.grupo.Find(GrupoId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return grupo;
        }
    }
}
