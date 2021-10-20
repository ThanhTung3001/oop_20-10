using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_20_10
{
    public abstract class Employee
    {
        public String name { get; set; }
       public int id { get; set; }

        public String birthDay { get; set; }    
        public float Salary { get; set; }
       public Employee()
        {

        }
        public Employee(String name,int id,String birthDay,float salary)
        {
            this.name = name;
             this.id = id;
            this.Salary = salary;
            this.birthDay = birthDay;
        }
        public virtual void Input()
        {
            Console.WriteLine("Input Name : ");name=Console.ReadLine();
            Console.WriteLine("Input CMND: ");id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Salary : ");Salary=float.Parse(Console.ReadLine());
            Console.WriteLine("Input BirthDay: ");birthDay = Console.ReadLine();

        }
        public virtual float caculateSalary()
        {
            return Salary;
        }
        public virtual void Output()
        {
            Console.WriteLine("CMND: {0},Name: {1},Salary base: {2}, BirthDay: {3}",name,id,Salary,birthDay);
        }
    }
}
