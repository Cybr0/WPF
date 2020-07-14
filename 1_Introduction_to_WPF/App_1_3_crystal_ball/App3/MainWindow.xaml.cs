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
using System.Threading;

namespace App3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool txtQuestion_MouseEnter_IF_FIRST_ENTER = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;

            Thread.Sleep(1000);

            txtAnswer.Text = AnswerGenerator.GetRandomAnswer();
            this.Cursor = null;
        }

        private void txtQuestion_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtQuestion_MouseEnter_IF_FIRST_ENTER)
            {
                (sender as TextBox).Text = "";
                txtQuestion_MouseEnter_IF_FIRST_ENTER = false;
            }
        }
    }
}
