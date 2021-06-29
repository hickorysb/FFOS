using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFOS
{
    class Employee
    {
        private String firstName;
        private String lastName;
        private int employeeID;
        private int permissionLevel;

        public Employee(int eid, String fname, String lname, int plev)
        {
            employeeID = eid;
            firstName = fname;
            lastName = lname;
            permissionLevel = plev;
        }

        public int getPermissionLevel()
        {
            return permissionLevel;
        }

        public int getEmployeeID()
        {
            return employeeID;
        }

        public String getEmployeeName()
        {
            return firstName + " " + lastName;
        }

        public String[] getEmployeeNames()
        {
            string[] names = { firstName, lastName };
            return names;
        }
    }
}
