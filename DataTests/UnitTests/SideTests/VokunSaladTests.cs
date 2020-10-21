/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;
using System.Collections.Generic;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var VS = new VokunSalad();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(VS);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var VS = new VokunSalad();

            Assert.PropertyChanged(VS, "Price", () =>
            {
                VS.Size = Size.Medium;
            });

            Assert.PropertyChanged(VS, "Price", () =>
            {
                VS.Size = Size.Large;
            });

            Assert.PropertyChanged(VS, "Price", () =>
            {
                VS.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var VS = new VokunSalad();

            Assert.PropertyChanged(VS, "Calories", () =>
            {
                VS.Size = Size.Medium;
            });

            Assert.PropertyChanged(VS, "Calories", () =>
            {
                VS.Size = Size.Large;
            });

            Assert.PropertyChanged(VS, "Calories", () =>
            {
                VS.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            var VS = new VokunSalad();
            Assert.IsAssignableFrom<Side>(VS);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var VS = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(VS);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var VS = new VokunSalad();
            Assert.Equal(Size.Small, VS.Size);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var VS = new VokunSalad();
            Assert.Equal("Vokun Salad", VS.Name);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var VS = new VokunSalad();
            VS.Size = Size.Small;
            Assert.Equal(Size.Small, VS.Size);
            VS.Size = Size.Medium;
            Assert.Equal(Size.Medium, VS.Size);
            VS.Size = Size.Large;
            Assert.Equal(Size.Large, VS.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            int expectedLengthOfReturnedList = 1;
            string expectedStringInList = "No special instructions";

            var VS = new VokunSalad();

            List<string> ls = VS.SpecialInstructions;
            Assert.Equal(expectedLengthOfReturnedList, ls.Count);
            Assert.Contains(expectedStringInList, ls);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };
            Assert.Equal(price, VS.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };
            Assert.Equal(calories, VS.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectToStringNameBasedOnSize(Size size)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };

            if (size == Size.Small) Assert.Equal("Small Vokun Salad", VS.ToStringName);
            if (size == Size.Medium) Assert.Equal("Medium Vokun Salad", VS.ToStringName);
            if (size == Size.Large) Assert.Equal("Large Vokun Salad", VS.ToStringName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectNameBasedOnSize(Size size)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };

            if (size == Size.Small) Assert.Equal("Small Vokun Salad", VS.ToString());
            if (size == Size.Medium) Assert.Equal("Medium Vokun Salad", VS.ToString());
            if (size == Size.Large) Assert.Equal("Large Vokun Salad", VS.ToString());
        }
    }
}