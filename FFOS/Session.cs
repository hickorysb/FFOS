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

        public Session(int uid)
        {
            loggedInEmployee = DatabaseConnector.GetEmployeeByEID(uid);
            validSession = true;
        }

        public Employee GetSignedInEmployee()
        {
            return loggedInEmployee;
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
