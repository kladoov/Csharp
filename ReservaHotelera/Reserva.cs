using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_ReservaHotelera
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
            lblNumeroHabitaciones.Visible = false;
            lblNumeroJornadas.Visible = false;
            nudNumeroHabitaciones.Visible = false;
            nudNumeroJornadas.Visible = false;
            rbNo.Visible = false;
            rbSi.Visible = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //datos personales
                String nombre = this.txtNombre.Text;
                int telefono = int.Parse(txtTelefono.Text);

                //datos evento
                DateTime fecha = this.dtpFechaEvento.Value;
                String fechaParser = fecha.ToString();
                String tipo = this.cbTipo.Text;
                int numPersonas = (int)this.nudPersonas.Value;
                String tipoCocina = this.cbTipoCocina.Text;
                int numJornadas = (int)this.nudNumeroJornadas.Value;
                int numHabitaciones = (int)this.nudNumeroHabitaciones.Value;

                if (this.cbTipo.SelectedIndex == 0 || this.cbTipo.SelectedIndex == 1)
                {
                    MessageBox.Show("Nombre: " + nombre +
                                    "\nTelefono: " + telefono +
                                    "\nFecha del evento: " + fechaParser +
                                    "\nTipo: " + tipo +
                                    "\nNº de personas que asisten: " + numPersonas +
                                    "\nTipo de cocina: " + tipoCocina, "Tipo " + tipo);
                }
                else
                {
                    MessageBox.Show("Nombre: " + nombre +
                                    "\nTelefono: " + telefono +
                                    "\nFecha del evento: " + fechaParser +
                                    "\nTipo: " + tipo +
                                    "\nNº de jornadas " + numJornadas +
                                    "\nNº de habitaciones " + numHabitaciones +
                                    "\nNº de personas que asisten: " + numPersonas +
                                    "\nTipo de cocina: " + tipoCocina, "Tipo " + tipo);
                }

                this.txtNombre.Text = "";
                this.txtTelefono.Text = "";
                this.dtpFechaEvento.Text = "";
                this.cbTipo.Text = "";
                this.cbTipoCocina.Text = "";
                this.nudNumeroHabitaciones.Value = 0;
                this.nudNumeroJornadas.Value = 0;
                this.nudPersonas.Value = 0;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("NO ES UN NÚMERO DE TELÉFONO " + this.txtTelefono.Text);
            }

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbTipo.SelectedIndex == 2)
            {
                this.lblNumeroJornadas.Visible = true;
                this.nudNumeroJornadas.Visible = true;
                this.lblNumeroHabitaciones.Visible = true;
                this.rbSi.Visible = true;
                this.rbNo.Visible = true;
            }
            else if (this.cbTipo.SelectedIndex == 1)
            {
                this.lblNumeroJornadas.Visible = false;
                this.nudNumeroJornadas.Visible = false;
                this.lblNumeroHabitaciones.Visible = false;
                this.nudNumeroHabitaciones.Visible = false;
                this.rbSi.Visible = false;
                this.rbNo.Visible = false;
                this.nudNumeroHabitaciones.Value = 0;
                this.nudNumeroJornadas.Value = 0;
            }
            else if (this.cbTipo.SelectedIndex == 0)
            {
                this.lblNumeroJornadas.Visible = false;
                this.nudNumeroJornadas.Visible = false;
                this.lblNumeroHabitaciones.Visible = false;
                this.nudNumeroHabitaciones.Visible = false;
                this.rbSi.Visible = false;
                this.rbNo.Visible = false;
                this.nudNumeroHabitaciones.Value = 0;
                this.nudNumeroJornadas.Value = 0;
            }
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbSi.Checked)
            {
                this.nudNumeroHabitaciones.Visible = true;
            }
            else if (this.rbNo.Checked)
            {
                this.nudNumeroHabitaciones.Value = 0;
                this.nudNumeroHabitaciones.Visible = false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
