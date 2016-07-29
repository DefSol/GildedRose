using System;

namespace GildedRose.Console
{
    public class Item : ICloneable
    {
        public const string AgedBrie = "Aged Brie";
        public const string TAFKAL80ETC = "Backstage passes to a TAFKAL80ETC concert";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string DexterityVest = "+5 Dexterity Vest";
        public const string ElixirMongoose = "Elixir of the Mongoose";
        public const string ManaCake = "Conjured Mana Cake";


        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        private const string CONJURED = "conjured";

        public bool Conjured => Name.ToLower().Contains(CONJURED);

        public object Clone()
        {
           return new Item() {Name = this.Name, Quality = this.Quality , SellIn = this.SellIn};
        }
    }
}
