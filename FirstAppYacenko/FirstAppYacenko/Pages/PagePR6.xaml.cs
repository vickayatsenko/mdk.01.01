using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PagePR6.xaml
    /// </summary>
    public partial class PagePR6 : Page
    {
        public PagePR6()
        {
            InitializeComponent();
        }
        private void BtnLFFPR6_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                LstPR6Int.Items.Add(sr.ReadLine());
            }
        }

        private void BtnPR6Clear_Click(object sender, RoutedEventArgs e)
        {
            LstPR6Int.Items.Clear();
        }

        private void BtnPR6Rez_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int index = LstPR6Int.SelectedIndex;

                string str = (string)LstPR6Int.Items[index];

                int len = str.Length;

                int count = 0;

                int i = 0;

                while (i < len - 1)
                {
                    if (str[i] == ' ')
                        count++;
                    i++;
                }

                TxbRez.Text = "Количество пробелов = " + count.ToString();

                StreamWriter sw = new StreamWriter(@"result.txt");
                sw.WriteLine($"Номер строки: {index}");
                sw.WriteLine($"Исходная строка: {index}");
                sw.WriteLine($"Новая строка: {TxbRez.Text}");
                sw.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPR6Back_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR3());
        }

        private void BtnPR6Next_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR7());
        }
    }
}
