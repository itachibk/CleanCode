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
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        /// <summary>
        /// Ngày sinh 
        /// </summary>
        private string Dob;

        public string dob
        {
            get { return Dob; }
            set { Dob = value; }
        }

        /// <summary>
        /// Chức vụ
        /// </summary>
        private string Role;

        public string role
        {
            get { return Role; }
            set { Role = value; }
        }

        /// <summary>
        /// Ngày bắt đầu làm
        /// </summary>
        private string StartDate;

        public string startDate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }

        /// <summary>
        /// Lương khởi điểm
        /// </summary>
        private string StartSalary;

        public string startSalary
        {
            get { return StartSalary; }
            set { StartSalary = value; }
        }



        /// <summary>
        /// Tính số tuổi của nhân viên
        /// </summary>
        /// <returns></returns>
        public int caculateAge()
        {
            int age;
            DateTime birthDay = Common.ToDateTime(this.dob, "yyyyMMdd", "tr-TR");
            DateTime timeNow = DateTime.Today;
            try 
	        {	        
		        age = (int)Common.caculateMonthsDifference(birthDay,timeNow)/12;
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }

            return age;
        }

        public double caculateSalaryNow()
        {
            int yearWorking = this.caculateYearWorking() -1;
            return Int32.Parse(this.startSalary) * Math.Pow(1.6, yearWorking);

        }

        public int caculateYearWorking()
        {
            int yearWorking;
            DateTime startDate = Common.ToDateTime(this.startDate, "yyyyMMdd", "tr-TR");
            DateTime timeNow = DateTime.Today;
            try
            {
                yearWorking = (int)Common.caculateMonthsDifference(startDate, timeNow)/12;
            }
            catch (Exception)
            {

                throw;
            }

            return yearWorking;
        }
    }
}
