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
    /// Логика взаимодействия для TaskPage12.xaml
    /// </summary>
    public partial class TaskPage12 : Page
    {
        public TaskPage12()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbt.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №12",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbt.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), t = Convert.ToDouble(Tbt.Text);

                MessageBox.Show($" R ={(Math.Sin(Math.Pow(2 * t + 1, 2)) + 0.3) / (Math.Log10(t + y))}",
                                "Задание №12",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbt.Text = string.Empty;

            }
        }
    }
}
