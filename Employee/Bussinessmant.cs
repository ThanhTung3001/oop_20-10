using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_20_10
{
    internal class Bussinessmant : Accounting
    {
        public int contract;
       public Bussinessmant()
        {

        }
        public Bussinessmant(String name, int id, String birthDay, float salary, float support ,int contract) : base(name, id, birthDay, salary, support)
        {
            this.name = name;
            this.id = id;
            this.birthDay = birthDay;
            this.supportSalary = support;
            this.Salary = salary;
            this.contract = contract;
        }

        public new float caculateSalary() { return base.Salary + contract * 100; }
        public new void Input()
        {
            base.Input();
            Console.Write("Input contract: ");contract = Int32.Parse(Console.ReadLine());

        }
        public new void Output()
        {
            base.Output();
            Console.Write("Salary Finally:{1} ", caculateSalary());

        }
    }
}
