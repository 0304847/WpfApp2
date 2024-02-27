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

namespace WpfApp9.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage14.xaml
    /// </summary>
    public partial class TaskPage14 : Page
    {
        public TaskPage14()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbh.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №14",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbh.Text = string.Empty;
                
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), h = Convert.ToDouble(Tbh.Text) ;

                MessageBox.Show($" P ={(Math.Exp(y + 2.5) + 7.1 * Math.Pow(h, 3)) / (Math.Log10(Math.Sqrt(y + 0.04 * h)))}",
                                "Задание №14",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbh.Text = string.Empty;
               

            }
        }
    }
}
