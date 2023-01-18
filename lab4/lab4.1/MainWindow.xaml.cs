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

namespace lab4._1
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
        int TT = 0;
        int RR = 0;
        bool EE = false;
        private void QQ_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TT = Convert.ToInt32(number1.Text);
                RR = Convert.ToInt32(number2.Text);
                l.Content = "";
                if (TT >= RR)
                {
                    l.Content = "ошибка";
                }
                else
                {
                    for (int a = TT + 1; a < RR; a++)
                    {
                        if (EE)
                        {
                            if (a % 2 == 0)
                                continue;
                            else
                                Doom.Content += $"{a} ";
                        }
                        else
                        {
                            l.Content += $"{a} ";
                        }
                    }
                }
            }
            catch
            {
                l.Content = "ошибка";
            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            l.Content = "";
            EE = !EE;
        }
    }
}
    

