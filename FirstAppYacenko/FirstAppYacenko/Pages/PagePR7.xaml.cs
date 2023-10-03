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
    /// Логика взаимодействия для PagePR7.xaml
    /// </summary>
    public partial class PagePR7 : Page
    {
        public PagePR7()
        {
            InitializeComponent();
        }
        private void BtnPR7Result_Click(object sender, RoutedEventArgs e)
        {



            int[] array = new int[14] { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10, 11, -12, 13, -14 };

            int[] modifiedArray = ModifyArray(array);

            string originalArrayString = string.Join(", ", array);
            string modifiedArrayString = string.Join(", ", modifiedArray);

           LstPR7Result.Items.Add ($"Исходный массив: {originalArrayString}\n\n Итоговый массив: {modifiedArrayString}");
        }

        private int[] ModifyArray(int[] array)
        {
            int[] modifiedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    modifiedArray[i] = 3;
                }
                else
                {
                    modifiedArray[i] = array[i];
                }
            }

            return modifiedArray;
        }



        private void BtnPR7Clear_Click(object sender, RoutedEventArgs e)
        {
            LstPR7Result.Items.Clear();
        }

        private void BtnPR7Back_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR6());
        }

        private void BtnPR7Next_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR1());
        }
    }
}
