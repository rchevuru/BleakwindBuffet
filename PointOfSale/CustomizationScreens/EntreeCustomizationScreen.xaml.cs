/*
 * Author: Zachery Brunner
 * Class: EntreeCustomizationScreen.xaml.cs
 * Purpose: Backend logic for the EntreeCustomizationScreen
 */
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data.Entrees;

namespace PointOfSale.CustomizationScreens
{
    /// <summary>
    /// Interaction logic for EntreeCustomizationScreen.xaml
    /// </summary>
    public partial class EntreeCustomizationScreen : UserControl
    {
        public EntreeCustomizationScreen(object DataContext)
        {
            InitializeComponent();
            this.DataContext = DataContext;
            if (DataContext is BriarheartBurger) BriarheartBurgerSetup();
            else if (DataContext is DoubleDraugr) DoubleDraugrSetup();
            else if (DataContext is ThalmorTriple) ThalmorTripleSetup();
            else if (DataContext is GardenOrcOmelette) GardenOrcOmeletteSetup();
            else if (DataContext is PhillyPoacher) PhillyPoacherSetup();
            else if (DataContext is SmokehouseSkeleton) SmokehouseSkeletonSetup();
            else if (DataContext is ThugsTBone) ThugsTBoneSetup();
        }

        private void BriarheartBurgerSetup()
        {
            BunCheckBox.Visibility = Visibility.Visible;
            KetchupCheckBox.Visibility = Visibility.Visible;
            MustardCheckBox.Visibility = Visibility.Visible;
            PickleCheckBox.Visibility = Visibility.Visible;
            CheeseCheckBox.Visibility = Visibility.Visible;
            TomatoCheckBox.Visibility = Visibility.Collapsed;
            LettuceCheckBox.Visibility = Visibility.Collapsed;
            MayoCheckBox.Visibility = Visibility.Collapsed;
            BaconCheckBox.Visibility = Visibility.Collapsed;
            EggCheckBox.Visibility = Visibility.Collapsed;
            BroccoliCheckBox.Visibility = Visibility.Collapsed;
            MushroomsCheckBox.Visibility = Visibility.Collapsed;
            CheddarCheckBox.Visibility = Visibility.Collapsed;
            SirloinCheckBox.Visibility = Visibility.Collapsed;
            OnionCheckBox.Visibility = Visibility.Collapsed;
            RollCheckBox.Visibility = Visibility.Collapsed;
            SausageLinkCheckBox.Visibility = Visibility.Collapsed;
            HashBrownsCheckBox.Visibility = Visibility.Collapsed;
            PancakeCheckBox.Visibility = Visibility.Collapsed;
        }

        private void DoubleDraugrSetup()
        {
            BunCheckBox.Visibility = Visibility.Visible;
            KetchupCheckBox.Visibility = Visibility.Visible;
            MustardCheckBox.Visibility = Visibility.Visible;
            PickleCheckBox.Visibility = Visibility.Visible;
            CheeseCheckBox.Visibility = Visibility.Visible;
            TomatoCheckBox.Visibility = Visibility.Visible;
            LettuceCheckBox.Visibility = Visibility.Visible;
            MayoCheckBox.Visibility = Visibility.Visible;
            BaconCheckBox.Visibility = Visibility.Collapsed;
            EggCheckBox.Visibility = Visibility.Collapsed;
            BroccoliCheckBox.Visibility = Visibility.Collapsed;
            MushroomsCheckBox.Visibility = Visibility.Collapsed;
            CheddarCheckBox.Visibility = Visibility.Collapsed;
            SirloinCheckBox.Visibility = Visibility.Collapsed;
            OnionCheckBox.Visibility = Visibility.Collapsed;
            RollCheckBox.Visibility = Visibility.Collapsed;
            SausageLinkCheckBox.Visibility = Visibility.Collapsed;
            HashBrownsCheckBox.Visibility = Visibility.Collapsed;
            PancakeCheckBox.Visibility = Visibility.Collapsed;
        }

        private void ThalmorTripleSetup()
        {
            BunCheckBox.Visibility = Visibility.Visible;
            KetchupCheckBox.Visibility = Visibility.Visible;
            MustardCheckBox.Visibility = Visibility.Visible;
            PickleCheckBox.Visibility = Visibility.Visible;
            CheeseCheckBox.Visibility = Visibility.Visible;
            TomatoCheckBox.Visibility = Visibility.Visible;
            LettuceCheckBox.Visibility = Visibility.Visible;
            MayoCheckBox.Visibility = Visibility.Visible;
            BaconCheckBox.Visibility = Visibility.Visible;
            EggCheckBox.Visibility = Visibility.Visible;
            BroccoliCheckBox.Visibility = Visibility.Collapsed;
            MushroomsCheckBox.Visibility = Visibility.Collapsed;
            CheddarCheckBox.Visibility = Visibility.Collapsed;
            SirloinCheckBox.Visibility = Visibility.Collapsed;
            OnionCheckBox.Visibility = Visibility.Collapsed;
            RollCheckBox.Visibility = Visibility.Collapsed;
            SausageLinkCheckBox.Visibility = Visibility.Collapsed;
            HashBrownsCheckBox.Visibility = Visibility.Collapsed;
            PancakeCheckBox.Visibility = Visibility.Collapsed;
        }
        
