/*
 * Author: Zachery Brunner
 * Class: MenuCategorySelectionControl.xaml.cs
 * Purpose: Backend logic for the user controls
 */
using System;

using System.Windows;
using System.Windows.Controls;

using PointOfSale.ExtensionMethod;
using PointOfSale.CategoryScreens;
using PointOfSale.CustomizationScreens;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuCategorySelectionControl : UserControl
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public MenuCategorySelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches screen to selected category screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchScreenToSelectedCategory(object sender, RoutedEventArgs e)
        {
            /* The logic we do past this point requires the sender to be a button.
             *      Although it is redundant good coding practice is to always check */
            if(sender is Button)
            {
                FrameworkElement switchToScreen;
                var orderControl = this.FindAncestor<OrderControl>();

                switch(((Button)sender).Name)
                {
                    case "EntreeButton":
                        switchToScreen = new EntreeSelectionScreen();
                        break;
                    
                    case "DrinksButton":
                        switchToScreen = new DrinkSelectionScreen();
                        break;

                    case "SidesButton":
                        switchToScreen = new SideSelectionScreen();
                        break;
                    
                    default:
                        throw new NotImplementedException("Unknown category selected");
                }
                orderControl?.SwapScreen(switchToScreen);
            }
        }

        /// <summary>
        /// Switches the screen to the combo selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CombosButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order o)
            {
                if (sender is Button)
                {
                    EbonyWarriorEntourage EWE = new EbonyWarriorEntourage();
                    ComboCustomizationScreen CCS = new ComboCustomizationScreen(EWE);
                    EWE.Screen = CCS;

                    BriarheartBurger BB = new BriarheartBurger();
                    BB.Screen = new EntreeCustomizationScreen(BB);
                    EWE.Entree = BB;

                    DragonbornWaffleFries DWF = new DragonbornWaffleFries();
                    DWF.Screen = new SideCustomizationScreen(DWF);
                    EWE.Side = DWF;

                    SailorSoda SS = new SailorSoda();
                    SS.Screen = new DrinkCustomizationScreen(SS);
                    EWE.Drink = SS;

                    o.AddItem = EWE;

                    var orderControl = this.FindAncestor<OrderControl>();
                    orderControl?.SwapScreen(CCS);

                    if (orderControl.NavigationTabBorder.Child is NavigationTab NavTab)
                    {
                        NavTab.EWEScreen = EWE.Screen;
                        NavTab.ReturnToItemSelectionScreenBorder.Visibility = Visibility.Hidden;
                        NavTab.ReturnToCurrentComboScreenBorder.Visibility = Visibility.Visible;
                    }
                    else throw new NotImplementedException("Should never be reached");
                }
            }
        }
    }
}