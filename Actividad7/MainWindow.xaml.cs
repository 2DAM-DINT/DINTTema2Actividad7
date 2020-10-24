using System.Windows;
using System.Windows.Controls;

namespace Actividad7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pequeño.IsChecked = true;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            texto.FontSize = 
                double.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
