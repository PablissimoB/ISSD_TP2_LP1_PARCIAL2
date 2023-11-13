using Modelos;
using Negocio;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Clase05
{
    public partial class FormPelicula : Form
    {
        List<Pelicula> list = new List<Pelicula>();
        public FormPelicula()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cargarDirectores();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (list.Count > 0)
                {
                    Pelicula selected = (Pelicula)peliculaBindingSource.Current;
                    if (selected != null)
                    {
                        if (selected.id != 0)
                        {
                            
                        }

                    }
                    else { textBox2.Text = string.Empty; label1.Text = string.Empty; }

                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void cargarDirectores()
        {
            List<Director> directores = NDirector.Get();
            directorBindingSource.DataSource = directores;
        }

        private void cargarGrilla()
        {
            list = NPelicula.Get();
            if(list.Count> 0)
            {
                dataGridView1.Visible = true;
                peliculaBindingSource.DataSource = list;
            }
            else
            {
                dataGridView1.Visible = false;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox
                .Show("¿Desea borrar el elemento?",
                "Confirmacion",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                cargarGrilla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            cargarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cargarGrilla();
        }

    }
}