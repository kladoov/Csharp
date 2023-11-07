namespace _11_ReservaHotelera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            reserva.ShowDialog();
        }
    }
}