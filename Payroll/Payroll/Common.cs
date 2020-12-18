using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Payroll
{
    public static class Common
    {
        private static int HEADER_ROWS = 1;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<Employee> GetEmployeeFromCsvFile(string fileName)
        {
            List<Employee> employees = new List<Employee>();
            List<String> recordsInCsv = new List<String>();
            recordsInCsv = ReadCSVFile(fileName);

            foreach (string recordInCsv in recordsInCsv)
            {
                var record = recordInCsv.Split(',');
                Employee employee = new Employee();
                employee.Name = record[0];
                employee.Dob = record[1];
                employee.Role = record[2];
                employee.StartDate = record[3];
                employee.StartSalary = record[4];
                //Thêm thông tin 1 nhân viên đọc từ file csv vào danh sách Nhân viên
                employees.Add(employee);
            }
            //Trả về danh sách nhân viên đọc đươc từ file csv
            return employees;
        }

        /// <summary>
        /// Đọc dữ liệu từ file csv
        /// </summary>
        /// <param name="fileName">Đường dẫn file</param>
        /// <returns>Danh sách từng dòng từ file csv</returns>
        public static List<String> ReadCSVFile(string fileName)
        {
            List<String> recordsInCsv = new List<String>();
            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    int row = 1;
                    while (!reader.EndOfStream)
                    {
                        if(row <= HEADER_ROWS)
                        {
                            reader.ReadLine();
                            row++;
                            continue;
                        }
                        //Đọc từng dòng trong file csv
                        var record = reader.ReadLine();
                        //Thêm dòng đọc được vào danh sách
                        recordsInCsv.Add(record);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                //Lỗi không đọc được file
            }
            //Trả về danh sách các dòng trong file csv
            return recordsInCsv;
        }
    }
}
