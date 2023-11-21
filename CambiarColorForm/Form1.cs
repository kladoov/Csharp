namespace CambioColor
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColoRandom_Click(object sender, EventArgs e)
        {
            //genera los colores red, green y blue aleatoriamente
            int r = rnd.Next(1, 255);
            int g = rnd.Next(1, 255);
            int b = rnd.Next(1, 255);

            //cambia el color del fondo aleatoriamente
            this.BackColor = Color.FromArgb(r, g, b);

            this.lblColor.Text = "Color random: " + "{" + r + "," + g + "," + b + "}";
        }

        private void btnColorEspecifico_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            
            //cambia el color de fondo del Form1, con el color deseado
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;

                Color seleccionado = colorDialog.Color;
                lblColor.Text = "Color especifico: " + seleccionado.ToString();
            }
        }
    }
}
