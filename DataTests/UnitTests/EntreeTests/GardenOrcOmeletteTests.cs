/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var GOO = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(GOO);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var GOO = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(GOO);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var GOO = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(GOO);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            var GOO = new GardenOrcOmelette();
            GOO.Broccoli = false;
            Assert.False(GOO.Broccoli);
            GOO.Broccoli = true;
            Assert.True(GOO.Broccoli);
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var GOO = new GardenOrcOmelette();

            Assert.PropertyChanged(GOO, "Broccoli", () =>
            {
                GOO.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingBroccoliNotifiesSpecialInstructionsProperty()
        {
            var GOO = new GardenOrcOmelette();

            Assert.PropertyChanged(GOO, "SpecialInstructions", () =>
            {
                GOO.Broccoli = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            var GOO = new GardenOrcOmelette();
            GOO.Mushrooms = false;
            Assert.False(GOO.Mushrooms);
            GOO.Mushrooms = true;
            Assert.True(GOO.Mushrooms);
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var GOO = new GardenOrcOmelette();

            Assert.PropertyChanged(GOO, "Mushrooms", () =>
            {
                GOO.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesSpecialInstructionsProperty()
        {
            var GOO = new GardenOrcOmelette();

            Assert.PropertyChanged(GOO, "SpecialInstructions", () =>
            {
                GOO.Mushrooms = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var GOO = new GardenOrcOmelette();
            GOO.Tomato = false;
            Assert.False(GOO.Tomato);
            GOO.Tomato = true;
            Assert.True(GOO.Tomato);
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var GOO = new GardenOrcOmelette();

            Assert.PropertyChanged(GOO, "Tomato", () =>
            {
                GOO.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var GOO = new GardenOrcOmelette();

            Assert.PropertyChanged(GOO, "SpecialInstructions", () =>
            {
                GOO.Tomato = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            var GOO = new GardenOrcOmelette();
            GOO.Cheddar = false;
            Assert.False(GOO.Cheddar);
            GOO.Cheddar = true;
            Assert.True(GOO.Cheddar);
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var GOO = new GardenOrcOmelette();

            Assert.PropertyChanged(GOO, "Cheddar", () =>
            {
                GOO.Cheddar = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesSpecialInstructionsProperty()
        {
            var GOO = new GardenOrcOmelette();

            Assert.PropertyChanged(GOO, "SpecialInstructions", () =>
            {
                GOO.Cheddar = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            double expectedPrice = 4.57;
            var GOO = new GardenOrcOmelette();
            Assert.Equal(expectedPrice, GOO.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint expectedCal = 404;
            var GOO = new GardenOrcOmelette();
            Assert.Equal(expectedCal, GOO.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var GOO = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };
            if (!includeBroccoli) Assert.Contains("Hold broccoli", GOO.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", GOO.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", GOO.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", GOO.SpecialInstructions);

            if(includeBroccoli && includeMushrooms && includeTomato && includeCheddar) Assert.Contains("No special instructions", GOO.SpecialInstructions);
        }

        [Fact]
        public void ToStringNameShouldReturnCorrectName()
        {
            var GOO = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", GOO.ToStringName);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var GOO = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", GOO.ToString());
        }
    }
}