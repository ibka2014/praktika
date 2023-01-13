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

namespace practice1
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
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string op = TBop.Text;
                switch (op)
                {
                    case "+":
                        double a = Convert.ToDouble(TBA.Text);
                        double b = Convert.ToDouble(TBB.Text);
                        l.Content = $"ответ: {a + b}";
                        break;
                    case "-":
                        double x = Convert.ToDouble(TBA.Text);
                        double y = Convert.ToDouble(TBB.Text);
                        l.Content = $"ответ: {x - y}";
                        break;
                    case "*":
                        double c = Convert.ToDouble(TBA.Text);
                        double d = Convert.ToDouble(TBB.Text);
                        l.Content = $"ответ: {c * d}";
                        break;
                    case "/":
                        double n = Convert.ToDouble(TBA.Text);
                        double f = Convert.ToDouble(TBB.Text);
                        if (f != 0)
                            l.Content = $"ответ: {n / f}";
                        else
                            l.Content = "Error";
                        break;
                    case "cos":
                        double p = Convert.ToDouble(TBA.Text);
                        l.Content = $"ответ: {Math.Round(Math.Cos(p))}";
                        break;
                    case "sin":
                        double r = Convert.ToDouble(TBA.Text);
                        l.Content = $"ответ: {Math.Round(Math.Sin(r), 2)}";
                        break;
                    case "tg":
                        double j = Convert.ToDouble(TBA.Text);
                        l.Content = $"ответ: {Math.Round(Math.Tan(j), 2)}";
                        break;
                    case "ctg":
                        double t = Convert.ToDouble(TBA.Text);
                        l.Content = $"ответ: {Math.Round(1 / Math.Tan(t), 2)}";
                        break;


                }


            }
            catch
            {
                l.Content = "ошибка";
            }
        }

        
    }
}
