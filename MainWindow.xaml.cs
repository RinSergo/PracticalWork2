using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticalWork2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == t1)
            {
                Task1 task1 = new Task1();
                task1.Show();
                this.Close();
            }
            if (sender == t2)
            {
                Task2 task2 = new Task2();
                task2.Show();
                this.Close();
            }
            if (sender == t3)
            {
                Task3 task3 = new Task3();
                task3.Show();
                this.Close();
            }
            if (sender == t4)
            {
                Task4 task4 = new Task4();
                task4.Show();
                this.Close();
            }
        }
    }
}