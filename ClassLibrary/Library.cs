using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        public Product[] products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length+1);
            products[products.Length-1] = product;
        }
        public Product[] GetProductByPrice(double minPrice,double maxPrice)
        {
            Product[] products2 = new Product[0];
            foreach (var item in products)
            {
                if(item.Price >= minPrice && item.Price <= maxPrice)
                {
                    Array.Resize(ref products2, products2.Length + 1);
                    products2[products2.Length - 1] = item;
                }
                    
            }
            return products2;
        }
        public Product[] GetProductByName(string name)
        {
            Product[] products1 = new Product[0];
            foreach (var item in products)
            {
                if (item.Name == name)
                {
                    Array.Resize(ref products1, products1.Length + 1);
                    products1[products1.Length - 1] = item;
                }
            }
            return products1;
        }

    }
}
