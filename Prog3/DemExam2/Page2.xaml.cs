using DemClass;
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

namespace DemExam2
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var true_A = double.TryParse(TextBoxA.Text, out var a);
            var true_B = double.TryParse(TextBoxB.Text, out var b);
            if (true_A && true_B) VichLn.Content = Class1.LinenUr(a, b);
            else VichLn.Content = "Не валидно";
        }
    }
}
