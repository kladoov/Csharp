using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextoEstiloBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPequeño_Click(object sender, RoutedEventArgs e)
        {
            this.sldProgreso.Value = 5;
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            this.sldProgreso.Value = 20;
        }

        private void btnGrande_Click(object sender, RoutedEventArgs e)
        {
            this.sldProgreso.Value = 40;
        }
    }
}