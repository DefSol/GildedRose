namespace GildedRose.Console
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        private const string CONJURED = "conjured";
        public bool Conjured => Name.ToLower().Contains(CONJURED);

    }
}
