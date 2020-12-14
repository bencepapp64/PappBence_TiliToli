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

namespace TiliToli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button0.Visibility = Visibility.Hidden;
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button egyikGomb = sender as Button;
            Button nullaGomb = (Button)FindName("Button0");
            int vTav = Math.Abs((int)(egyikGomb.Margin.Left - nullaGomb.Margin.Left));
            int fTav = Math.Abs((int)(egyikGomb.Margin.Top - nullaGomb.Margin.Top));
            if ((vTav < 120 && fTav == 0) || (fTav < 120 && vTav == 0))
            {
                var seged = egyikGomb.Margin;
                egyikGomb.Margin = nullaGomb.Margin;
                nullaGomb.Margin = seged;
            }
        }
    }
}
