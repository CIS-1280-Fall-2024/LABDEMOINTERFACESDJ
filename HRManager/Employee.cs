using HRManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public abstract class Employee:IPhoneBookItem
    {
        public Employee():this(-1, "TBD","TBD")
        {
            
        }

        public Employee(int empNum, string firstName, string lastName)
        {
            EmpNum = empNum;
            FirstName = firstName;
            LastName = lastName;
        }

        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string PaySummary
        {
            get;
        }

        private List<double> hours = new List<double>();

        public List<double> Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public abstract Decimal Pay(int start, int end);

        public override string ToString()
        {
            return EmpNum + " " + FirstName + " "+LastName;
        }

        public string Phone { get; set; }
        public string Email { get; set; }

        public string GetContactSummary()
        {
            return FirstName + " " + LastName + "\n" +
                "Phone: " + Phone + "\n" +
                "Email: " + Email;

        }
    }
}
