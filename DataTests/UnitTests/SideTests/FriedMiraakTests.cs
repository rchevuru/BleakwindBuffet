/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;
using System.Collections.Generic;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var FM = new FriedMiraak();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(FM);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var FM = new FriedMiraak();

            Assert.PropertyChanged(FM, "Price", () =>
            {
                FM.Size = Size.Medium;
            });

            Assert.PropertyChanged(FM, "Price", () =>
            {
                FM.Size = Size.Large;
            });

            Assert.PropertyChanged(FM, "Price", () =>
            {
                FM.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var FM = new FriedMiraak();

            Assert.PropertyChanged(FM, "Calories", () =>
            {
                FM.Size = Size.Medium;
            });

            Assert.PropertyChanged(FM, "Calories", () =>
            {
                FM.Size = Size.Large;
            });

            Assert.PropertyChanged(FM, "Calories", () =>
            {
                FM.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            var FM = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(FM);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var FM = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(FM);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var FM = new FriedMiraak();
            Assert.Equal(Size.Small, FM.Size);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var FM = new FriedMiraak();
            Assert.Equal("Fried Miraak", FM.Name);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var FM = new FriedMiraak();
            FM.Size = Size.Small;
            Assert.Equal(Size.Small, FM.Size);
            FM.Size = Size.Medium;
            Assert.Equal(Size.Medium, FM.Size);
            FM.Size = Size.Large;
            Assert.Equal(Size.Large, FM.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            int expectedLengthOfReturnedList = 1;
            string expectedStringInList = "No special instructions";

            var FM = new FriedMiraak();

            List<string> ls = FM.SpecialInstructions;
            Assert.Equal(expectedLengthOfReturnedList, ls.Count);
            Assert.Contains(expectedStringInList, ls);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var FM = new FriedMiraak()
            {
                Size = size
            };
            Assert.Equal(price, FM.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var FM = new FriedMiraak()
            {
                Size = size
            };
            Assert.Equal(calories, FM.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectToStringNameBasedOnSize(Size size)
        {
            var FM = new FriedMiraak()
            {
                Size = size
            };

            if (size == Size.Small) Assert.Equal("Small Fried Miraak", FM.ToStringName);
            if (size == Size.Medium) Assert.Equal("Medium Fried Miraak", FM.ToStringName);
            if (size == Size.Large) Assert.Equal("Large Fried Miraak", FM.ToStringName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectNameBasedOnSize(Size size)
        {
            var FM = new FriedMiraak()
            {
                Size = size
            };

            if (size == Size.Small) Assert.Equal("Small Fried Miraak", FM.ToString());
            if (size == Size.Medium) Assert.Equal("Medium Fried Miraak", FM.ToString());
            if (size == Size.Large) Assert.Equal("Large Fried Miraak", FM.ToString());
        }
    }
}