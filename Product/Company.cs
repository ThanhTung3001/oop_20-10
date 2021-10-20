using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110411_20_10_2
{
    public static class Company
    {
        public static List<Product> products = new List<Product>();
        public static void sortByPrice()
        {
            products.Sort((Product p1,Product p2)=>
            {
                float price =p1.price- p2.price;
                return (int)price;
            });
        }
        public static void findByName(String name)
        {
            products.ForEach(product =>
            {
                if (product.name.Equals(name))
                    product.OutPut();
            });
        }
        public static void findMLargestPrice(int n)
        {
            int i = 0;
         products.Sort((Product p1, Product p2) =>
            {
                float price = p1.price - p2.price;
                return (int)price;
            });
            
            products.ForEach(pr =>
            {
                if (i != n)
                {
                    i++;
                    pr.OutPut();
                }
               
            });
        }
        
    }
}
