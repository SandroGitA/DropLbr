using System.Windows;
using DropLbr;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Drop drop = new Drop();
            MainGrid.Children.Add(drop);
        }
    }
}
