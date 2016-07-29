using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items { get; private set; }


        public Program()
        {
            Items = ItemFactory.CreateItemList();
        }


        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program();
            app.UpdateQuality();

            System.Console.ReadKey();
        }


      


        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                ItemProcessFactory.UpdateItem(Items[i]);
            }
        }
    }
}
