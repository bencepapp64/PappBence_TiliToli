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
            /*Button1.IsEnabled = false;
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;*/
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
        private void Shuffle_Click(object sender, RoutedEventArgs e)
        {
            
            int diff = Convert.ToInt32(diffy.Text);
            int k = 0;
            int j = 0;
            int rand = 0;
            Random r = new Random();

            Button Button_zero = (Button)FindName("Button0");
            do
            {
                do
                {
                    rand = r.Next(1, 9);
                } while (j == rand);
                j = rand;
                string Button_asd = "Button" + rand;
                Button Button_rand = (Button)FindName(Button_asd);

                int vTav = Math.Abs((int)(Button_rand.Margin.Left - Button_zero.Margin.Left));
                int fTav = Math.Abs((int)(Button_rand.Margin.Top - Button_zero.Margin.Top));
                if ((vTav < 120 && fTav == 0) || (fTav < 120 && vTav == 0))
                {
                    var help = Button_rand.Margin;
                    Button_rand.Margin = Button_zero.Margin;
                    Button_zero.Margin = help;
                    k ++;
                }

            } while (k != diff);
           /* Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;*/
        }
    }
}
