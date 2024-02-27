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
    /// Логика взаимодействия для TaskPage26.xaml
    /// </summary>
    public partial class TaskPage26 : Page
    {
        public TaskPage26()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbu.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №26",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbu.Text = string.Empty;


            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), u = Convert.ToDouble(Tbu.Text);

                MessageBox.Show($" T ={(Math.Sin(2 * u)) / (Math.Log10(2 * y + u))}",
                                "Задание №26",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbu.Text = string.Empty;


            }
        }
    }
}
