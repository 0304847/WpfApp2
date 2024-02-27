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
    /// Логика взаимодействия для TaskPage30.xaml
    /// </summary>
    public partial class TaskPage30 : Page
    {
        public TaskPage30()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbp.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №30",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbp.Text = string.Empty;


            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), p = Convert.ToDouble(Tbp.Text);

                MessageBox.Show($" N ={(3 * Math.Pow(y, 2) + Math.Sqrt(y + 1)) / (Math.Log10(p + y) + Math.Exp(p))}",
                                "Задание №30",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbp.Text = string.Empty;


            }
        }
    }
}
