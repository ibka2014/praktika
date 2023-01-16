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

namespace Задание_6
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
            try
            {
                string a = Convert.ToString(name.Text);
                int b = Convert.ToInt32(age.Text);
                string c = Convert.ToString(work.Text);
                if (b > 0)
                    l.Content = $"Вас зовут {a}, вам {b} лет , вы работаете {c}.";
                else
                {
                    l.Content = "Введите положительный возраст";
                }
            }
            catch
            {
                l.Content = "Введите правильный возраст";
            }
            
        } 
     }    
}
  
    

