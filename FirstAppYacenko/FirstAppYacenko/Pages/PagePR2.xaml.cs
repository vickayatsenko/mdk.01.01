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

namespace FirstAppYacenko.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR2.xaml
    /// </summary>
    public partial class PagePR2 : Page
    {

        public PagePR2()
        {
            InitializeComponent();
        }

        private void LstResultPR2_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void BtnSolvePR2_Click(object sender, RoutedEventArgs e)
        {
            LstResultPR2.Items.Clear();
            double x = double.Parse(TxtPR2X.Text);
            double y = double.Parse(TxtPR2Y.Text);
            double z;
            LstResultPR2.Items.Add("Лаб.раб.№2. Яценко Виктория");
            LstResultPR2.Items.Add($"X={x}");
            LstResultPR2.Items.Add($"Y={y}");
            int n = 0;
            if (RbtShxPR2.IsChecked == true) n = 1;
            else if (RbtExPR2.IsChecked == true) n = 2;
            switch (n)
            {




                case 0:
                    if (y % 2 != 0 & x > 0) z = y * Math.Sqrt(Math.Sin(x));
                    else if (y % 2 == 0 & x < 0) z = y / 2 * Math.Sqrt(Math.Abs(Math.Sin(x)));
                    else z = Math.Sqrt(Math.Abs(y * Math.Sin(x)));
                    LstResultPR2.Items.Add($"Результат Z={Math.Round(z, 3)}");
                    break;
                case 1:
                    if (y % 2 != 0 & x > 0) z = y * Math.Sqrt(Math.Cos(x));
                    else if (y % 2 == 0 & x < 0) z = y / 2 * Math.Sqrt(Math.Abs(Math.Cos(x)));
                    else z = Math.Sqrt(Math.Abs(y * Math.Cos(x)));
                    LstResultPR2.Items.Add($"Результат Z={Math.Round(z, 3)}");
                    break;
                case 2:
                    if (y % 2 != 0 & x > 0) z = y * Math.Sqrt(Math.Exp(x));
                    else if (y % 2 == 0 & x < 0) z = y / 2 * Math.Sqrt(Math.Abs(Math.Exp(x)));
                    else z = Math.Sqrt(Math.Abs(y * Math.Exp(x)));
                    LstResultPR2.Items.Add($"Результат Z={Math.Round(z, 3)}");
                    break;


                default:
                    LstResultPR2.Items.Add("Решение не найдено");
                    break;

            }

        }
        private void BtnClearPR2_Click(object sender, RoutedEventArgs e)
            {
                TxtPR2X.Clear();
                TxtPR2Y.Clear();
                TxtPR2Z.Clear();
                LstResultPR2.Items.Clear();
            }

        private void BtnBackPR2_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR1());
        }

        private void BtnNextPR2_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR3());
        }
    }
}
