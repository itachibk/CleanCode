using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var fileName = @"C:\Users\Shine\Desktop\CleanCode\CleanCode\Payroll\employee.csv";
            List<Employee> employees = new List<Employee>();
            employees = Common.GetEmployeeFromCsvFile(fileName);

            foreach (var item in employees)
            {
                Console.WriteLine(item.name + "-" + item.dob + "-" + item.role + "-" + item.startDate + "-" + item.startSalary + " "+ item.caculateAge().ToString());
                //item.caculateAge().ToString();
            }
            Console.ReadLine();
        }
    }
}
