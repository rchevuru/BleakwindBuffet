/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
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
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var SS = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(SS);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "Price", () =>
            {
                SS.Size = Size.Medium;
            });

            Assert.PropertyChanged(SS, "Price", () =>
            {
                SS.Size = Size.Large;
            });

            Assert.PropertyChanged(SS, "Price", () =>
            {
                SS.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "Calories", () =>
            {
                SS.Size = Size.Medium;
            });

            Assert.PropertyChanged(SS, "Calories", () =>
            {
                SS.Size = Size.Large;
            });

            Assert.PropertyChanged(SS, "Calories", () =>
            {
                SS.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "Ice", () =>
            {
                SS.Ice = true;
            });

            Assert.PropertyChanged(SS, "Ice", () =>
            {
                SS.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "SpecialInstructions", () =>
            {
                SS.Ice = true;
            });

            Assert.PropertyChanged(SS, "SpecialInstructions", () =>
            {
                SS.Ice = false;
            });
        }

        [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Cherry;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Grapefruit;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Lemon;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Peach;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Watermelon;
            });
        }

        [Fact]
        public void ChangingFlavorNotifiesToStringNameProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "ToStringName", () =>
            {
                SS.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(SS, "ToStringName", () =>
            {
                SS.Flavor = SodaFlavor.Cherry;
            });

            Assert.PropertyChanged(SS, "ToStringName", () =>
            {
                SS.Flavor = SodaFlavor.Grapefruit;
            });

            Assert.PropertyChanged(SS, "ToStringName", () =>
            {
                SS.Flavor = SodaFlavor.Lemon;
            });

            Assert.PropertyChanged(SS, "ToStringName", () =>
            {
                SS.Flavor = SodaFlavor.Peach;
            });

            Assert.PropertyChanged(SS, "ToStringName", () =>
            {
                SS.Flavor = SodaFlavor.Watermelon;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var SS = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(SS);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var SS = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(SS);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var SS = new SailorSoda();
            Assert.True(SS.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var SS = new SailorSoda();
            Assert.Equal(Size.Small, SS.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            var SS = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, SS.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetScreen()
        {
            var SS = new SailorSoda();
            object o = new object();

            SS.Screen = o;
            Assert.Equal(o, SS.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var SS = new SailorSoda();
            SS.Ice = false;
            Assert.False(SS.Ice);
            SS.Ice = true;
            Assert.True(SS.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var SS = new SailorSoda();
            SS.Size = Size.Small;
            Assert.Equal(Size.Small, SS.Size);
            SS.Size = Size.Medium;
            Assert.Equal(Size.Medium, SS.Size);
            SS.Size = Size.Large;
            Assert.Equal(Size.Large, SS.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            var SS = new SailorSoda();
            SS.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, SS.Flavor);
            SS.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, SS.Flavor);
            SS.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, SS.Flavor);
            SS.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, SS.Flavor);
            SS.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, SS.Flavor);
            SS.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, SS.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var SS = new SailorSoda()
            {
                Size = size
            };
            Assert.Equal(price, SS.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var SS = new SailorSoda()
            {
                Size = size
            };
            Assert.Equal(cal, SS.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var SS = new SailorSoda()
            {
                Ice = includeIce
            };
            if (includeIce) Assert.Contains("No special instructions", SS.SpecialInstructions);
            if (!includeIce) Assert.Contains("Hold ice", SS.SpecialInstructions);
        }

        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small)]
        [InlineData(SodaFlavor.Cherry, Size.Medium)]
        [InlineData(SodaFlavor.Cherry, Size.Large)]

        [InlineData(SodaFlavor.Blackberry, Size.Small)]
        [InlineData(SodaFlavor.Blackberry, Size.Medium)]
        [InlineData(SodaFlavor.Blackberry, Size.Large)]

        [InlineData(SodaFlavor.Grapefruit, Size.Small)]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium)]
        [InlineData(SodaFlavor.Grapefruit, Size.Large)]

        [InlineData(SodaFlavor.Lemon, Size.Small)]
        [InlineData(SodaFlavor.Lemon, Size.Medium)]
        [InlineData(SodaFlavor.Lemon, Size.Large)]

        [InlineData(SodaFlavor.Peach, Size.Small)]
        [InlineData(SodaFlavor.Peach, Size.Medium)]
        [InlineData(SodaFlavor.Peach, Size.Large)]

        [InlineData(SodaFlavor.Watermelon, Size.Small)]
        [InlineData(SodaFlavor.Watermelon, Size.Medium)]
        [InlineData(SodaFlavor.Watermelon, Size.Large)]
        public void ShouldHaveCorrectToStringNameBasedOnSizeAndFlavor(SodaFlavor flavor, Size size)
        {
            var SS = new SailorSoda()
            {
                Flavor = flavor,
                Size = size
            };

            if (size == Size.Small)
            {
                switch (flavor)
                {
                    case SodaFlavor.Blackberry:
                        Assert.Equal("Small Blackberry Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Cherry:
                        Assert.Equal("Small Cherry Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Grapefruit:
                        Assert.Equal("Small Grapefruit Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Lemon:
                        Assert.Equal("Small Lemon Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Peach:
                        Assert.Equal("Small Peach Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Watermelon:
                        Assert.Equal("Small Watermelon Sailor Soda", SS.ToStringName);
                        break;

                    default: throw new NotImplementedException();
                }
            }
            if (size == Size.Medium)
            {
                switch (flavor)
                {
                    case SodaFlavor.Blackberry:
                        Assert.Equal("Medium Blackberry Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Cherry:
                        Assert.Equal("Medium Cherry Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Grapefruit:
                        Assert.Equal("Medium Grapefruit Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Lemon:
                        Assert.Equal("Medium Lemon Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Peach:
                        Assert.Equal("Medium Peach Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Watermelon:
                        Assert.Equal("Medium Watermelon Sailor Soda", SS.ToStringName);
                        break;

                    default: throw new NotImplementedException();
                }
            }
            if (size == Size.Large)
            {
                switch (flavor)
                {
                    case SodaFlavor.Blackberry:
                        Assert.Equal("Large Blackberry Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Cherry:
                        Assert.Equal("Large Cherry Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Grapefruit:
                        Assert.Equal("Large Grapefruit Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Lemon:
                        Assert.Equal("Large Lemon Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Peach:
                        Assert.Equal("Large Peach Sailor Soda", SS.ToStringName);
                        break;

                    case SodaFlavor.Watermelon:
                        Assert.Equal("Large Watermelon Sailor Soda", SS.ToStringName);
                        break;

                    default: throw new NotImplementedException();
                }
            }
        }

        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small)]
        [InlineData(SodaFlavor.Cherry, Size.Medium)]
        [InlineData(SodaFlavor.Cherry, Size.Large)]

        [InlineData(SodaFlavor.Blackberry, Size.Small)]
        [InlineData(SodaFlavor.Blackberry, Size.Medium)]
        [InlineData(SodaFlavor.Blackberry, Size.Large)]

        [InlineData(SodaFlavor.Grapefruit, Size.Small)]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium)]
        [InlineData(SodaFlavor.Grapefruit, Size.Large)]

        [InlineData(SodaFlavor.Lemon, Size.Small)]
        [InlineData(SodaFlavor.Lemon, Size.Medium)]
        [InlineData(SodaFlavor.Lemon, Size.Large)]

        [InlineData(SodaFlavor.Peach, Size.Small)]
        [InlineData(SodaFlavor.Peach, Size.Medium)]
        [InlineData(SodaFlavor.Peach, Size.Large)]

        [InlineData(SodaFlavor.Watermelon, Size.Small)]
        [InlineData(SodaFlavor.Watermelon, Size.Medium)]
        [InlineData(SodaFlavor.Watermelon, Size.Large)]
        public void ShouldHaveCorrectNameBasedOnSizeAndFlavor(SodaFlavor flavor, Size size)
        {
            var SS = new SailorSoda()
            {
                Flavor = flavor,
                Size = size
            };

            if(size == Size.Small)
            {
                switch(flavor)
                {
                    case SodaFlavor.Blackberry: 
                        Assert.Equal("Small Blackberry Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Cherry:
                        Assert.Equal("Small Cherry Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Grapefruit:
                        Assert.Equal("Small Grapefruit Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Lemon:
                        Assert.Equal("Small Lemon Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Peach:
                        Assert.Equal("Small Peach Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Watermelon:
                        Assert.Equal("Small Watermelon Sailor Soda", SS.ToString());
                        break;

                    default: throw new NotImplementedException();
                }
            }
            if(size == Size.Medium)
            {
                switch (flavor)
                {
                    case SodaFlavor.Blackberry:
                        Assert.Equal("Medium Blackberry Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Cherry:
                        Assert.Equal("Medium Cherry Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Grapefruit:
                        Assert.Equal("Medium Grapefruit Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Lemon:
                        Assert.Equal("Medium Lemon Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Peach:
                        Assert.Equal("Medium Peach Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Watermelon:
                        Assert.Equal("Medium Watermelon Sailor Soda", SS.ToString());
                        break;

                    default: throw new NotImplementedException();
                }
            }
            if(size == Size.Large)
            {
                switch (flavor)
                {
                    case SodaFlavor.Blackberry:
                        Assert.Equal("Large Blackberry Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Cherry:
                        Assert.Equal("Large Cherry Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Grapefruit:
                        Assert.Equal("Large Grapefruit Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Lemon:
                        Assert.Equal("Large Lemon Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Peach:
                        Assert.Equal("Large Peach Sailor Soda", SS.ToString());
                        break;

                    case SodaFlavor.Watermelon:
                        Assert.Equal("Large Watermelon Sailor Soda", SS.ToString());
                        break;

                    default: throw new NotImplementedException();
                }
            }
        }
    }
}