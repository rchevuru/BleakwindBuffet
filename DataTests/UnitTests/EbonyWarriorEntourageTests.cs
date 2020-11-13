/*
 * Author: Zachery Brunner
 * Class: EbonyWarriorEntourage.cs
 * Purpose: Test the EbonyWarriorEntourage.cs class in the Data library
 * Modifier: Rana Chevuru
 * Date Modified: 11/13/2020
 */
using Xunit;

using System.ComponentModel;
using System.Collections.Generic;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;

namespace DataTests.UnitTests
{
    public class EbonyWarriorEntourageTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var EWE = new EbonyWarriorEntourage();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(EWE);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            string expectedName = "Ebony Warrior Entourage";
            var EWE = new EbonyWarriorEntourage();

            Assert.Equal(expectedName, EWE.Name);
        }

        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            string expectedDescription = "A combo meal with any side, drink, and entree.";
            var EWE = new EbonyWarriorEntourage();

            Assert.Equal(expectedDescription, EWE.Description); 
        }

        [Fact]
        public void ShouldReturnCorrectToStringName()
        {
            string expectedName = "Ebony Warrior Entourage";
            var EWE = new EbonyWarriorEntourage();

            Assert.Equal(expectedName, EWE.ToStringName);
        }

        [Fact]
        public void ShouldBeAbleToSetEntree()
        {
            var EWE = new EbonyWarriorEntourage();
            var entree = new BriarheartBurger();

            EWE.Entree = entree;
            Assert.Equal(entree, EWE.Entree);
        }

        [Fact]
        public void SettingEntreeShouldNotifyEntreeProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var entree = new BriarheartBurger();

            Assert.PropertyChanged(EWE, "Entree", () =>
            {
                EWE.Entree = entree;
            });
        }

        [Fact]
        public void SettingEntreeShouldNotifyCaloriesProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var entree = new BriarheartBurger();

            Assert.PropertyChanged(EWE, "Calories", () =>
            {
                EWE.Entree = entree;
            });
        }

        [Fact]
        public void SettingEntreeShouldNotifyEntreeNameProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var entree = new BriarheartBurger();

            Assert.PropertyChanged(EWE, "EntreeName", () =>
            {
                EWE.Entree = entree;
            });
        }

        [Fact]
        public void SettingEntreeShouldNotifySpecialInstructionsProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var entree = new BriarheartBurger();

            Assert.PropertyChanged(EWE, "SpecialInstructions", () =>
            {
                EWE.Entree = entree;
            });
        }

        [Fact]
        public void EntreeNameShouldReturnNameOfEntree()
        {
            var EWE = new EbonyWarriorEntourage();
            var entree = new BriarheartBurger();

            EWE.Entree = entree;
            Assert.Equal(entree.Name, EWE.EntreeName);
        }

        [Fact]
        public void ShouldBeAbleToSetSide()
        {
            var EWE = new EbonyWarriorEntourage();
            var side = new VokunSalad();

            EWE.Side = side;
            Assert.Equal(side, EWE.Side);
        }

        [Fact]
        public void SettingSideShouldNotifySideProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var side = new VokunSalad();

            Assert.PropertyChanged(EWE, "Side", () =>
            {
                EWE.Side = side;
            });
        }

        [Fact]
        public void SettingSideShouldNotifyCaloriesProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var side = new VokunSalad();

            Assert.PropertyChanged(EWE, "Calories", () =>
            {
                EWE.Side = side;
            });
        }

        [Fact]
        public void SettingSideShouldNotifySideNameProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var side = new VokunSalad();

            Assert.PropertyChanged(EWE, "SideName", () =>
            {
                EWE.Side = side;
            });
        }

        [Fact]
        public void SettingSideShouldNotifySpecialInstructionsProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var side = new VokunSalad();

            Assert.PropertyChanged(EWE, "SpecialInstructions", () =>
            {
                EWE.Side = side;
            });
        }

        [Fact]
        public void SideNameShouldReturnNameOfSide()
        {
            var EWE = new EbonyWarriorEntourage();
            var side = new VokunSalad();

            EWE.Side = side;
            Assert.Equal(side.Name, EWE.SideName);
        }

        [Fact]
        public void ShouldBeAbleToSetDrink()
        {
            var EWE = new EbonyWarriorEntourage();
            var drink = new WarriorWater();

            EWE.Drink = drink;
            Assert.Equal(drink, EWE.Drink);
        }

        [Fact]
        public void SettingDrinkShouldNotifyDrinkProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var drink = new WarriorWater();

            Assert.PropertyChanged(EWE, "Drink", () =>
            {
                EWE.Drink = drink;
            });
        }

        [Fact]
        public void SettingDrinkShouldNotifyCaloriesProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var drink = new WarriorWater();

            Assert.PropertyChanged(EWE, "Calories", () =>
            {
                EWE.Drink = drink;
            });
        }

        [Fact]
        public void SettingDrinkShouldNotifyDrinkNameProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var drink = new WarriorWater();

            Assert.PropertyChanged(EWE, "DrinkName", () =>
            {
                EWE.Drink = drink;
            });
        }

        [Fact]
        public void SettingDrinkShouldNotifySpecialInstructionsProperties()
        {
            var EWE = new EbonyWarriorEntourage();
            var drink = new WarriorWater();

            Assert.PropertyChanged(EWE, "SpecialInstructions", () =>
            {
                EWE.Drink = drink;
            });
        }

        [Fact]
        public void DrinkNameShouldReturnNameOfDrink()
        {
            var EWE = new EbonyWarriorEntourage();
            var drink = new WarriorWater();

            EWE.Drink = drink;
            Assert.Equal(drink.Name, EWE.DrinkName);
        }

        [Fact]
        public void ShouldBeAbleToSetScreen()
        {
            var EWE = new EbonyWarriorEntourage();
            object o = new object();

            EWE.Screen = o;
            Assert.Equal(o, EWE.Screen);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var EWE = new EbonyWarriorEntourage();
            double expectedPrice = 10.00;

            Assert.Equal(expectedPrice, EWE.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var EWE = new EbonyWarriorEntourage();
            Entree e = new BriarheartBurger();
            Side s = new VokunSalad();
            Drink d = new WarriorWater();

            EWE.Entree = e;
            EWE.Side = s;
            EWE.Drink = d;

            uint expectedCalories = e.Calories + s.Calories + d.Calories;

            Assert.Equal(expectedCalories, EWE.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var EWE = new EbonyWarriorEntourage();
            Entree e = new BriarheartBurger();
            Side s = new VokunSalad();
            Drink d = new WarriorWater();

            List<string> expectedSpecialInstructions = new List<string>();
            expectedSpecialInstructions.Add(e.ToString());
            expectedSpecialInstructions.AddRange(e.SpecialInstructions);
            expectedSpecialInstructions.Add(s.ToString());
            expectedSpecialInstructions.AddRange(s.SpecialInstructions);
            expectedSpecialInstructions.Add(d.ToString());
            expectedSpecialInstructions.AddRange(d.SpecialInstructions);

            EWE.Entree = e;
            EWE.Side = s;
            EWE.Drink = d;

            foreach(string str in EWE.SpecialInstructions)
            {
                Assert.Contains(str, expectedSpecialInstructions);
            }
        }
    }
}