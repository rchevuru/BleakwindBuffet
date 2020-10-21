/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;
using System.Collections.Generic;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var MOG = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(MOG);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var MOG = new MadOtarGrits();

            Assert.PropertyChanged(MOG, "Price", () =>
            {
                MOG.Size = Size.Medium;
            });

            Assert.PropertyChanged(MOG, "Price", () =>
            {
                MOG.Size = Size.Large;
            });

            Assert.PropertyChanged(MOG, "Price", () =>
            {
                MOG.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var MOG = new MadOtarGrits();

            Assert.PropertyChanged(MOG, "Calories", () =>
            {
                MOG.Size = Size.Medium;
            });

            Assert.PropertyChanged(MOG, "Calories", () =>
            {
                MOG.Size = Size.Large;
            });

            Assert.PropertyChanged(MOG, "Calories", () =>
            {
                MOG.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            var MOG = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(MOG);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var MOG = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(MOG);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var MOG = new MadOtarGrits();
            Assert.Equal(Size.Small, MOG.Size);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var MOG = new MadOtarGrits();
            Assert.Equal("Mad Otar Grits", MOG.Name);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var MOG = new MadOtarGrits();
            MOG.Size = Size.Small;
            Assert.Equal(Size.Small, MOG.Size);
            MOG.Size = Size.Medium;
            Assert.Equal(Size.Medium, MOG.Size);
            MOG.Size = Size.Large;
            Assert.Equal(Size.Large, MOG.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            int expectedLengthOfReturnedList = 1;
            string expectedStringInList = "No special instructions";

            var MOG = new MadOtarGrits();

            List<string> ls = MOG.SpecialInstructions;
            Assert.Equal(expectedLengthOfReturnedList, ls.Count);
            Assert.Contains(expectedStringInList, ls);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var MOG = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(price, MOG.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var MOG = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(calories, MOG.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectToStringNameBasedOnSize(Size size)
        {
            var MOG = new MadOtarGrits()
            {
                Size = size
            };

            if (size == Size.Small) Assert.Equal("Small Mad Otar Grits", MOG.ToStringName);
            if (size == Size.Medium) Assert.Equal("Medium Mad Otar Grits", MOG.ToStringName);
            if (size == Size.Large) Assert.Equal("Large Mad Otar Grits", MOG.ToStringName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectNameBasedOnSize(Size size)
        {
            var MOG = new MadOtarGrits()
            {
                Size = size
            };

            if (size == Size.Small) Assert.Equal("Small Mad Otar Grits", MOG.ToString());
            if (size == Size.Medium) Assert.Equal("Medium Mad Otar Grits", MOG.ToString());
            if (size == Size.Large) Assert.Equal("Large Mad Otar Grits", MOG.ToString());
        }
    }
}