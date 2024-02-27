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
    /// Логика взаимодействия для TaskPage11.xaml
    /// </summary>
    public partial class TaskPage11 : Page
    {
        public TaskPage11()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbn.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №11",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbn.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), n = Convert.ToDouble(Tbn.Text);

                MessageBox.Show($" D ={Math.Pow(y, 2) + (0.5 * n + 4.8) / Math.Sin(y)}",
                                "Задание №11",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbn.Text = string.Empty;

            }
        }
    }
}
