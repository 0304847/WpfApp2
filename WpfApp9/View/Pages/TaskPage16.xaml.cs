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
    /// Логика взаимодействия для TaskPage16.xaml
    /// </summary>
    public partial class TaskPage16 : Page
    {
        public TaskPage16()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbt.Text) | string.IsNullOrEmpty(Tbr.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №16",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbt.Text = string.Empty;
                Tbr.Text = string.Empty;

            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), t = Convert.ToDouble(Tbt.Text), r = Convert.ToDouble(Tbr.Text);

                MessageBox.Show($" W ={(4 * Math.Pow(t, 3) + Math.Log10(r)) / (Math.Exp(y + r) + 7.2 + Math.Sin(r))}",
                                "Задание №16",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbt.Text = string.Empty;
                Tbr.Text = string.Empty;


            }
        }
    }
}
