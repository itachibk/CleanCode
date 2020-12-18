/// <summary>
/// **************************************
/// 
/// Đối tượng nhân viên
/// 
/// **************************************
/// <summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Employee
    {
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ngày sinh 
        /// </summary>
        public string Dob { get; set; }

        /// <summary>
        /// Chức vụ
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Ngày bắt đầu làm
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Lương khởi điểm
        /// </summary>
        public string StartSalary { get; set; }
    }
}
