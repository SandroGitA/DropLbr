using System.Windows;
using System.Windows.Controls;

namespace DropLbr
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class Drop : UserControl
    {
        public static DependencyProperty CountProperty;

        public int ItemCount
        {
            set { SetValue(CountProperty, value); }
            get { return (int)GetValue(CountProperty); }
        }

        static Drop()
        {
            CountProperty = DependencyProperty.Register("ItemCount", typeof(int), typeof(Drop),
                new FrameworkPropertyMetadata(1));
        }                 

        public Drop()
        {
            InitializeComponent();
            InitDrop();
        }        
    }
}
