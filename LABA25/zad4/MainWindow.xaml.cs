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

namespace zad4
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
            Button button = sender as Button;
            grid.Children.Remove(button);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button newButton = new Button();
            newButton.Content = "Новая кнопка";
            newButton.HorizontalAlignment = HorizontalAlignment.Center;
            newButton.VerticalAlignment = VerticalAlignment.Center;
            newButton.Margin = new Thickness(10, 10, 0, 0);
            newButton.Width = 100;
            newButton.MouseEnter += Button_MouseEnter;
            newButton.Click += Button_Click;
            grid.Children.Add(newButton);
        }
    }
}