        private void GardenOrcOmeletteSetup()
        {
            BunCheckBox.Visibility = Visibility.Collapsed;
            KetchupCheckBox.Visibility = Visibility.Collapsed;
            MustardCheckBox.Visibility = Visibility.Collapsed;
            PickleCheckBox.Visibility = Visibility.Collapsed;
            CheeseCheckBox.Visibility = Visibility.Collapsed;
            TomatoCheckBox.Visibility = Visibility.Visible;
            LettuceCheckBox.Visibility = Visibility.Collapsed;
            MayoCheckBox.Visibility = Visibility.Collapsed;
            BaconCheckBox.Visibility = Visibility.Collapsed;
            EggCheckBox.Visibility = Visibility.Collapsed;
            BroccoliCheckBox.Visibility = Visibility.Visible;
            MushroomsCheckBox.Visibility = Visibility.Visible;
            CheddarCheckBox.Visibility = Visibility.Visible;
            SirloinCheckBox.Visibility = Visibility.Collapsed;
            OnionCheckBox.Visibility = Visibility.Collapsed;
            RollCheckBox.Visibility = Visibility.Collapsed;
            SausageLinkCheckBox.Visibility = Visibility.Collapsed;
            HashBrownsCheckBox.Visibility = Visibility.Collapsed;
            PancakeCheckBox.Visibility = Visibility.Collapsed;
        }

        private void PhillyPoacherSetup()
        {
            BunCheckBox.Visibility = Visibility.Collapsed;
            KetchupCheckBox.Visibility = Visibility.Collapsed;
            MustardCheckBox.Visibility = Visibility.Collapsed;
            PickleCheckBox.Visibility = Visibility.Collapsed;
            CheeseCheckBox.Visibility = Visibility.Collapsed;
            TomatoCheckBox.Visibility = Visibility.Collapsed;
            LettuceCheckBox.Visibility = Visibility.Collapsed;
            MayoCheckBox.Visibility = Visibility.Collapsed;
            BaconCheckBox.Visibility = Visibility.Collapsed;
            EggCheckBox.Visibility = Visibility.Collapsed;
            BroccoliCheckBox.Visibility = Visibility.Collapsed;
            MushroomsCheckBox.Visibility = Visibility.Collapsed;
            CheddarCheckBox.Visibility = Visibility.Collapsed;
            SirloinCheckBox.Visibility = Visibility.Visible;
            OnionCheckBox.Visibility = Visibility.Visible;
            RollCheckBox.Visibility = Visibility.Visible;
            SausageLinkCheckBox.Visibility = Visibility.Collapsed;
            HashBrownsCheckBox.Visibility = Visibility.Collapsed;
            PancakeCheckBox.Visibility = Visibility.Collapsed;
        }

        private void SmokehouseSkeletonSetup()
        {
            BunCheckBox.Visibility = Visibility.Collapsed;
            KetchupCheckBox.Visibility = Visibility.Collapsed;
            MustardCheckBox.Visibility = Visibility.Collapsed;
            PickleCheckBox.Visibility = Visibility.Collapsed;
            CheeseCheckBox.Visibility = Visibility.Collapsed;
            TomatoCheckBox.Visibility = Visibility.Collapsed;
            LettuceCheckBox.Visibility = Visibility.Collapsed;
            MayoCheckBox.Visibility = Visibility.Collapsed;
            BaconCheckBox.Visibility = Visibility.Collapsed;
            EggCheckBox.Visibility = Visibility.Visible;
            BroccoliCheckBox.Visibility = Visibility.Collapsed;
            MushroomsCheckBox.Visibility = Visibility.Collapsed;
            CheddarCheckBox.Visibility = Visibility.Collapsed;
            SirloinCheckBox.Visibility = Visibility.Collapsed;
            OnionCheckBox.Visibility = Visibility.Collapsed;
            RollCheckBox.Visibility = Visibility.Collapsed;
            SausageLinkCheckBox.Visibility = Visibility.Visible;
            HashBrownsCheckBox.Visibility = Visibility.Visible;
            PancakeCheckBox.Visibility = Visibility.Visible;
        }

        private void ThugsTBoneSetup()
        {
            BunCheckBox.Visibility = Visibility.Collapsed;
            KetchupCheckBox.Visibility = Visibility.Collapsed;
            MustardCheckBox.Visibility = Visibility.Collapsed;
            PickleCheckBox.Visibility = Visibility.Collapsed;
            CheeseCheckBox.Visibility = Visibility.Collapsed;
            TomatoCheckBox.Visibility = Visibility.Collapsed;
            LettuceCheckBox.Visibility = Visibility.Collapsed;
            MayoCheckBox.Visibility = Visibility.Collapsed;
            BaconCheckBox.Visibility = Visibility.Collapsed;
            EggCheckBox.Visibility = Visibility.Collapsed;
            BroccoliCheckBox.Visibility = Visibility.Collapsed;
            MushroomsCheckBox.Visibility = Visibility.Collapsed;
            CheddarCheckBox.Visibility = Visibility.Collapsed;
            SirloinCheckBox.Visibility = Visibility.Collapsed;
            OnionCheckBox.Visibility = Visibility.Collapsed;
            RollCheckBox.Visibility = Visibility.Collapsed;
            SausageLinkCheckBox.Visibility = Visibility.Collapsed;
            HashBrownsCheckBox.Visibility = Visibility.Collapsed;
            PancakeCheckBox.Visibility = Visibility.Collapsed;
        }
    }
}