using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DetallesMapeo;

namespace DetallesMapeo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void registrarEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetallesMapeo.UI.RegistroEstudiantes re = new UI.RegistroEstudiantes();
            re.Show();
        }

        private void registrarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetallesMapeo.UI.RegistroGrupos rg = new UI.RegistroGrupos();
            rg.Show();
        }
    }
}
