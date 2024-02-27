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
    /// Логика взаимодействия для TaskPage24.xaml
    /// </summary>
    public partial class TaskPage24 : Page
    {
        public TaskPage24()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbk.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №24",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbk.Text = string.Empty;


            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), k = Convert.ToDouble(Tbk.Text);

                MessageBox.Show($" U ={(Math.Log10(2 * k + 4.3)) / (Math.Exp(k + y) + Math.Sqrt(y))}",
                                "Задание №24",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbk.Text = string.Empty;


            }
        }
    }
}
