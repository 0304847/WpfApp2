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
    /// Логика взаимодействия для TaskPage6.xaml
    /// </summary>
    public partial class TaskPage6 : Page
    {
        public TaskPage6()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbi.Text) )
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №6",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbi.Text = string.Empty;
                
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), i = Convert.ToDouble(Tbi.Text);

                MessageBox.Show($" L ={(0.81 * Math.Cos(i)) / (Math.Log(y) + 2 * Math.Pow(i, 3))}",
                                "Задание №6",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbi.Text = string.Empty;
              

            }

        }
    }
}
