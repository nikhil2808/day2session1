using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Mobile
    {
        int productId;
        string brand;
        string model;
        int price;
        string description;

        internal Mobile() { }

        internal Mobile(int productId, string brand, string model, int price, string description)
        {
            this.productId = productId;
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.description = description;
        }

        internal int GetProductId()
        {
            return productId;
        }

        internal void Display()
        {
            Console.WriteLine($"Id : {productId} Model : {model} Brand : {brand}");
        }
    }
}