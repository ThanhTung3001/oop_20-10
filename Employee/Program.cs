using System;

namespace homework_20_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounting accounting = new Accounting();
            accounting.name = "Tung";
            accounting.Salary = 5000;
            accounting.supportSalary = 1000;
            Bussinessmant bussinessmant =new Bussinessmant();
            bussinessmant.name = "Dat";
            bussinessmant.Salary = 2000;
            bussinessmant.contract = 100;
            Company.employees.Add(accounting);
            Company.employees.Add(bussinessmant);
            Company.sortBySalary();
            Company.findMEmployeeHasLGSalary(1);
            Company.searchByName("Tung");
            Company.sortBySalary();
            
        }
    }
}
