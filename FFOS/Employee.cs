using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFOS
{
    public class Employee
    {
        private String firstName;
        private String lastName;
        private int employeeID;
        private int permissionLevel;
        private int clockedInAs;
        private double clockedInRateOfPay;
        private Dictionary<int, string> employeePositions;
        private Dictionary<int, double> rateOfPay;
        private bool clockedIn;
        
        public Employee(int eid, String fname, String lname, int plev, Dictionary<int, string> jobCodes = null, Dictionary<int, double> rop = null, bool clockInState = false)
        {
            employeeID = eid;
            firstName = fname;
            lastName = lname;
            permissionLevel = plev;
            clockedIn = clockInState;
            if (jobCodes == null)
            {
                employeePositions = new Dictionary<int, string>();
            } else
            {
                employeePositions = jobCodes;
            }
            if (rop == null)
            {
                rateOfPay = new Dictionary<int, double>();
            } else
            {
                rateOfPay = rop;
            }
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

        public Dictionary<int, string> getJobCodes()
        {
            return employeePositions;
        }

        public String[] getEmployeeNames()
        {
            string[] names = { firstName, lastName };
            return names;
        }

        public void clockIn(int jobCode, double rateOfPay)
        {
            clockedIn = true;
            clockedInAs = jobCode;
            clockedInRateOfPay = rateOfPay;
        }

        public void clockOut()
        {
            clockedIn = false;
        }

        public double getPayRate(int jobCode)
        {
            return rateOfPay[jobCode];
        }

        public bool isEmployeeClockedIn()
        {
            return clockedIn;
        }
    }
}
