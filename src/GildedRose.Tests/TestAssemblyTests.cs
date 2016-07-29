using System;
using System.Linq;
using GildedRose.Console;
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
        public void TestItemsSellinCheck()
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
        public void TestItemsSellin()
        {
            var item = new Item {Name = Item.DexterityVest, SellIn = 0, Quality = 20};
            var item2 = (Item) item.Clone();

            ItemProcessFactory.UpdateItem(item2);
            Assert.True(item.Quality == item2.Quality + 2);
        }


        [Fact]
        public void TestItemsNegativeQuality()
        {
            var item = new Item {Name = Item.DexterityVest, SellIn = 0, Quality = 1};
            var item2 = (Item) item.Clone();
            ItemProcessFactory.UpdateItem(item2);
            Assert.True(item.Quality != item2.Quality && item2.Quality == 0);
        }

        [Fact]
        public void TestItemsBrieSellinZero()
        {
            var item = new Item {Name = Item.AgedBrie, SellIn = 0, Quality = 1};
            var item2 = (Item) item.Clone();
            ItemProcessFactory.UpdateItem(item2);
            Assert.True(item.Quality < item2.Quality);
        }

        [Fact]
        public void TestItemsMaxQuality()
        {
            var item = new Item { Name = Item.AgedBrie, SellIn = 0, Quality = 50 };
            var item2 = (Item)item.Clone();
            ItemProcessFactory.UpdateItem(item2);
            Assert.True(item.Quality == item2.Quality);
        }



        [Fact]
        public void TestItemsSulfuras()
        {
            var item = new Item { Name = Item.Sulfuras, SellIn = 0, Quality = 80 };
            var item2 = (Item)item.Clone();
            ItemProcessFactory.UpdateItem(item2);
            Assert.True(item.Quality == item2.Quality && item.SellIn == item2.SellIn);
        }

        [Fact]
        public void TestItemsUpdate()
        {
            var app = new Console.Program();
            var listv1 = ItemFactory.CreateItemList();
            app.UpdateQuality();
            var listv2 = app.Items;

            for (int i = 0; i < listv2.Count; i++)
            {
                Assert.True(listv1[i].SellIn != listv2[i].SellIn 
                    && listv1[i].Name == listv2[i].Name
                    && listv1[i].Quality != listv2[i].Quality,
                    $"{listv1[i].Name} {listv1[i].SellIn} {listv2[i].SellIn} {listv1[i].Quality} {listv2[i].Quality}");
            }

        }
    }
}