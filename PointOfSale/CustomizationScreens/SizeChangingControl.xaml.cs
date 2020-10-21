/*
 * Author: Zachery Brunner
 * Class: SizeChangingControl.xaml.cs
 * Purpose: Handles changing the size of the datacontext (Side or Drink)
 */
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for SizeChangingControl.xaml
    /// </summary>
    public partial class SizeChangingControl : UserControl
    {
        public SizeChangingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the size of the item to the new size determined by the button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeButton_Click(object sender, RoutedEventArgs e)
        {
            Size s;

            if (sender is Button b)
            {
                switch (b.Name)
                {
                    case "SizeSmallButton":
                        SizeSmallButton.Foreground = Brushes.White;
                        SizeSmallButton.Background = Brushes.Black;

                        SizeMediumButton.Foreground = Brushes.Black;
                        SizeMediumButton.Background = Brushes.White;

                        SizeLargeButton.Foreground = Brushes.Black;
                        SizeLargeButton.Background = Brushes.White;

                        s = Size.Small;
                        break;

                    case "SizeMediumButton":
                        SizeSmallButton.Foreground = Brushes.Black;
                        SizeSmallButton.Background = Brushes.White;

                        SizeMediumButton.Foreground = Brushes.White;
                        SizeMediumButton.Background = Brushes.Black;

                        SizeLargeButton.Foreground = Brushes.Black;
                        SizeLargeButton.Background = Brushes.White;

                        s = Size.Medium;
                        break;

                    case "SizeLargeButton":
                        SizeSmallButton.Foreground = Brushes.Black;
                        SizeSmallButton.Background = Brushes.White;

                        SizeMediumButton.Foreground = Brushes.Black;
                        SizeMediumButton.Background = Brushes.White;

                        SizeLargeButton.Foreground = Brushes.White;
                        SizeLargeButton.Background = Brushes.Black;

                        s = Size.Large;
                        break;

                    default:
                        throw new NotImplementedException("Unknown size button clicked");
                }

                if (DataContext is Drink d) d.Size = s;
                else if (DataContext is Side si) si.Size = s;
                else throw new NotImplementedException("Unknown type of item, attempting to set size");
            }
        }
    }
}