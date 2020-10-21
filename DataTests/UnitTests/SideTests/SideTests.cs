/*
 * Author: Zachery Brunner
 * Class: SideTests.cs
 * Purpose: Test the Side.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;

namespace DataTests.UnitTests.SideTests
{
    public class SideTests
    {
        [Fact]
        public void ShouldBeAbleToSetScreenInDWF()
        {
            var DWF = new DragonbornWaffleFries();
            object o = new object();

            DWF.Screen = o;
            Assert.Equal(o, DWF.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInFM()
        {
            var FM = new FriedMiraak();
            object o = new object();

            FM.Screen = o;
            Assert.Equal(o, FM.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInMOG()
        {
            var MOG = new MadOtarGrits();
            object o = new object();

            MOG.Screen = o;
            Assert.Equal(o, MOG.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetScreenInVS()
        {
            var VS = new VokunSalad();
            object o = new object();

            VS.Screen = o;
            Assert.Equal(o, VS.Screen);
        }
    }
}