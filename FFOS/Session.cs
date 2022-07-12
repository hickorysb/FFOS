using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFOS
{
    class Session
    {
        private DateTime loginTime = DateTime.Now;
        private Employee loggedInEmployee;
        private bool validSession;
        public bool EmployeeFound;
        public bool EmployeeClockedIn;

        public Session(int uid)
        {
            loggedInEmployee = DatabaseConnector.GetEmployeeByEID(uid);
            validSession = true;
            EmployeeFound = loggedInEmployee != null ? true : false;
            if (EmployeeFound)
            {
                EmployeeClockedIn = loggedInEmployee.isEmployeeClockedIn();
            }
        }

        public Employee GetSignedInEmployee()
        {
            return loggedInEmployee;
        }

        public bool IsSessionEmployeeClockedIn()
        {
            return loggedInEmployee.isEmployeeClockedIn();
        }

        public bool IsValidSession()
        {
            if (validSession && loggedInEmployee != null && loggedInEmployee.isEmployeeClockedIn())
            {
                return true;
            }
            else
            {
                validSession = false;
                return false;
            }
        }
    }
}
