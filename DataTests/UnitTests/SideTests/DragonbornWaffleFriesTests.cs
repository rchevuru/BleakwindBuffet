/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;
using System.Collections.Generic;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(DWF);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var DWF = new DragonbornWaffleFries();

            Assert.PropertyChanged(DWF, "Price", () =>
            {
                DWF.Size = Size.Medium;
            });

            Assert.PropertyChanged(DWF, "Price", () =>
            {
                DWF.Size = Size.Large;
            });

            Assert.PropertyChanged(DWF, "Price", () =>
            {
                DWF.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var DWF = new DragonbornWaffleFries();

            Assert.PropertyChanged(DWF, "Calories", () =>
            {
                DWF.Size = Size.Medium;
            });

            Assert.PropertyChanged(DWF, "Calories", () =>
            {
                DWF.Size = Size.Large;
            });

            Assert.PropertyChanged(DWF, "Calories", () =>
            {
                DWF.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(DWF);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(DWF);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, DWF.Size);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.Equal("Dragonborn Waffle Fries", DWF.Name);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var DWF = new DragonbornWaffleFries();
            DWF.Size = Size.Small;
            Assert.Equal(Size.Small, DWF.Size);
            DWF.Size = Size.Medium;
            Assert.Equal(Size.Medium, DWF.Size);
            DWF.Size = Size.Large;
            Assert.Equal(Size.Large, DWF.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            int expectedLengthOfReturnedList = 1;
            string expectedStringInList = "No special instructions";

            var DWF = new DragonbornWaffleFries();
            
            List<string> ls = DWF.SpecialInstructions;
            Assert.Equal(expectedLengthOfReturnedList, ls.Count);
            Assert.Contains(expectedStringInList, ls);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var DWF = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(price, DWF.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var DWF = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(calories, DWF.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectToStringNameBasedOnSize(Size size)
        {
            var DWF = new DragonbornWaffleFries()
            {
                Size = size
            };

            if (size == Size.Small) Assert.Equal("Small Dragonborn Waffle Fries", DWF.ToStringName);
            if (size == Size.Medium) Assert.Equal("Medium Dragonborn Waffle Fries", DWF.ToStringName);
            if (size == Size.Large) Assert.Equal("Large Dragonborn Waffle Fries", DWF.ToStringName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectNameBasedOnSize(Size size)
        {
            var DWF = new DragonbornWaffleFries()
            {
                Size = size
            };

            if (size == Size.Small) Assert.Equal("Small Dragonborn Waffle Fries", DWF.ToString());
            if (size == Size.Medium) Assert.Equal("Medium Dragonborn Waffle Fries", DWF.ToString());
            if (size == Size.Large) Assert.Equal("Large Dragonborn Waffle Fries", DWF.ToString());
        }
    }
}