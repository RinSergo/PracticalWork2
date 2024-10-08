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
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"погода", "weather"},
            {"дождь", "rain"},
            {"снегопад", "snowfall"},
            {"гроза", "thunderstorm"},
            {"температура", "temperature"},
            {"влажность", "humidity"},
            {"потепление", "warming"},
            {"заморозки", "freezing"},
            {"облачность", "cloudiness"},
            {"жара", "heat"}
        };

        private void Button_Click_translate(object sender, RoutedEventArgs e)
        {
            if (dictionary.ContainsKey(textBox.Text.ToLower().Trim()))
            {
                textBlockResult.Text = dictionary[textBox.Text.ToLower().Trim()];
            } else
            {
                textBlockResult.Text = "Ошибка. Такого слова нет";
            }
        }
    }
}
