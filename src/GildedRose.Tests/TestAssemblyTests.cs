using GildedRose.Console;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheTruth()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestQualityDecreasesBy1ByDefault()
        {
            var program = new Program();            
            program.Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
            program.UpdateQuality();
            Assert.Equal(19, program.Items[0].Quality);
        }
    }
}