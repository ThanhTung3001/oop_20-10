using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_20_10
{
    internal class Sercurity:Employee
    {
        public int session { get; set; }
        public Sercurity()
        {

        }
        public Sercurity(String name, int id, String birthDay, float salary,int session) : base(name, id, birthDay, salary)
        {
            this.name = name;
            this.id = id;
            this.Salary = salary;
            this.birthDay = birthDay;
            this.session = session;
        } 
        public new void Output()
        {
            base.Output();
            Console.WriteLine("Sesstion work: {1}", session);
        }
        public new float caculateSalary() { return base.Salary; }
    }
}
