using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GildedRose.Console
{
    public class ItemProcessFactory
    {
        public static void UpdateItem(Item item)
        {
            if (item.Name != Item.AgedBrie && item.Name != Item.TAFKAL80ETC)
            {
                if (item.Quality > 0)
                {
                    if (item.Name != Item.Sulfuras)
                    {
                        ChangeQuality(item,- 1);
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    ChangeQuality(item,1);

                    if (item.Name == Item.TAFKAL80ETC)
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                ChangeQuality(item,1);
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                ChangeQuality(item,1);
                            }
                        }
                    }
                }
            }

            if (item.Name != Item.Sulfuras)
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != Item.AgedBrie)
                {
                    if (item.Name != Item.TAFKAL80ETC)
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != Item.Sulfuras)
                            {
                                ChangeQuality(item, -1);
                            }
                        }
                    }
                    else
                    {
                        ChangeQuality(item, -item.Quality);
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        ChangeQuality(item,1);
                    }
                }
            }
            else
            {
                ChangeQuality(item, 2);
            }
        }

        private static void ChangeQuality(Item item , int amount)
        {
            int minQuality = 0;
            int maxQuality = 50; 

            if (amount < 0)
            {
                item.Quality = Math.Max(minQuality, item.Quality + amount);
            }
            else
            {
                item.Quality = Math.Min(maxQuality, item.Quality  + amount) ;
            }
        }
    }
}
