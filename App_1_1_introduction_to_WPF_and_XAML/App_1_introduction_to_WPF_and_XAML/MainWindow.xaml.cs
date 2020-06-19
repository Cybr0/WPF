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

namespace App_1_introduction_to_WPF_and_XAML
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(text_box_1.Text == string.Empty)
            {
                button_1.Content = "Clicked";
                MessageBox.Show("You don't enter text.");
            }
            else
            {
                MessageBox.Show("Hi, " + text_box_1.Text);
                button_1.Content = "Button";
            }
        }
    }
}
