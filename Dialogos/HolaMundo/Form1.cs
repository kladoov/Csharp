namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensajePersonalizado_Click(object sender, EventArgs e)
        {
            //mensaje en cuadro de dialogo
            MessageBox.Show("ESTO ES UN MENSAJE CON EL BOTON");
        }

        private void btnDialogoConTitulo_Click(object sender, EventArgs e)
        {
            //mensaje en cuadro, con titulo
            MessageBox.Show("ESTO ES UN MENSAJE CON EL BOTON Y UN TIULO", "TITULO");
        }

        private void btnDialogoConVariosBotones_Click(object sender, EventArgs e)
        {
            //mensaje en cuadro, con titulo y varios botones
            //almacena el resultado en una variable
            DialogResult resultado = MessageBox.Show("HOLA", "TITULO", MessageBoxButtons.YesNoCancel);
            MessageBox.Show(resultado.ToString());
        }
    }
}