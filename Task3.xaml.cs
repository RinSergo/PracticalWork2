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
using System.Windows.Shapes;

namespace PracticalWork2
{
    /// <summary>
    /// Логика взаимодействия для Task3.xaml
    /// </summary>
    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            try
            {
                double num = double.Parse(textBox.Text.Trim());
                if ((num >= 0) && (num <= 14)) 
                {
                    textBlock.Text = "Число входит в числовой промежуток: [0 - 14]";
                }
                if ((num >= 15) && (num <= 35)) 
                {
                    textBlock.Text = "Число входит в числовой промежуток: [15 - 35]";
                }
                if ((num >= 36) && (num < 50)) 
                {
                    textBlock.Text = "Число входит в числовой промежуток: [36 - 50]";
                }
                if (num == 50)
                {
                    textBlock.Text = "Число входит в числовые промежутки: [36 - 50] и [50 - 100]";
                }
                if ((num > 50) && (num <= 100))
                {
                    textBlock.Text = "Число входит в числовой промежуток: [50 - 100]";
                }
                if ((num > 100) || (num < 0)) 
                {
                    textBlock.Text = "Число не входит ни в один из числовых промежутков";
                }
            }
            catch
            {
                textBlock.Text = "Ошибка. Введено не число";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
