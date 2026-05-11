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
using nickenv;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool TryGetTriangles(out RightTriangle t1, out RightTriangle t2)
        {
            t1 = null;
            t2 = null;
            try
            {
                double x1 = Checker.EnterDouble(txtX1.Text);
                double y1 = Checker.EnterDouble(txtY1.Text);
                double x2 = Checker.EnterDouble(txtX2.Text);
                double y2 = Checker.EnterDouble(txtY2.Text);

                t1 = new RightTriangle(x1,y1);
                t2 = new RightTriangle(x2, y2);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка ввода: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        private void Log(string message) => txtLog.AppendText($"{message}\n");

        private void BtnSquare_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetTriangles(out RightTriangle t1, out _))
            {
                Log($"Площадь Т1: {t1.Square()}");
            }
        }

        private void BtnToString_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetTriangles(out RightTriangle t1, out RightTriangle t2))
            {
                Log($"T1: {t1}");
                Log($"T2: {t2}");
            }
        }

        private void BtnInc_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetTriangles(out RightTriangle t1, out _))
            {
                t1++;
                txtX1.Text = t1.X.ToString();
                txtY1.Text = t1.Y.ToString();
                Log($"T1 после ++: {t1}");
            }
        }

        private void BtnDec_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetTriangles(out RightTriangle t1, out _))
            {
                t1--;
                txtX1.Text = t1.X.ToString();
                txtY1.Text = t1.Y.ToString();
                Log($"T1 после --: {t1}");
            }
        }

        private void BtnCompare_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetTriangles(out RightTriangle t1, out RightTriangle t2))
            {
                Log($"T1 <= T2: {t1 <= t2}");
                Log($"T1 >= T2: {t1 >= t2}");
            }
        }

        private void BtnCast_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetTriangles(out RightTriangle t1, out _))
            {
                Log($"Явное (double)T1: {(double)t1}");
                Log($"Неявное (bool)T1: {(t1 ? "Существует/True" : "Не существует/False")}");
            }
        }
    }
}