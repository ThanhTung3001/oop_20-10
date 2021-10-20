using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110411_20_10_2
{
    public class Phone:Product
    {

        public int memmory { get; set; }
        public Phone(int code, string name, string color, float price, int memmory) : base(code, name, color, price)
        {

        }

        public override void input()
        {
            base.input();
            Console.Write("input memmory: "); memmory = Int32.Parse(Console.ReadLine());
        }

        public override void OutPut()
        {
            base.OutPut();
            Console.Write("output memmory:{1} ", memmory);
        }

        public override float Price()
        {
            return (float)(base.Price() + memmory * 0.2);
        }
    }
}
