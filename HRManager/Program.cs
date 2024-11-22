using HRManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hourEmp = new HourlyEmployee(2, "Bill", "Gates", 15.00M);
            PhoneBook pb = new PhoneBook();
            pb.PhoneBookEntries.Add(hourEmp);
            hourEmp.Hours.Add(80.0);
            hourEmp.Hours.Add(90.0);
            hourEmp.Hours.Add(70.0);

            DisplayEmployeeInfo(hourEmp,0,3);

            SalaryEmployee salaryEmp = new SalaryEmployee();
            _ = new PhoneBook();
            pb.PhoneBookEntries.Add(salaryEmp);
            salaryEmp.EmpNum = 2;
            salaryEmp.FirstName = "Alan";
            salaryEmp.LastName = "Turing";
            salaryEmp.Salary = 40000.0M;
            salaryEmp.Hours.Add(80.0);
            salaryEmp.Hours.Add(80.0);
            salaryEmp.Hours.Add(80.0);

            DisplayEmployeeInfo(salaryEmp, 0, 3);

            Department dep = new Department("Sales Department");
            _ = new PhoneBook();
            pb.PhoneBookEntries.Add(hourEmp);
            pb.PhoneBookEntries.Add(salaryEmp);
            pb.PhoneBookEntries.Add(dep);

            Console.WriteLine(pb.GetPhoneBook());


            List<Employee> myEmployees = new List<Employee>();
            myEmployees.Add(salaryEmp);
            myEmployees.Add(hourEmp);
            decimal payroll = 0;
            foreach (Employee employee in myEmployees)
            {
                payroll += employee.Pay(0, 3);
            }
            Console.WriteLine("Payroll total for 0-2: " + payroll.ToString());
            Console.WriteLine();

            foreach (Employee employee in myEmployees)
            {

                Console.WriteLine("Employee: " + employee);
                if (employee is HourlyEmployee)
                {
                    //HourlyEmployee hourlyEmp = employee as HourlyEmployee;
                    HourlyEmployee hourlyEmp = (HourlyEmployee) employee;
                    Console.WriteLine("Hourly rate: " + hourlyEmp.HourlyRate);
                }
                if (employee is SalaryEmployee)
                {
                    SalaryEmployee salEmp = employee as SalaryEmployee;
                    Console.WriteLine("Salary: " + salEmp.Salary);
                }
            }
        }

        private static void DisplayEmployeeInfo(Employee emp, int payStart, int payEnd)
        {
            Console.WriteLine(emp.ToString());
            Console.WriteLine(emp.PaySummary);
            Console.WriteLine("Pay for periods " + payStart + "-" + payEnd + ": "
                + emp.Pay(payStart, payEnd).ToString("c"));
            Console.WriteLine();
        }

    }
}
