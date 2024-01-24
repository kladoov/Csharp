using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Bateria
{
    /// <summary>
    /// Lógica de interacción para Pila.xaml
    /// </summary>
    public partial class Pila : UserControl
    {
        //establece un numero maximo de carga
        private int cargaMaxima { get; set; }
        public int CargaMaxima { 
            get 
            { 
                return cargaMaxima; 
            } 
            set
            {
                cargaMaxima = value;
                CargaActual = value;
            }
        }
        //establece un numero de carga actual
        public int cargaActual { get; set; }
        public int CargaActual { 
            get 
            {
                return cargaActual;
            }
            set 
            {
                cargaActual = value;
                this.txtPorcentaje.Content = cargaActual;
            }
        }

        //un intervalo de un segundo
        private DispatcherTimer timer;

        //manejador del evento en cuanto se acabe la carga actual
        public event EventHandler Finalizado;
        public Pila()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += Timer_Tick;
        }


        private void Timer_Tick(object? sender, EventArgs e)
        {
            //para el contador de la carga actual cuando llegue a 0 y podras manejar el evento Finalizado
            CargaActual--;
            if(cargaActual <= 0)
            {
                Parar();
            }

            //asignacion de colores cuando llegue a determinados 
            if(CargaActual <= CargaMaxima * 0.75) 
            {
                uno.Fill = Brushes.Gray;
            }
            if (CargaActual <= CargaMaxima * 0.50)
            {
                dos.Fill = Brushes.Gray;
            }
            if (CargaActual <= CargaMaxima * 0.25)
            {
                tres.Fill = Brushes.Gray;
            }
            if (CargaActual == 0)
            {
                cuatro.Fill = Brushes.Gray;
                Finalizado?.Invoke(this, EventArgs.Empty);
            }

        }

        //recarga la bateria al maximo
        public void RecargarBateria()
        {
            cargaActual = cargaMaxima;
            uno.Fill = Brushes.Green;
            dos.Fill = Brushes.Green;
            tres.Fill = Brushes.Green;
            cuatro.Fill = Brushes.Green;
        }

        public void Iniciar()
        {
            timer.Start();
        }

        public void Parar()
        {
            timer.Stop();
        }
    }
}
