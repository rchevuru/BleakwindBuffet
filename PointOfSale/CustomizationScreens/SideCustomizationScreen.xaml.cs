/*
 * Author: Zachery Brunner
 * Class: SideCustomizationScreen.xaml.cs
 * Purpose: Backend logic for the SideCustomizationScreen
 */
using System.Windows.Controls;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for SideCustomizationScreen.xaml
    /// </summary>
    public partial class SideCustomizationScreen : UserControl
    {
        /// <summary>
        /// Constructor for the class
        /// </summary>
        public SideCustomizationScreen(object DataContext)
        {
            InitializeComponent();
            this.DataContext = DataContext;
        }
    }
}