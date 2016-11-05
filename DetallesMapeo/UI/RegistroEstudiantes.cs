using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace DetallesMapeo.UI
{
    public partial class RegistroEstudiantes : Form
    {
        public RegistroEstudiantes()
        {
            InitializeComponent();
        }
        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes Est = new Estudiantes();

            Est.EstudianteId = Convert.ToInt32(EstudianteIdmaskedTextBox.Text);
            Est.Nombres = NombreEsttextBox.Text;
            if(EstudiantesBLL.Insertar(Est))
            {
                MessageBox.Show("Guardo");
            }
            //EstudiantesBLL.Insertar(Est);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            EstudiantesdataGridView.DataSource = null;
            int Id;
            int.TryParse(EstudianteIdmaskedTextBox.Text , out Id);
            var Estudiante = BLL.EstudiantesBLL.Buscar(Id);

            if(Estudiante != null)
            {
                var ge = BLL.GruposEstudiantesBLL.GetLisE(Estudiante.EstudianteId);
                var Gr = BLL.GruposBLL.GetList(ge);
                NombreEsttextBox.Text = Estudiante.Nombres;
                EstudiantesdataGridView.Visible = true;
                EstudiantesdataGridView.DataSource = Gr;

            }else
            {
                MessageBox.Show("No encontre");
            }

        }

        private void RegistroEstudiantes_Load(object sender, EventArgs e)
        {
           
        }
    }
}
