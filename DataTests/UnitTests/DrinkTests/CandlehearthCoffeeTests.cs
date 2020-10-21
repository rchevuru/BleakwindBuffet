/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

using PointOfSale.CustomizationScreens;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var CC = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(CC);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Price", () =>
            {
                CC.Size = Size.Medium;
            });

            Assert.PropertyChanged(CC, "Price", () =>
            {
                CC.Size = Size.Large;
            });

            Assert.PropertyChanged(CC, "Price", () =>
            {
                CC.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Calories", () =>
            {
                CC.Size = Size.Medium;
            });

            Assert.PropertyChanged(CC, "Calories", () =>
            {
                CC.Size = Size.Large;
            });

            Assert.PropertyChanged(CC, "Calories", () =>
            {
                CC.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesToStringNameProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "ToStringName", () =>
            {
                CC.Size = Size.Medium;
            });

            Assert.PropertyChanged(CC, "ToStringName", () =>
            {
                CC.Size = Size.Large;
            });

            Assert.PropertyChanged(CC, "ToStringName", () =>
            {
                CC.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Ice", () =>
            {
                CC.Ice = true;
            });

            Assert.PropertyChanged(CC, "Ice", () =>
            {
                CC.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.Ice = true;
            });

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.Ice = false;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = true;
            });

            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = false;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesToStringNameProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "ToStringName", () =>
            {
                CC.Decaf = true;
            });

            Assert.PropertyChanged(CC, "ToStringName", () =>
            {
                CC.Decaf = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesRoomForCreamProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "RoomForCream", () =>
            {
                CC.RoomForCream = true;
            });

            Assert.PropertyChanged(CC, "RoomForCream", () =>
            {
                CC.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesSpecialInstructionsProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.RoomForCream = true;
            });

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.RoomForCream = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var CC = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(CC);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var CC = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(CC);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var CC = new CandlehearthCoffee();
            Assert.False(CC.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            var CC = new CandlehearthCoffee();
            Assert.False(CC.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var CC = new CandlehearthCoffee();
            Assert.False(CC.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var CC = new CandlehearthCoffee();
            Assert.Equal(Size.Small, CC.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetScreen()
        {
            var CC = new CandlehearthCoffee();
            object o = new object();

            CC.Screen = o;
            Assert.Equal(o, CC.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var CC = new CandlehearthCoffee();
            CC.Ice = true;
            Assert.True(CC.Ice);
            CC.Ice = false;
            Assert.False(CC.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var CC = new CandlehearthCoffee();
            CC.Decaf = true;
            Assert.True(CC.Decaf);
            CC.Decaf = false;
            Assert.False(CC.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var CC = new CandlehearthCoffee();
            CC.RoomForCream = true;
            Assert.True(CC.RoomForCream);
            CC.RoomForCream = false;
            Assert.False(CC.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var CC = new CandlehearthCoffee();
            CC.Size = Size.Small;
            Assert.Equal(Size.Small, CC.Size);
            CC.Size = Size.Medium;
            Assert.Equal(Size.Medium, CC.Size);
            CC.Size = Size.Large;
            Assert.Equal(Size.Large, CC.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var CC = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(price, CC.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var CC = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(cal, CC.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var CC = new CandlehearthCoffee();
            CC.Ice = includeIce;
            CC.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", CC.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", CC.SpecialInstructions);
            if (!includeIce && !includeCream) Assert.Contains("No special instructions", CC.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small)]
        [InlineData(true, Size.Medium)]
        [InlineData(true, Size.Large)]
        [InlineData(false, Size.Small)]
        [InlineData(false, Size.Medium)]
        [InlineData(false, Size.Large)]
        public void ShouldReturnCorrectToStringNameBasedOnSizeAndIfDecaf(bool decaf, Size size)
        {
            var CC = new CandlehearthCoffee()
            {
                Decaf = decaf,
                Size = size
            };

            if (decaf)
            {
                if (size == Size.Small) Assert.Equal("Small Decaf Candlehearth Coffee", CC.ToStringName);
                if (size == Size.Medium) Assert.Equal("Medium Decaf Candlehearth Coffee", CC.ToStringName);
                if (size == Size.Large) Assert.Equal("Large Decaf Candlehearth Coffee", CC.ToStringName);
            }
            else
            {
                if (size == Size.Small) Assert.Equal("Small Candlehearth Coffee", CC.ToStringName);
                if (size == Size.Medium) Assert.Equal("Medium Candlehearth Coffee", CC.ToStringName);
                if (size == Size.Large) Assert.Equal("Large Candlehearth Coffee", CC.ToStringName);
            }
        }

        [Theory]
        [InlineData(true, Size.Small)]
        [InlineData(true, Size.Medium)]
        [InlineData(true, Size.Large)]
        [InlineData(false, Size.Small)]
        [InlineData(false, Size.Medium)]
        [InlineData(false, Size.Large)]
        public void ShouldReturnCorrectNameBasedOnSizeAndIfDecaf(bool decaf, Size size)
        {
            var CC = new CandlehearthCoffee()
            {
                Decaf = decaf,
                Size = size
            };
            
            if (decaf)
            {
                if (size == Size.Small) Assert.Equal("Small Decaf Candlehearth Coffee", CC.ToString());
                if (size == Size.Medium) Assert.Equal("Medium Decaf Candlehearth Coffee", CC.ToString());
                if (size == Size.Large) Assert.Equal("Large Decaf Candlehearth Coffee", CC.ToString());
            }
            else
            {
                if (size == Size.Small) Assert.Equal("Small Candlehearth Coffee", CC.ToString());
                if (size == Size.Medium) Assert.Equal("Medium Candlehearth Coffee", CC.ToString());
                if (size == Size.Large) Assert.Equal("Large Candlehearth Coffee", CC.ToString());
            }
        }
    }
}