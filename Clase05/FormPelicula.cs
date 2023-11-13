using Modelos;
using Negocio;

namespace Clase05
{
    public partial class FormPelicula : Form
    {
        List<Pelicula> materiaList = new List<Pelicula>();
        public FormPelicula()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materiaList = NPelicula.Get();
            materiaBindingSource.DataSource = materiaList;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (materiaList.Count > 0)
                {
                    Pelicula materiaSelected = (Pelicula)materiaBindingSource.Current;
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
                materiaList = NPelicula.Get();
                materiaBindingSource.DataSource = materiaList;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            materiaList = NPelicula.Get();
            materiaBindingSource.DataSource = materiaList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(label1.Text);
            string descripcion = textBox1.Text;
            
            materiaList = NPelicula.Get();
            materiaBindingSource.DataSource = materiaList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}