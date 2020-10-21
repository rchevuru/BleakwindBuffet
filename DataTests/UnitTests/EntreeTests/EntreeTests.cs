/*
 * Author: Zachery Brunner
 * Class: EntreeTests.cs
 * Purpose: Test the Entree.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace DataTests.UnitTests.EntreeTests
{
    public class EntreeTests
    {
        [Fact]
        public void ShouldBeAbleToSetScreenInBB()
        {
            var BB = new BriarheartBurger();
            object o = new object();

            BB.Screen = o;
            Assert.Equal(o, BB.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInDD()
        {
            var DD = new DoubleDraugr();
            object o = new object();

            DD.Screen = o;
            Assert.Equal(o, DD.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInGOO()
        {
            var GOO = new GardenOrcOmelette();
            object o = new object();

            GOO.Screen = o;
            Assert.Equal(o, GOO.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInPP()
        {
            var PP = new PhillyPoacher();
            object o = new object();

            PP.Screen = o;
            Assert.Equal(o, PP.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInSS()
        {
            var SS = new SmokehouseSkeleton();
            object o = new object();

            SS.Screen = o;
            Assert.Equal(o, SS.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInTT()
        {
            var TT = new ThalmorTriple();
            object o = new object();

            TT.Screen = o;
            Assert.Equal(o, TT.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInTTB()
        {
            var TTB = new ThugsTBone();
            object o = new object();

            TTB.Screen = o;
            Assert.Equal(o, TTB.Screen);
        }
    }
}