using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class HourlyEmployee:Employee
    {

        public decimal HourlyRate { get; set; }

        public HourlyEmployee() : base()
        {
            HourlyRate = 15.0M;
        }

        public HourlyEmployee(int empNum, string firstName, string lastName, decimal hourlyRate) 
            : base(empNum,firstName,lastName)
        {
            HourlyRate = hourlyRate;
        }

        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + HourlyRate + " per hour.";
            }
        }

        public override decimal Pay(int start, int end)
        {
            double hours = 0;

            for (int day = start; day < end; ++day)
            {
                hours += Hours[day];
            }
            return (decimal)hours * HourlyRate;
        }


        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
