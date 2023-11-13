using Modelos;
using Negocio;

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
            list = NPelicula.Get();
            peliculaBindingSource.DataSource = list;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (list.Count > 0)
                {
                    Pelicula materiaSelected = (Pelicula)peliculaBindingSource.Current;
                    if (materiaSelected != null)
                    {

                    }
                    else { textBox1.Text = string.Empty; label1.Text = string.Empty; }

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


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox
                .Show("¿Desea borrar el elemento?",
                "Confirmacion",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                int id = int.Parse(label1.Text);
                NPelicula.Delete(id);
                list = NPelicula.Get();
                peliculaBindingSource.DataSource = list;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            list = NPelicula.Get();
            peliculaBindingSource.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(label1.Text);
            string descripcion = textBox2.Text;

            list = NPelicula.Get();
            peliculaBindingSource.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}