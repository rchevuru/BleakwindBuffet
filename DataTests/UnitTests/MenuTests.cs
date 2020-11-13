/*
 * Author: Zachery Brunner
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 * Modifier: Rana Chevuru 
 * Date Modified: 11/13/2020
 */
using Xunit;

using System;
using System.Collections.Generic;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void AllEntreesShouldBeReturnedByEntreeMethod()
        {
            int expectedLengthOfReturnedList = 7;

            bool includesBB = false;
            bool includesDD = false;
            bool includesGOO = false;
            bool includesPP = false;
            bool includesSS = false;
            bool includesTT = false;
            bool includesTTB = false;

            IEnumerable<IOrderItem> e = Menu.Entrees();
            List<IOrderItem> entrees = (List<IOrderItem>)e;

            /* Make sure the size of the list is what we expect */
            Assert.Equal(expectedLengthOfReturnedList, entrees.Count);

            /* Iterate through the list and make sure each entree is there */
            for (int i = 0; i < expectedLengthOfReturnedList; i++)
            {
                if (entrees[i] is BriarheartBurger) includesBB = true;

                else if (entrees[i] is DoubleDraugr) includesDD = true;

                else if (entrees[i] is GardenOrcOmelette) includesGOO = true;

                else if (entrees[i] is PhillyPoacher) includesPP = true;

                else if (entrees[i] is SmokehouseSkeleton) includesSS = true;

                else if (entrees[i] is ThalmorTriple) includesTT = true;

                else if (entrees[i] is ThugsTBone) includesTTB = true;

                else throw new NotImplementedException();
            }

            Assert.True(includesBB);
            Assert.True(includesDD);
            Assert.True(includesGOO);
            Assert.True(includesPP);
            Assert.True(includesSS);
            Assert.True(includesTT);
            Assert.True(includesTTB);
        }

        [Fact]
        public void AllDrinksShouldBeReturnedByDrinkMethodAllSizes()
        {
            /* Aretino Apple Juice */
            bool includesSmallAAJ = false;
            bool includesMedAAJ = false;
            bool includesLarAAJ = false;

            /* Candlehearth Coffee */
            bool includesSmallCC = false;
            bool includesMedCC = false;
            bool includesLarCC = false;

            /* Markarth Milk */
            bool includesSmallMM = false;
            bool includesMedMM = false;
            bool includesLarMM = false;

            /* Sailor Soda */
            bool includesSmallSS = false;
            bool includesMedSS = false;
            bool includesLarSS = false;

            /* Warrior Water */
            bool includesSmallWW = false;
            bool includesMedWW = false;
            bool includesLarWW = false;

            int numberOfItemsInSizeEnum = Enum.GetValues(typeof(Size)).Length;

            int numberOfDrinksAtBleakwindBuffet = 5;
            int expectedNumberOfItemsInDrinksList = numberOfDrinksAtBleakwindBuffet * numberOfItemsInSizeEnum;

            IEnumerable<IOrderItem> d = Menu.Drinks();
            List<IOrderItem> drinks = (List<IOrderItem>)d;

            Assert.Equal(expectedNumberOfItemsInDrinksList, drinks.Count);

            for (int i = 0; i < expectedNumberOfItemsInDrinksList; i++)
            {
                if (drinks[i] is AretinoAppleJuice)
                {
                    var AAJ = (AretinoAppleJuice)drinks[i];
                    if (AAJ.Size == Size.Small) includesSmallAAJ = true;
                    else if (AAJ.Size == Size.Medium) includesMedAAJ = true;
                    else if (AAJ.Size == Size.Large) includesLarAAJ = true;
                    else throw new NotImplementedException();
                }

                else if (drinks[i] is CandlehearthCoffee)
                {
                    var CC = (CandlehearthCoffee)drinks[i];
                    if (CC.Size == Size.Small) includesSmallCC = true;
                    else if (CC.Size == Size.Medium) includesMedCC = true;
                    else if (CC.Size == Size.Large) includesLarCC = true;
                    else throw new NotImplementedException();
                }

                else if (drinks[i] is MarkarthMilk)
                {
                    var MM = (MarkarthMilk)drinks[i];
                    if (MM.Size == Size.Small) includesSmallMM = true;
                    else if (MM.Size == Size.Medium) includesMedMM = true;
                    else if (MM.Size == Size.Large) includesLarMM = true;
                    else throw new NotImplementedException();
                }

                else if (drinks[i] is SailorSoda)
                {
                    var SS = (SailorSoda)drinks[i];
                    if (SS.Size == Size.Small) includesSmallSS = true;
                    else if (SS.Size == Size.Medium) includesMedSS = true;
                    else if (SS.Size == Size.Large) includesLarSS = true;
                    else throw new NotImplementedException();
                }

                else if (drinks[i] is WarriorWater)
                {
                    var WW = (WarriorWater)drinks[i];
                    if (WW.Size == Size.Small) includesSmallWW = true;
                    else if (WW.Size == Size.Medium) includesMedWW = true;
                    else if (WW.Size == Size.Large) includesLarWW = true;
                    else throw new NotImplementedException();
                }

                else throw new NotImplementedException();
            }

            /* Aretino Apple Juice */
            Assert.True(includesSmallAAJ);
            Assert.True(includesMedAAJ);
            Assert.True(includesLarAAJ);

            /* Candlehearth Coffee */
            Assert.True(includesSmallCC);
            Assert.True(includesMedCC);
            Assert.True(includesLarCC);

            /* Markarth Milk */
            Assert.True(includesSmallMM);
            Assert.True(includesMedMM);
            Assert.True(includesLarMM);

            /* Sailor Soda */
            Assert.True(includesSmallSS);
            Assert.True(includesMedSS);
            Assert.True(includesLarSS);

            /* Warrior Water */
            Assert.True(includesSmallWW);
            Assert.True(includesMedWW);
            Assert.True(includesLarWW);
        }

        [Fact]
        public void AllSidesShouldBeReturnedBySideMethodAllSizes()
        {
            /* Dragonborn Waffle Fries */
            bool includesSmallDW = false;
            bool includesMedDW = false;
            bool includesLarDW = false;

            /* FriedMiraak */
            bool includesSmallFM = false;
            bool includesMedFM = false;
            bool includesLarFM = false;

            /* Mad Otar Grits */
            bool includesSmallMOG = false;
            bool includesMedMOG = false;
            bool includesLarMOG = false;

            /* Vokun Salad */
            bool includesSmallVS = false;
            bool includesMedVS = false;
            bool includesLarVS = false;

            int numberOfItemsInSizeEnum = Enum.GetValues(typeof(Size)).Length;

            int numberOfDrinksAtBleakwindBuffet = 4;
            int expectedNumberOfItemsInDrinksList = numberOfDrinksAtBleakwindBuffet * numberOfItemsInSizeEnum;

            IEnumerable<IOrderItem> s = Menu.Sides();
            List<IOrderItem> sides = (List<IOrderItem>)s;

            Assert.Equal(expectedNumberOfItemsInDrinksList, sides.Count);

            for (int i = 0; i < expectedNumberOfItemsInDrinksList; i++)
            {
                if (sides[i] is DragonbornWaffleFries)
                {
                    var DWF = (DragonbornWaffleFries)sides[i];
                    if (DWF.Size == Size.Small) includesSmallDW = true;
                    else if (DWF.Size == Size.Medium) includesMedDW = true;
                    else if (DWF.Size == Size.Large) includesLarDW = true;
                    else throw new NotImplementedException();
                }

                else if (sides[i] is FriedMiraak)
                {
                    var FM = (FriedMiraak)sides[i];
                    if (FM.Size == Size.Small) includesSmallFM = true;
                    else if (FM.Size == Size.Medium) includesMedFM = true;
                    else if (FM.Size == Size.Large) includesLarFM = true;
                    else throw new NotImplementedException();
                }

                else if (sides[i] is MadOtarGrits)
                {
                    var MOG = (MadOtarGrits)sides[i];
                    if (MOG.Size == Size.Small) includesSmallMOG = true;
                    else if (MOG.Size == Size.Medium) includesMedMOG = true;
                    else if (MOG.Size == Size.Large) includesLarMOG = true;
                    else throw new NotImplementedException();
                }

                else if (sides[i] is VokunSalad)
                {
                    var VS = (VokunSalad)sides[i];
                    if (VS.Size == Size.Small) includesSmallVS = true;
                    else if (VS.Size == Size.Medium) includesMedVS = true;
                    else if (VS.Size == Size.Large) includesLarVS = true;
                    else throw new NotImplementedException();
                }

                else throw new NotImplementedException();
            }

            /* Dragonborn Waffle Fries */
            Assert.True(includesSmallDW);
            Assert.True(includesMedDW);
            Assert.True(includesLarDW);

            /* Fried Miraak */
            Assert.True(includesSmallFM);
            Assert.True(includesMedFM);
            Assert.True(includesLarFM);

            /* Mad Otar Grits */
            Assert.True(includesSmallMOG);
            Assert.True(includesMedMOG);
            Assert.True(includesLarMOG);

            /* Vokun Salad */
            Assert.True(includesSmallVS);
            Assert.True(includesMedVS);
            Assert.True(includesLarVS);
        }

        [Fact]
        public void FullMenuMethodShouldHaveAllItemsOnMenu()
        {
            int numberOfItemsInSizeEnum = Enum.GetValues(typeof(Size)).Length;

            int expectedNumberOfEntrees = 7;
            int expectedNumberOfSides = 4;
            int expectedNumberOfDrinks = 5;

            int expectedNumberOfMenuItems = (expectedNumberOfSides * numberOfItemsInSizeEnum) + (expectedNumberOfDrinks * numberOfItemsInSizeEnum) + expectedNumberOfEntrees;

            IEnumerable<IOrderItem> FM = Menu.FullMenu();
            List<IOrderItem> fullMenu = (List<IOrderItem>)FM;

            Assert.Equal(fullMenu.Count, expectedNumberOfMenuItems);
        }

        [Fact]
        public void ShouldReturnFullMenuWhenItsAll()
        {
            FullMenuMethodShouldHaveAllItemsOnMenu();
        }

        [Fact]
        public void ShouldReturnTheCorrectTypes()
        {
           
        }
    }
}