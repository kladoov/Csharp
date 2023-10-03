using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        private int i;
        public Form1()
        {
            InitializeComponent();
            i = 0;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void btnup_Click(object sender, EventArgs e)
        {
            this.personaje.Location = new Point(this.personaje.Location.X, this.personaje.Location.Y - 10);
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            this.personaje.Location = new Point(this.personaje.Location.X, this.personaje.Location.Y + 10);
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            this.personaje.Location = new Point(this.personaje.Location.X - 10, this.personaje.Location.Y);
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            this.personaje.Location = new Point(this.personaje.Location.X + 10, this.personaje.Location.Y);
        }

        private void btnDialogoConVariosBotones_Click(object sender, EventArgs e)
        {
            //mensaje en cuadro, con titulo y varios botones
            //almacena el resultado en una variable
            DialogResult resultado = MessageBox.Show("Mensaje", "TITULO", MessageBoxButtons.YesNoCancel);
            MessageBox.Show(resultado.ToString());
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnNuevaVentana_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new Form();
            //titulo de la nueva ventana
            nuevaVentana.Text = "NUEVA VENTANA";
            //el propietario en el que se encuentra el boton en este caso
            nuevaVentana.Owner = this;
            //.ShowDialog hacer ventanas modales / .Show ventanas NO modales
            nuevaVentana.ShowDialog();
        }

        private void guardarFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //guardar fichero
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void vistaPreviaImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void coloresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            MessageBox.Show(color.Color.ToString());
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            MessageBox.Show(fd.Font.ToString());
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
        }

        private void tabPage4_Click(object sender, EventArgs e) { }

        private void btnNuevo_Click(object sender, EventArgs e) { }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String numStr = txtNumero.Text.ToString();
            int num = int.Parse(numStr);

            int radio = 150;
            double angulo = 2 * Math.PI / num;

            this.tabPage4.Size = new Size(2 * radio + 68, 2 * radio + 90);

            for (int j = 0; j < num; j++)
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(0, 0, 200);
                btn.ForeColor = Color.Black;
                btn.Size = new Size(50, 50);
                btn.Location = new Point((int)(radio * Math.Sin(angulo * i) + radio), (int)(-radio * Math.Cos(angulo * i) + radio));

                i++;
                btn.Text = ((char)(i + 64)).ToString();
                this.tabPage4.Controls.Add(btn);
            }

        }
    }
}