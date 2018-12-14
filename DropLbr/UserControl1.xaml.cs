using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace DropLbr
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class Drop : UserControl
    {
        public Drop()
        {
            InitializeComponent();

            Button mainButton = new Button
            {
                Content = "DropEvent",
                Width = 80,
                Height = 30
            };

            ListBox listBox = new ListBox
            {
                Width = 80,
                Height = 85,
                Visibility = Visibility.Hidden,
                Margin = new Thickness(90, 115, 90, 0),
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
            };

            for (int i = 0; i < 3; i++)
            {
                Button buttonsInList = new Button
                {
                    Content = "Button",
                    BorderBrush = new SolidColorBrush(Colors.Transparent),
                    BorderThickness = new Thickness(0, 0, 0, 0),//border при наведении на кнопку
                    Background = Brushes.White,//цвет внутри кнопки 
                };//единый стиль для кнопок, которые будут в listBox`е

                listBox.Items.Add(buttonsInList);
            }

            mainButton.MouseEnter += button_Drop;
            mainButton.MouseLeave += button_UnDrop;

            listBox.MouseEnter += list_Drop;
            listBox.MouseLeave += list_UnDrop;

            MainGrid.Children.Add(mainButton);
            MainGrid.Children.Add(listBox);

            void button_Drop(object sender, MouseEventArgs e)
            {
                listBox.Visibility = Visibility.Visible;
            }

            void button_UnDrop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Hidden;
            }

            void list_Drop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Visible;
            }

            void list_UnDrop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Hidden;
            }
        }

    }
}
