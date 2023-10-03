namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            String numStr = this.txtOperando1.Text.ToString();
            int num1 = int.Parse(numStr);
            String numStr2 = this.txtOperando2.Text.ToString();
            int num2 = int.Parse(numStr2);

            int suma = num1 + num2;
            String textoSuma = suma.ToString();

            this.txtResultado.Text = textoSuma;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            String numStr = this.txtOperando1.Text.ToString();
            int num1 = int.Parse(numStr);
            String numStr2 = this.txtOperando2.Text.ToString();
            int num2 = int.Parse(numStr2);

            int resta = num1 - num2;
            String textoResta = resta.ToString();

            this.txtResultado.Text = textoResta;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la calculadora?",
            "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}