using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormDirector : Form
    {
        List<Director> list = new List<Director>();
        public FormDirector()
        {
            InitializeComponent();
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            list = NDirector.Get();
            if(list.Count > 0) {
                directorBindingSource.DataSource = list;
                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selected = (Director)directorBindingSource.Current;
                if (selected != null)
                {
                    if(selected.id != 0)
                    {
                        textBox1.Text = selected.nombre.ToString();
                        textBox2.Text = selected.apellido.ToString();
                        label3.Text = $"ID: {selected.id.ToString()}";
                    }
                    else { textBox1.Text = string.Empty; label3.Text = string.Empty; textBox2.Text = string.Empty; }
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NDirector.Insert(textBox1.Text, textBox2.Text);
            cargarGrilla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
