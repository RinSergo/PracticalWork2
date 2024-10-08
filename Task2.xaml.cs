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
using static System.Net.Mime.MediaTypeNames;

namespace PracticalWork2
{
    /// <summary>
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
            textBlockOut();
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

        static Random rnd = new Random();
        int operand1, operand2;
        private void textBlockOut() 
        {
            operand1 = rnd.Next(0, 100);
            operand2 = rnd.Next(0, 100);
            textBlock.Text = $"Введите знак арифметической операции для чисел {operand1} и {operand2}:";
        }
        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            string sign = textBox.Text.Trim();
            double result;
            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    textBlockResult.Text = $"{operand1} {sign} {operand2} = {(int)result}";
                    break;
                case "-":
                    result = operand1 - operand2;
                    textBlockResult.Text = $"{operand1} {sign} {operand2} = {(int)result}";
                    break;
                case "*":
                    result = operand1 * operand2;
                    textBlockResult.Text = $"{operand1} {sign} {operand2} = {(int)result}";
                    break;
                case "/":
                    try
                    {
                        result = Math.Round(Convert.ToDouble(operand1) / operand2, 2);
                        textBlockResult.Text = $"{operand1} {sign} {operand2} = {result}";
                    }
                    catch
                    {
                        textBlockResult.Text = "Ошибка. Деление на ноль";
                    }
                    break;
                default:
                    textBlockResult.Text = $"Ошибка. Введён некорректный символ";
                    break;
            }
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            textBlockOut();
            textBox.Clear();
            textBlockResult.Text = string.Empty;
        }
    }
}
