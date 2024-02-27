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
    /// Логика взаимодействия для TaskPage4.xaml
    /// </summary>
    public partial class TaskPage4 : Page
    {
        public TaskPage4()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbw.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №4",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbw.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), w = Convert.ToDouble(Tbw.Text);

                MessageBox.Show($" G ={(9.33 * Math.Pow(w, 3) + Math.Sqrt(w)) / (Math.Log10(y + 3.5) + Math.Sqrt(y))}",
                                "Задание №4",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbw.Text = string.Empty;

            }
        }
    }
}
