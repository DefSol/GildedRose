using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class ItemFactory
    {
        public static List<Item> CreateItemList()
        {
            List<Item> items = new List<Item>
            {
                new Item {Name = Item.DexterityVest, SellIn = 10, Quality = 20},
                new Item {Name = Item.AgedBrie, SellIn = 2, Quality = 0},
                new Item {Name = Item.ElixirMongoose, SellIn = 5, Quality = 7},
                new Item {Name = Item.Sulfuras, SellIn = 0, Quality = 80},
                new Item
                {
                    Name = Item.TAFKAL80ETC,
                    SellIn = 15,
                    Quality = 20
                },
                new Item {Name = Item.ManaCake, SellIn = 3, Quality = 6}
            };
            return items;
        }
    }
}
