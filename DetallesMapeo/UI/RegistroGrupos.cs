using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace DetallesMapeo.UI
{
    public partial class RegistroGrupos : Form
    {
        public RegistroGrupos()
        {
            InitializeComponent();
        }

        private void CrearGrupobutton_Click(object sender, EventArgs e)
        {
            Grupos grupo = new Grupos();

            grupo.GrupoId = Convert.ToInt32(GrupoIdmaskedTextBox.Text);
            grupo.Nombres = NombreGtextBox.Text;

            if (GruposBLL.Insertar(grupo))
            {
                MessageBox.Show("Guardo");
            }
        }
    }
}
