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
    /// Логика взаимодействия для TaskPage23.xaml
    /// </summary>
    public partial class TaskPage23 : Page
    {
        public TaskPage23()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbd.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №23",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbd.Text = string.Empty;


            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), d = Convert.ToDouble(Tbd.Text);

                MessageBox.Show($" R ={(Math.Pow(Math.Sin(y), 3) + 0.3 * d)/ (Math.Exp(y) + Math.Log10(d))}",
                                "Задание №23",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbd.Text = string.Empty;


            }
        }
    }
}
