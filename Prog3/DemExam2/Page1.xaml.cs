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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void VichKv_Click(object sender, RoutedEventArgs e)
        {
            var true_A = double.TryParse(TextBoxA.Text, out var a);
            var true_B = double.TryParse(TextBoxB.Text, out var b);
            var true_C = double.TryParse(TextBoxC.Text, out var c);
            if (true_A && true_B && true_C) LabelKv.Content = Class1.SquareMetod(a, b, c);
            else LabelKv.Content = "Не валидно";
        }
    }
}
