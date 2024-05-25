using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTask
{
    public class Inventory
    {
        public Dictionary<string, int> Products { get; } = [];

        public void AddProduct(string productName, int count)
        {
            if (!Products.ContainsKey(productName)) Products.Add(productName, count);
            else Console.WriteLine("There is product with this name");
        }

        public void RemoveProduct(string productName)
        {
            if (Products.ContainsKey(productName)) Products.Remove(productName);
            else Console.WriteLine("There is no such a product");
        }

        public void UpdateQuantity(string productName, int newCount)
        {
            if (Products.ContainsKey(productName)) Products[productName] = newCount;
            else Console.WriteLine("There is no such a product");
        }

        public int GetQuantityByProduct(string productName)
        {
            if (Products.ContainsKey(productName)) return Products[productName];
            else return -1;
        }
    }
}
