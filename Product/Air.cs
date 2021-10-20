using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110411_20_10_2
{
    public class Air:Product
    {
        public int force { get; set; }
        public Air(int code, string name, string color, float price, int size) : base(code, name, color, price)
        {

        }

        public override void input()
        {
            base.input();
            Console.Write("input force: "); force = Int32.Parse(Console.ReadLine());
        }

        public override void OutPut()
        {
            base.OutPut();
            Console.Write("input force:{1} ", force);
        }

        public override float Price()
        {
            return (float)(base.Price() + force * 0.1);
        }
    }
}
