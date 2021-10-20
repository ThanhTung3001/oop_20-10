using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110411_20_10_2
{
    public class Television:Product
    {
        public int size { get; set; }
        public Television( int code, string name, string color, float price, int size) : base( code, name,color,price){

        }

        public override void input()
        {
            base.input();
            Console.Write("input size: ");size=Int32.Parse(Console.ReadLine());
        }

        public override void OutPut()
        {
            base.OutPut();
            Console.Write("input size:{1} ", size);
        }

        public override float Price()
        {
            return (float)(base.Price()+size*0.1);
        }
    }
}
