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
    /// Логика взаимодействия для TaskPage19.xaml
    /// </summary>
    public partial class TaskPage19 : Page
    {
        public TaskPage19()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbq.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №19",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbq.Text = string.Empty;


            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), q = Convert.ToDouble(Tbq.Text);

                MessageBox.Show($" E ={(Math.Log10(0.7 * y + 2 * q)) / (Math.Sqrt(3 * Math.Pow(y, 20) + 0.5 * y + 4))}",
                                "Задание №19",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbq.Text = string.Empty;



            }
        }
    }
}
