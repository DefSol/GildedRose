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

        public void TestQualityDegrade()
        {
            var qualityItem = new Item()
            {
                Name = "+5 Dexterity Vest",
                SellIn = 1,
                Quality = 1
            };

            var app = new Program();
            var items = new List<Item>();
            items.Add(qualityItem);
        }
    }
}