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
    /// Логика взаимодействия для TaskPage7.xaml
    /// </summary>
    public partial class TaskPage7 : Page
    {
        public TaskPage7()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbm.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №7",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbm.Text = string.Empty;
                
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), m = Convert.ToDouble(Tbm.Text);

                MessageBox.Show($" N ={(Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6)}",
                                "Задание №7",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbm.Text = string.Empty;
                

            }

        }
    }
}
