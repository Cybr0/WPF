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

namespace App_Canvas
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

        private void tb1_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("TextBlocks_PreviewMouseMove");

            Canvas.SetZIndex(tb_1, 1);
            Canvas.SetZIndex(tb_2, 0);
            //Panel.SetZIndex(tb_1, 1);
        }

        private void tb1_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            //MessageBox.Show("TextBlocks_PreviewLostKeyboardFocus");
            //Panel.SetZIndex(tb_1, 0);
            Canvas.SetZIndex(tb_1, 0);
            Canvas.SetZIndex(tb_2, 1);
        }

        private void tb2_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("TextBlocks_PreviewMouseMove");

            //Panel.SetZIndex(tb_2, 1);
            Canvas.SetZIndex(tb_2, 1);
            Canvas.SetZIndex(tb_1, 0);
        }

        private void tb2_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            //MessageBox.Show("TextBlocks_PreviewLostKeyboardFocus");
            //Panel.SetZIndex(tb_2, 0);
            Canvas.SetZIndex(tb_2, 0);
            Canvas.SetZIndex(tb_1, 1);
        }
    }
}
