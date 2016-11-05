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
using DAL;

namespace DetallesMapeo.UI
{
    public partial class RegistroGrupos : Form
    {
        List<GruposEstudiantes> ge;
        List<Estudiantes> Est;
        private Grupos grupo = new Grupos();
        public RegistroGrupos()
        {
            InitializeComponent();
            ge = new List<GruposEstudiantes>();
            Est = new List<Estudiantes>();
            ListarEstudiantes();
        }
        private void ListarEstudiantes()
        {
            DetallesMapeoDB conn = new DetallesMapeoDB();
            var lis = conn.Estudiante.ToList();
            if (lis.Count > 0)
            {
                EstudiantecomboBox.DataSource = lis;
                EstudiantecomboBox.ValueMember = "EstudianteId";
                EstudiantecomboBox.DisplayMember = "Nombres";
            }
        }
        private void CrearGrupobutton_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            EstudiantedataGridView.DataSource = null;
            int GId;
            int.TryParse(GrupoIdmaskedTextBox.Text, out GId);
            ge.Add((new GruposEstudiantes() { EstudianteId = (int) EstudiantecomboBox.SelectedValue, GrupoId = GId}));
            Est.Add(BLL.EstudiantesBLL.Buscar((int) EstudiantecomboBox.SelectedValue));
            EstudiantedataGridView.DataSource = Est;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            EstudiantedataGridView.DataSource = null;
            int Id;
            int.TryParse(GrupoIdmaskedTextBox.Text, out Id);
            var grup = BLL.GruposEstudiantesBLL.GetLis(Id);
            var Estu = BLL.EstudiantesBLL.GetList(grup);
            EstudiantedataGridView.DataSource = Estu;

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int Id;
            int.TryParse(GrupoIdmaskedTextBox.Text, out Id);
            BLL.GruposEstudiantesBLL.Insertar(ge);
            BLL.GruposBLL.Insertar(new Grupos(Id, NombreGtextBox.Text));
        }
    }
}
