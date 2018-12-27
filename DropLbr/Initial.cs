using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DropLbr
{
    public partial class Drop
    {
        Button mainButton = new Button
        {
            Content = "DropEvent",
            Width = 80,
            Height = 30,
            BorderBrush = new SolidColorBrush(Colors.Gray)
        };

        ListBox listBox = new ListBox
        {
            Width = 80,
            Height = 60,
            Visibility = Visibility.Hidden,
            Margin = new Thickness(90, 90, 90, 0),
            HorizontalContentAlignment = HorizontalAlignment.Stretch,
            BorderThickness = new Thickness(1, 0, 1, 1),
            BorderBrush = new SolidColorBrush(Colors.Gray),
        };

        public void InitDrop()
        {
            mainButton.MouseEnter += button_Drop;
            mainButton.MouseLeave += button_UnDrop;

            listBox.MouseEnter += list_Drop;
            listBox.MouseLeave += list_UnDrop;

            MainGrid.Children.Add(mainButton);
            MainGrid.Children.Add(listBox);

            void button_Drop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Visible;
                mainButton.BorderThickness = new Thickness(1, 1, 1, 0);

                for (int i = 0; i < ItemCount; i++)
                {
                    Button buttonsInList = new Button
                    {
                        Content = "Button",
                        BorderBrush = new SolidColorBrush(Colors.Transparent),
                        BorderThickness = new Thickness(0),//border при наведении на кнопку
                        Background = Brushes.White,//цвет внутри кнопки 
                    };//единый стиль для кнопок, которые будут в listBox`е

                    listBox.Items.Add(buttonsInList);
                }
                ItemCount = 0;
            }

            void button_UnDrop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Hidden;
                mainButton.BorderThickness = new Thickness(1);
            }

            void list_Drop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Visible;
                mainButton.BorderThickness = new Thickness(1, 1, 1, 0);
            }

            void list_UnDrop(object sender, EventArgs e)
            {
                listBox.Visibility = Visibility.Hidden;
                mainButton.BorderThickness = new Thickness(1);
            }
        }
    }
}
