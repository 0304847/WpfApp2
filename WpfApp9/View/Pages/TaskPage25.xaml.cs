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
    /// Логика взаимодействия для TaskPage25.xaml
    /// </summary>
    public partial class TaskPage25 : Page
    {
        public TaskPage25()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbt.Text) | string.IsNullOrEmpty(Tbc.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №25",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbt.Text = string.Empty;
                Tbc.Text = string.Empty;


            }
            else
            {
                double t = Convert.ToDouble(Tbt.Text), c = Convert.ToDouble(Tbc.Text);

                MessageBox.Show($" L ={Math.Pow(Math.Cos(c), 2) + (3 * Math.Pow(t, 2) + 4) / (Math.Sqrt(c+ t))}",
                                "Задание №25",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbt.Text = string.Empty;
                Tbc.Text = string.Empty;


            }

        }
    }
}
