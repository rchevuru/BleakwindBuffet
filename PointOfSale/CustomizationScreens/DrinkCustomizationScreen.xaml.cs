/*
 * Author: Zachery Brunner
 * Class: DrinkCustomizationScreen.xaml.cs
 * Purpose: Backend logic for the DrinkCustomizationScreen
 */
using System;
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data.Drinks;

using SodaFlavor = BleakwindBuffet.Data.Enums.SodaFlavor;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for DrinkCustomizationScreen.xaml
    /// </summary>
    public partial class DrinkCustomizationScreen : UserControl
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public DrinkCustomizationScreen(object DataContext)
        {
            InitializeComponent();
            this.DataContext = DataContext;
            if (DataContext is AretinoAppleJuice) AretinoAppleJuiceSetup();
            if (DataContext is CandlehearthCoffee) CandlehearthCoffeeSetup();
            if (DataContext is MarkarthMilk) MarkarthMilkSetup();
            if (DataContext is SailorSoda) SailorSodaSetup();
            if (DataContext is WarriorWater) WarriorWaterSetup();
        }

        /// <summary>
        /// Initializes the screen for a warrior water
        /// </summary>
        private void WarriorWaterSetup()
        {
            IceCheckBox.Visibility = Visibility.Visible;
            LemonCheckBox.Visibility = Visibility.Visible;
            DecafCheckBox.Visibility = Visibility.Collapsed;
            CreamCheckBox.Visibility = Visibility.Collapsed;
            SailorSodaFlavorComboBox.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Initializes the screen for a markarth milk
        /// </summary>
        private void MarkarthMilkSetup()
        {
            IceCheckBox.Visibility = Visibility.Visible;
            LemonCheckBox.Visibility = Visibility.Collapsed;
            DecafCheckBox.Visibility = Visibility.Collapsed;
            CreamCheckBox.Visibility = Visibility.Collapsed;
            SailorSodaFlavorComboBox.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Initializes the screen for candlehearth coffee
        /// </summary>
        private void CandlehearthCoffeeSetup()
        {
            IceCheckBox.Visibility = Visibility.Visible;
            LemonCheckBox.Visibility = Visibility.Collapsed;
            DecafCheckBox.Visibility = Visibility.Visible;
            CreamCheckBox.Visibility = Visibility.Visible;
            SailorSodaFlavorComboBox.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Initializes the screen for aretino apple juice
        /// </summary>
        private void AretinoAppleJuiceSetup()
        {
            IceCheckBox.Visibility = Visibility.Visible;
            LemonCheckBox.Visibility = Visibility.Collapsed;
            DecafCheckBox.Visibility = Visibility.Collapsed;
            CreamCheckBox.Visibility = Visibility.Collapsed;
            SailorSodaFlavorComboBox.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Initializes the screen for sailor soda
        /// </summary>
        private void SailorSodaSetup()
        {
            IceCheckBox.Visibility = Visibility.Visible;
            LemonCheckBox.Visibility = Visibility.Collapsed;
            DecafCheckBox.Visibility = Visibility.Collapsed;
            CreamCheckBox.Visibility = Visibility.Collapsed;
            SailorSodaFlavorComboBox.Visibility = Visibility.Visible;

            foreach(string enumValue in Enum.GetNames(typeof(SodaFlavor)))
            {
                SailorSodaFlavorComboBox.Items.Add(enumValue);
                if (enumValue == "Cherry") SailorSodaFlavorComboBox.SelectedItem = enumValue;
            }
        }

        /// <summary>
        /// Changes the flavor of the sailor soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SailorSodaFlavorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is SailorSoda SS)
            {
                foreach (string s in e.AddedItems)
                {
                    if (s == "Blackberry") SS.Flavor = SodaFlavor.Blackberry;
                    if (s == "Cherry") SS.Flavor = SodaFlavor.Cherry;
                    if (s == "Grapefruit") SS.Flavor = SodaFlavor.Grapefruit;
                    if (s == "Lemon") SS.Flavor = SodaFlavor.Lemon;
                    if (s == "Peach") SS.Flavor = SodaFlavor.Peach;
                    if (s == "Watermelon") SS.Flavor = SodaFlavor.Watermelon;
                }
            }
        }
    }
}