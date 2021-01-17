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
using lib1;


namespace calcul
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (cb.Text)
            {
                case "Sin":
                    {
                        Trig sin = new Trig(tb.Text);
                        tbm.Text = "Sin(" + tb.Text + ") = " + sin.Sin();
                    }
                    return;

                case "Cos":
                    {
                        Trig cos = new Trig(tb.Text);
                        tbm.Text = "Cos(" + tb.Text + ") = " + cos.Cos();
                    }
                    return;

            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            tb.Text = "";
            tbm.Text = "";

        }

        private void tbm_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
