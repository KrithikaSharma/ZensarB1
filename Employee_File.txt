using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsolePrj
{
    class Employee
    {
        int EmpId;
        string EmpName;
        float EmpSalary;

        public void GetEmp()
        {
            Console.WriteLine("Enter Employee Id, Name and Salary:"); //or as below
            EmpId = Convert.ToInt32(Console.ReadLine());
            EmpId = int.Parse(Console.ReadLine());
            EmpName = Console.ReadLine();
            EmpSalary = Convert.ToSingle(Console.ReadLine()); //or as below
            EmpSalary = float.Parse(Console.ReadLine());
        }
    

    public void ShowEmp()
    {
        Console.WriteLine("Employee Details, Id={0}, Name={1}, Salary={2}", EmpId,EmpName,EmpSalary);
    }

        public static void Main()
        {
            Employee emp = new Employee();
            emp.GetEmp();
            emp.ShowEmp();
            Console.ReadKey();
        }
}
}

