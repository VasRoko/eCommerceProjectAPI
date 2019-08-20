using System.Collections.Generic;

namespace OnlineStore.Core.Entities
{
    public class Cart
    {
        public List<Product> Items { get; private set; }
        public float Total { get; private set; }

        public void Add(Product item)
        {
            Items.Add(item);
            Sum();
        }

        public void Remove(Product item)
        {
            Items.Remove(item);
            Sum();
;       }

        private void Sum()
        {
            foreach (Product Item in Items)
            {
                Total = Total + Item.Price;
            }
        }
    }
}
