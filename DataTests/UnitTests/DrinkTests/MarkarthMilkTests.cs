/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

using PointOfSale.CustomizationScreens;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var MM = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(MM);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var MM = new MarkarthMilk();

            Assert.PropertyChanged(MM, "Price", () =>
            {
                MM.Size = Size.Medium;
            });

            Assert.PropertyChanged(MM, "Price", () =>
            {
                MM.Size = Size.Large;
            });

            Assert.PropertyChanged(MM, "Price", () =>
            {
                MM.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var MM = new MarkarthMilk();

            Assert.PropertyChanged(MM, "Calories", () =>
            {
                MM.Size = Size.Medium;
            });

            Assert.PropertyChanged(MM, "Calories", () =>
            {
                MM.Size = Size.Large;
            });

            Assert.PropertyChanged(MM, "Calories", () =>
            {
                MM.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesToStringNameProperty()
        {
            var MM = new MarkarthMilk();

            Assert.PropertyChanged(MM, "ToStringName", () =>
            {
                MM.Size = Size.Medium;
            });

            Assert.PropertyChanged(MM, "ToStringName", () =>
            {
                MM.Size = Size.Large;
            });

            Assert.PropertyChanged(MM, "ToStringName", () =>
            {
                MM.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var MM = new MarkarthMilk();

            Assert.PropertyChanged(MM, "Ice", () =>
            {
                MM.Ice = true;
            });

            Assert.PropertyChanged(MM, "Ice", () =>
            {
                MM.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var MM = new MarkarthMilk();

            Assert.PropertyChanged(MM, "SpecialInstructions", () =>
            {
                MM.Ice = true;
            });

            Assert.PropertyChanged(MM, "SpecialInstructions", () =>
            {
                MM.Ice = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var MM = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(MM);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var MM = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(MM);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var MM = new MarkarthMilk();
            Assert.False(MM.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            var MM = new MarkarthMilk();
            Assert.Equal(Size.Small, MM.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetScreen()
        {
            var MM = new MarkarthMilk();
            object o = new object();

            MM.Screen = o;
            Assert.Equal(o, MM.Screen);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            var MM = new MarkarthMilk();
            MM.Ice = true;
            Assert.True(MM.Ice);
            MM.Ice = false;
            Assert.False(MM.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var MM = new MarkarthMilk();
            MM.Size = Size.Small;
            Assert.Equal(Size.Small, MM.Size);
            MM.Size = Size.Medium;
            Assert.Equal(Size.Medium, MM.Size);
            MM.Size = Size.Large;
            Assert.Equal(Size.Large, MM.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var MM = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(price, MM.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var MM = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(cal, MM.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var MM = new MarkarthMilk()
            {
                Ice = includeIce
            };
            if (includeIce) Assert.Contains("Add ice", MM.SpecialInstructions);
            if (!includeIce) Assert.Contains("No special instructions", MM.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectToStringNameBasedOnSize(Size size)
        {
            var MM = new MarkarthMilk()
            {
                Size = size
            };
            if (size == Size.Small) Assert.Equal("Small Markarth Milk", MM.ToStringName);
            if (size == Size.Medium) Assert.Equal("Medium Markarth Milk", MM.ToStringName);
            if (size == Size.Large) Assert.Equal("Large Markarth Milk", MM.ToStringName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectNameBasedOnSize(Size size)
        {
            var MM = new MarkarthMilk()
            {
                Size = size
            };
            if (size == Size.Small) Assert.Equal("Small Markarth Milk", MM.ToString());
            if (size == Size.Medium) Assert.Equal("Medium Markarth Milk", MM.ToString());
            if (size == Size.Large) Assert.Equal("Large Markarth Milk", MM.ToString());
        }
    }
}