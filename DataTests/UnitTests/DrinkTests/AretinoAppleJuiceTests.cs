/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using System;
using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

using PointOfSale.CustomizationScreens;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var AJ = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(AJ);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Price", () =>
            {
                AJ.Size = Size.Medium;
            });

            Assert.PropertyChanged(AJ, "Price", () =>
            {
                AJ.Size = Size.Large;
            });

            Assert.PropertyChanged(AJ, "Price", () =>
            {
                AJ.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Calories", () =>
            {
                AJ.Size = Size.Medium;
            });

            Assert.PropertyChanged(AJ, "Calories", () =>
            {
                AJ.Size = Size.Large;
            });

            Assert.PropertyChanged(AJ, "Calories", () =>
            {
                AJ.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesToStringNameProperty()
        {
            var AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "ToStringName", () =>
            {
                AJ.Size = Size.Medium;
            });

            Assert.PropertyChanged(AJ, "ToStringName", () =>
            {
                AJ.Size = Size.Large;
            });

            Assert.PropertyChanged(AJ, "ToStringName", () =>
            {
                AJ.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.Ice = true;
            });

            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "SpecialInstructions", () =>
            {
                AJ.Ice = true;
            });

            Assert.PropertyChanged(AJ, "SpecialInstructions", () =>
            {
                AJ.Ice = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var AJ = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(AJ);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var AJ = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(AJ);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var AJ = new AretinoAppleJuice();
            Assert.False(AJ.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var AJ = new AretinoAppleJuice();
            Assert.Equal(Size.Small, AJ.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetScreen()
        {
            
            var AJ = new AretinoAppleJuice();
            object o = new object();

            AJ.Screen = o;
            Assert.Equal(o, AJ.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var AJ = new AretinoAppleJuice();
            AJ.Ice = false;
            Assert.False(AJ.Ice);
            AJ.Ice = true;
            Assert.True(AJ.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var AJ = new AretinoAppleJuice();
            AJ.Size = Size.Small;
            Assert.Equal(Size.Small, AJ.Size);
            AJ.Size = Size.Medium;
            Assert.Equal(Size.Medium, AJ.Size);
            AJ.Size = Size.Large;
            Assert.Equal(Size.Large, AJ.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var AJ = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(price, AJ.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var AJ = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(cal, AJ.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var AJ = new AretinoAppleJuice()
            {
                Ice = includeIce
            };
            if (!includeIce) Assert.Contains("No special instructions", AJ.SpecialInstructions);
            if (includeIce) Assert.Contains("Add ice", AJ.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectToStringNameBasedOnSize(Size size)
        {
            var AJ = new AretinoAppleJuice()
            {
                Size = size
            };
            if (size == Size.Small) Assert.Equal("Small Aretino Apple Juice", AJ.ToStringName);
            if (size == Size.Medium) Assert.Equal("Medium Aretino Apple Juice", AJ.ToStringName);
            if (size == Size.Large) Assert.Equal("Large Aretino Apple Juice", AJ.ToStringName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectNameBasedOnSize(Size size)
        {
            var AJ = new AretinoAppleJuice()
            {
                Size = size
            };
            if (size == Size.Small) Assert.Equal("Small Aretino Apple Juice", AJ.ToString());
            if (size == Size.Medium) Assert.Equal("Medium Aretino Apple Juice", AJ.ToString());
            if (size == Size.Large) Assert.Equal("Large Aretino Apple Juice", AJ.ToString());
        }
    }
}