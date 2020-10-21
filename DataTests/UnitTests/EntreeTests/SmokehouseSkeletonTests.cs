/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var SS = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(SS);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var SS = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(SS);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var SS = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(SS);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            var SS = new SmokehouseSkeleton();
            SS.SausageLink = false;
            Assert.False(SS.SausageLink);
            SS.SausageLink = true;
            Assert.True(SS.SausageLink);
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "SausageLink", () =>
            {
                SS.SausageLink = false;
            });
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSpecialInstructionsProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "SpecialInstructions", () =>
            {
                SS.SausageLink = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var SS = new SmokehouseSkeleton();
            SS.Egg = false;
            Assert.False(SS.Egg);
            SS.Egg = true;
            Assert.True(SS.Egg);
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "Egg", () =>
            {
                SS.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesSpecialInstructionsProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "SpecialInstructions", () =>
            {
                SS.Egg = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            var SS = new SmokehouseSkeleton();
            SS.HashBrowns = false;
            Assert.False(SS.HashBrowns);
            SS.HashBrowns = true;
            Assert.True(SS.HashBrowns);
        }

        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownsProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "HashBrowns", () =>
            {
                SS.HashBrowns = false;
            });
        }

        [Fact]
        public void ChangingHashBrownsNotifiesSpecialInstructionsProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "SpecialInstructions", () =>
            {
                SS.HashBrowns = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            var SS = new SmokehouseSkeleton();
            SS.Pancake = false;
            Assert.False(SS.Pancake);
            SS.Pancake = true;
            Assert.True(SS.Pancake);
        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "Pancake", () =>
            {
                SS.Pancake = false;
            });
        }

        [Fact]
        public void ChangingPancakeNotifiesSpecialInstructionsProperty()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "SpecialInstructions", () =>
            {
                SS.Pancake = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            double expectedPrice = 5.62;
            var SS = new SmokehouseSkeleton();
            Assert.Equal(expectedPrice, SS.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint expectedCal = 602;
            var SS = new SmokehouseSkeleton();
            Assert.Equal(expectedCal, SS.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            var SS = new SmokehouseSkeleton()
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };
            if (!includeSausage) Assert.Contains("Hold sausage", SS.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", SS.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", SS.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancake", SS.SpecialInstructions);

            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Contains("No special instructions", SS.SpecialInstructions);
        }

        [Fact]
        public void ToStringNameShouldReturnCorrectName()
        {
            var SS = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", SS.ToStringName);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var SS = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", SS.ToString());
        }
    }
}