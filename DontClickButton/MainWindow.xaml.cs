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

namespace DontClickButton
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

        private void buttonClick_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int width = Convert.ToInt32(_myGrid.ActualWidth-buttonClick.ActualWidth);
            int height = Convert.ToInt32(_myGrid.ActualHeight-buttonClick.ActualHeight);
            buttonClick.Margin = new Thickness(rnd.Next(width), rnd.Next(height),0,0);
        }

        private void buttonClick_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
