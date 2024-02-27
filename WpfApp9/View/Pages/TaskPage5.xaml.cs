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
    /// Логика взаимодействия для TaskPage5.xaml
    /// </summary>
    public partial class TaskPage5 : Page
    {
        public TaskPage5()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tba.Text)| string.IsNullOrEmpty(Tbt.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №5",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tba.Text = string.Empty;
                Tbt.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), a = Convert.ToDouble(Tba.Text), t = Convert.ToDouble(Tbt.Text);

                MessageBox.Show($" D ={(7.8 * Math.Pow(a, 2) + 3.52 * t) / (Math.Log10(a + 2 * y) + Math.Exp(y))}",
                                "Задание №5",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tba.Text = string.Empty;
                Tbt.Text = string.Empty;

            }

        }
    }
}
