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
    /// Логика взаимодействия для PagePR1.xaml
    /// </summary>
    public partial class PagePR1 : Page
    {
        public PagePR1()
        {
            InitializeComponent();
        }


        private void BtnNextPR1_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR2());
        }

        private void BtnSolvePR1_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtPR1X.Text);
            double y = Convert.ToDouble(TxtPR1Y.Text);
            double z = Convert.ToDouble(TxtPR1Z.Text);

            double a = Math.Pow(2, -x) * Math.Sqrt(x + Math.Pow(Math.Abs(y), 0.25)) * Math.Pow(Math.Exp((x - 1) / Math.Sin(z)), 0.33);
            LstResultPR1.Items.Add("ПР№1 ИСП.21.2А Яценко Виктория ");
            LstResultPR1.Items.Add($"x={x}");
            LstResultPR1.Items.Add($"y={y}");
            LstResultPR1.Items.Add($"z={z}");
            LstResultPR1.Items.Add($"Результат: a={a}");
        }

        private void LstResultPR1_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
