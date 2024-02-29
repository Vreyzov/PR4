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

namespace WpfApp1
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
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double q = double.Parse(txtq.Text);
            double k;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Соловьев В.И");
            lstResult.Items.Add($"x={x}");
            lstResult.Items.Add($"q={q}");
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (Math.Abs(x * q) > 10) k = Math.Log((Math.Abs(Math.Sin(x)) + Math.Abs(q)));
                    else if (Math.Abs(x * q) < 10) k = Math.Pow(Math.Exp(1), Math.Sin(x + q));
                    else k = Math.Sin(x) + q;
                    lstResult.Items.Add($"Результат k={Math.Round(k, 3)}");
                    break;
                case 1:
                    if (Math.Abs(x * q) > 10) k = Math.Log(Math.Abs(Math.Cos(x)) + Math.Abs(q));
                    else if (Math.Abs(x * q) < 10) k = Math.Pow(Math.Exp(1), Math.Cos(x + q));
                    else k = Math.Cos(x) + q;
                    lstResult.Items.Add($"Результат k={Math.Round(k, 3)}");
                    break;
                case 2:
                    if (Math.Abs(x * q) > 10) k = Math.Log((Math.Abs(Math.Exp(x)) + Math.Abs(q)));
                    else if (Math.Abs(x * q) < 10) k = Math.Pow(Math.Exp(1), Math.Exp(x + q));
                    else k = Math.Exp(x) + q;
                    lstResult.Items.Add($"Результат k={Math.Round(k, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }
        }
        /// <summary>
        /// Очистить поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtq.Clear();
            lstResult.Items.Clear();
        }
    }
}
       
