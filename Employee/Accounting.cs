using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_20_10
{
    public class Accounting : Employee
    {
        public float supportSalary { get; set; }
        public Accounting()
        {

        }
        public Accounting(String name, int id, String birthDay, float salary,float support):base(name, id, birthDay, salary)
        {
            this.name = name;
            this.id = id;       
            this.birthDay = birthDay;
            supportSalary = support;
            Salary = salary;

        }
        public new  float caculateSalary()
        {
            return supportSalary+base.caculateSalary();
        }
        public new void Input()
        {
            base.Input();
            Console.WriteLine("Support Salary: ");
            supportSalary = float.Parse(Console.ReadLine());
        }
        public new void Output()
        {    
            base.Output();
            Console.Write("Salary: {0}",caculateSalary());
        }
    }
}
