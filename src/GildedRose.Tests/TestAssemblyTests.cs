using System;
using System.Linq;

using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {

        [Fact]
        public void TestCreateList()
        {
            var app = new Console.Program();

            Assert.True(app.Items.Count > 0);
        }

        [Fact]
        public void TestItemsSellin()
        {
            var app = new Console.Program();

            Assert.True(app.Items.Count(i => i.SellIn < 0) == 0);
        }


        [Fact]
        public void TestItemsQuantity()
        {
            var app = new Console.Program();

            Assert.True(app.Items.Count(i => i.Quality < 0) == 0);
        }


        [Fact]
        public void TestItemsUpdate()
        {
            var app = new Console.Program();
            var listv1 = app.CreateItemList();
            app.UpdateQuality();
            var listv2 = app.Items;

            for (int i = 0; i < listv2.Count; i++)
            {
                Assert.True(listv1[i].SellIn != listv2[i].SellIn && listv1[i].Name == listv2[i].Name,
                    $"{listv1[i].Name} {listv1[i].SellIn} {listv2[i].SellIn}");
            }

        }
    }
}