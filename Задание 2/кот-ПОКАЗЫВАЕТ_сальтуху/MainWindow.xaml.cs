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

namespace кот_ПОКАЗЫВАЕТ_сальтуху
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(grandma.Text);
            if (a <=5)
            {
                double b = a * 10;
                double d = b % 60;
                time.Content = $"Вы должны отстоять в очереди {d} минут";
            }
            else if (a >=5)
            {
                double b = a * 10;
                double c = b / 60;
                double d = b % 60;
                time.Content = $"Вы должны отстоять в очереди {Math.Truncate(c)} час(а) {d} минут";
            }
            else
            {
                time.Content = "В очереди пусто";
            }
        }
    }
}
