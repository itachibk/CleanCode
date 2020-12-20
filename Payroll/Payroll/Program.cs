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
            //Lấy đường dẫn file
            string pathFileEmployee = System.IO.Directory.GetCurrentDirectory() + @"\"+ @"employee.csv";
            
            //Khởi tạo danh sách nhân viên
            List<Employee> employees = new List<Employee>();
            //Lấy danh sách nhân viên từ file csv
             employees = Common.GetEmployeeFromCsvFile(pathFileEmployee);
            //Hiển thị danh sách nhân viên
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
            //Tạm dừng màn hình console
            Console.ReadLine();
        }
    }
}
