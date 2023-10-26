namespace _03_Cuestionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //recoge el valor de un radioButton
            String radio = "";
            if (rbLinux.Checked)
                radio = rbLinux.Text;
            else if (rbMac.Checked)
                radio = rbMac.Text;
            else if (rbWindows.Checked)
                radio = rbWindows.Text;

            //recoge el valor del checkBox
            String programacion = "", dise�o = "", administracion = "";
            if (chkProgramacion.Checked)
                programacion = chkProgramacion.Text;
            if (chkDise�o.Checked)
                dise�o = chkDise�o.Text;
            if (chkAdministracion.Checked)
                administracion = chkAdministracion.Text;

            //recoge el valor del trackBar
            int hora = trackHoras.Value;

            MessageBox.Show("Tu SO preferido es " + radio + ", tus especialidades son " + programacion + " " + dise�o + " " + administracion +
                           " y el numero de horas dedicadas al ordenador son " + hora, "Muestra de datos");
        }

        private void trackHoras_Scroll(object sender, EventArgs e)
        {
            int hora = trackHoras.Value;
            this.lblHoras.Text = hora.ToString();
            
        }
    }
}