/*
 * Author: Zachery Brunner
 * Class: ComboCustomizationScreen.xaml.cs
 * Purpose: Provide logic for the combo customization screen
 */
using System;
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;

using PointOfSale.ExtensionMethod;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for ComboCustomizationScreen.xaml
    /// </summary>
    public partial class ComboCustomizationScreen : UserControl
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public ComboCustomizationScreen(object DataContext)
        {
            InitializeComponent();
            this.DataContext = DataContext;
        }

        /// <summary>
        /// Switches the views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeEntreeButton_Click(object sender, RoutedEventArgs e)
        {
            EntreeButtonsAndInformationBorder.Visibility = Visibility.Hidden;
            ChooseEntreeBorder.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Pulls up the customization screen to change the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditEntreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is EbonyWarriorEntourage EWE)
            {
                if (sender is Button)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    orderControl?.SwapScreen((FrameworkElement)EWE.Entree.Screen);
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Changes the selected entree for the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeEntreeSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is EbonyWarriorEntourage EWE)
            {
                if (sender is Button b)
                {
                    Entree entree;
                    EntreeCustomizationScreen ECS;
                    switch (b.Name)
                    {
                        case "BriarheartBurgerEntreeButton":
                            entree = new BriarheartBurger();
                            break;

                        case "DoubleDraugrEntreeButton":
                            entree = new DoubleDraugr();
                            break;

                        case "ThalmorTripleEntreeButton":
                            entree = new ThalmorTriple();
                            break;

                        case "GardenOrcOmeletteEntreeButton":
                            entree = new GardenOrcOmelette();
                            break;

                        case "PhillyPoacherEntreeButton":
                            entree = new PhillyPoacher();
                            break;

                        case "SmokehouseSkeletonEntreeButton":
                            entree = new SmokehouseSkeleton();
                            break;
                        
                        case "ThugsTBoneEntreeButton":
                            entree = new ThugsTBone();
                            break;

                        default:
                            throw new NotImplementedException("Should never be reached");
                    }
                    ECS = new EntreeCustomizationScreen(entree);
                    entree.Screen = ECS;
                    EWE.Entree = entree;
                    EntreeButtonsAndInformationBorder.Visibility = Visibility.Visible;
                    ChooseEntreeBorder.Visibility = Visibility.Hidden;
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Switches the views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSideButton_Click(object sender, RoutedEventArgs e)
        {
            SideButtonsAndInformationBorder.Visibility = Visibility.Hidden;
            ChooseSideBorder.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Pulls up the customization screen to change the side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditSideButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is EbonyWarriorEntourage EWE)
            {
                if (sender is Button)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    orderControl?.SwapScreen((FrameworkElement)EWE.Side.Screen);
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Changes the selected side for the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSideSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is EbonyWarriorEntourage EWE)
            {
                if (sender is Button b)
                {
                    Side side;
                    SideCustomizationScreen SCS;
                    switch (b.Name)
                    {
                        case "DragonbornWaffleFriesSideButton":
                            side = new DragonbornWaffleFries();
                            break;

                        case "FriedMiraakSideButton":
                            side = new FriedMiraak();
                            break;

                        case "MadOtarGritsSideButton":
                            side = new MadOtarGrits();
                            break;

                        case "VokunSaladSideButton":
                            side = new VokunSalad();
                            break;

                        default:
                            throw new NotImplementedException("Should never be reached");
                    }
                    SCS = new SideCustomizationScreen(side);
                    side.Screen = SCS;
                    EWE.Side = side;
                    SideButtonsAndInformationBorder.Visibility = Visibility.Visible;
                    ChooseSideBorder.Visibility = Visibility.Hidden;
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Switches the views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            DrinkButtonsAndInformationBorder.Visibility = Visibility.Hidden;
            ChooseDrinkBorder.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Pulls up the customization screen to change the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is EbonyWarriorEntourage EWE)
            {
                if (sender is Button)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    orderControl?.SwapScreen((FrameworkElement)EWE.Drink.Screen);
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Changes the selected drink for the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDrinkSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is EbonyWarriorEntourage EWE)
            {
                if (sender is Button b)
                {
                    Drink drink;
                    DrinkCustomizationScreen DCS;
                    switch (b.Name)
                    {
                        case "AretinoAppleJuiceDrinkButton":
                            drink = new AretinoAppleJuice();
                            break;

                        case "CandlehearthCoffeeDrinkButton":
                            drink = new CandlehearthCoffee();
                            break;

                        case "MarkarthMilkDrinkButton":
                            drink = new MarkarthMilk();
                            break;

                        case "SailorSodaDrinkButton":
                            drink = new SailorSoda();
                            break;

                        case "WarriorWaterDrinkButton":
                            drink = new WarriorWater();
                            break;

                        default:
                            throw new NotImplementedException("Should never be reached");
                    }
                    DCS = new DrinkCustomizationScreen(drink);
                    drink.Screen = DCS;
                    EWE.Drink = drink;
                    DrinkButtonsAndInformationBorder.Visibility = Visibility.Visible;
                    ChooseDrinkBorder.Visibility = Visibility.Hidden;
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Returns to the menu item selection screen and returns the Navigation tab back to original configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishedCustomizingComboButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is EbonyWarriorEntourage)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if(orderControl.NavigationTabBorder.Child is NavigationTab NavTab)
                {
                    NavTab.ReturnToItemSelectionScreenBorder.Visibility = Visibility.Visible;
                    NavTab.ReturnToCurrentComboScreenBorder.Visibility = Visibility.Hidden;
                    orderControl?.SwapScreen(new MenuCategorySelectionControl());
                    //EWE.InvokePropertyChanged();
                }
                else throw new NotImplementedException("Should never be reached");
            }
            else throw new NotImplementedException("Should never be reached");
        }
    }
}