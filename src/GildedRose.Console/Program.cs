using System.Collections.Generic;

namespace GildedRose.Console
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        public IList<Item> Items;

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
                          {
                              Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

                          };

            app.UpdateQuality();

            System.Console.ReadKey();

        }

        const int MaxQuality = 50;

        public void UpdateQuality()
        {
            foreach(Item item in Items)
            {
                UpdateQuality(item);
            }
        }

        private static void UpdateQuality(Item item)
        {
            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.Quality > 0)
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        if (item.Name == "Conjured Mana Cake")
                        {
                            item.Quality = item.Quality - 2;
                        }
                        else
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                }
            }
            else
            {
                IncrementItemQualityByOne(item);

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn < 11)
                    {
                        IncrementItemQualityByOne(item);
                    }

                    if (item.SellIn < 6)
                    {
                        IncrementItemQualityByOne(item);
                    }
                }
            }

            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                if (item.Name == "Conjured Mana Cake")
                                {
                                    item.Quality = item.Quality - 2;
                                }
                                else
                                {
                                    item.Quality = item.Quality - 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    IncrementItemQualityByOne(item);
                }
            }
        }

        private static void IncrementItemQualityByOne(Item item)
        {
            if (item.Quality < MaxQuality)
                item.Quality = item.Quality + 1;
        }
    }
}
