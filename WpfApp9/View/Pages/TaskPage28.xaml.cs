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
    /// Логика взаимодействия для TaskPage28.xaml
    /// </summary>
    public partial class TaskPage28 : Page
    {
        public TaskPage28()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbv.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №28",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbv.Text = string.Empty;


            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), v = Convert.ToDouble(Tbv.Text);

                MessageBox.Show($" W ={(0.004 * v + Math.Exp(2 * y)) / (Math.Exp(y / 2))}",
                                "Задание №28",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbv.Text = string.Empty;


            }
        }
    }
}
