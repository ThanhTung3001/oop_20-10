using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_20_10
{
    public static class Company
    {
     public  static  List<Employee> employees = new List<Employee>();
        public static void  sortBySalary()
        {
          Accounting accounting =new Accounting();

            employees.Sort((Employee e1, Employee e2) =>
            {
                float v = e1.Salary - e2.Salary;
                return (int)v;
            });

        }
        public static void caculateSalary()
        {
            employees.ForEach(e =>
            {
                e.caculateSalary();
            });
        }
        public static void searchByName(String name)
        {
            employees.ForEach(e =>
            {
                if (e.name.Equals(name))
                {
                    e.Output();
                }
            });
        }
        public static void  findMEmployeeHasLGSalary(int m)
        {
          employees.Sort((Employee e1, Employee e2) =>
          {
              float v = e1.Salary - e2.Salary;
              return (int)v;
          });
            int i = 0;
           while( i != m){
                employees[i].Output();
                i++;
            }
        }
       
    }
}
