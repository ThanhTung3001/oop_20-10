using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110411_20_10_2
{
    public class Product
    {
        public int code { get; set; }
       public string name { get; set; } 
        public string color { get;set; }
        public float price { get; set; }
       public Product()
        {

        }
        public Product(int code,string name,string color,float price)
        {
            this.code = code;
            this.name = name;
            this.color = color;
            this.price = price;
        }
        public virtual void input()
        {
            Console.Write("Input code: ");code=Int32.Parse(Console.ReadLine());
            Console.Write("Input name:");name=Console.ReadLine();
            Console.Write("Input color: ");color = Console.ReadLine();
            Console.Write("Input Price: ");price =float.Parse (Console.ReadLine());
        }
        public virtual void OutPut()
        {
            Console.WriteLine(" Code:{1} ,Name:{2},Color:{3},Price{4}",code,name,color,price);
        }
        public virtual float Price()
        {
            return price;
        }

    }
}
