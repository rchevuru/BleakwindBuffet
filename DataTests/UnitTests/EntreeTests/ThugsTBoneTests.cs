/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var TTB = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TTB);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var TTB = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(TTB);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var TTB = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(TTB);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            double expectedPrice = 6.44;
            var TTB = new ThugsTBone();
            Assert.Equal(expectedPrice, TTB.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint expectedCal = 982;
            var TTB = new ThugsTBone();
            Assert.Equal(expectedCal, TTB.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var TTB = new ThugsTBone();
            Assert.Contains("No special instructions", TTB.SpecialInstructions);
        }

        [Fact]
        public void ToStringNameShouldReturnCorrectName()
        {
            var TTB = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", TTB.ToStringName);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var TTB = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", TTB.ToString());
        }
    }
}