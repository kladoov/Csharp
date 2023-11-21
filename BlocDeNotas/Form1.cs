namespace BlocNotas
{
    public partial class Form1 : Form
    {
        private List<Nota> notas = new List<Nota>();
        public Form1()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            txtTitulo.Text = "";
            txtContenido.Text = "";
        }

        private void btnAnaidir_Click(object sender, EventArgs e)
        {
            String titulo = txtTitulo.Text;
            String contenido = txtContenido.Text;

            Nota nota = new Nota(titulo, contenido);
            notas.Add(nota);

            listNotas.Items.Add(nota.Titulo);
            limpiarCampos();
        }

        private void listNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            if (listNotas.SelectedIndex != -1)
            {
                Nota seleccionado = notas[listNotas.SelectedIndex];
                txtTitulo.Text += seleccionado.Titulo;
                txtContenido.Text += seleccionado.Cuerpo;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listNotas.SelectedIndex != -1)
            {
                Nota seleccionado = notas[listNotas.SelectedIndex];
                seleccionado.Titulo = txtTitulo.Text;
                seleccionado.Cuerpo = txtContenido.Text;
                MessageBox.Show("Has editado correctamente el texto.", "Exito", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Selecciona una nota para editar.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            //botón para borrar los campos
            txtTitulo.Text = "";
            txtContenido.Text = "";
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            if (listNotas.SelectedIndex != -1)
            {
                notas.RemoveAt(listNotas.SelectedIndex);
                listNotas.Items.RemoveAt(listNotas.SelectedIndex);
                limpiarCampos();
                MessageBox.Show("Se ha borrado la nota con exito.", "Exito", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Selecciona una nota para eliminar.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
