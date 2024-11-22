using InheritanceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    class Department : IPhoneBookItem
    {
        public string Name { get; set; }
        public Employee Manager { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }

        public Department(string name, Employee manager = null, string description = "TBD", string phone = "TBD", string email = "TBD", string website = "TBD")
        {
            Name = name;
            Manager = manager;
            Description = description;
            Phone = phone;
            Email = email;
            WebSite = website;
        }

        public string GetContactSummary()
        {
            return "Department: " + Name + "\n" +
                    Description + "\n" +
                    "Phone: " + Phone + "\n" +
                    "Email: " + Email + "\n" +
                    "Web site: " + WebSite;
        }
    }
}
