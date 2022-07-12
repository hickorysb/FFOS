using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFOS
{
    static class DatabaseConnector
    {
        private static bool connected;
        //TO-DO: REMOVE WHEN ADDING REAL DATA
        private static Employee[] data = new Employee[5];

        public static Employee[] employees;

        public static bool ConnectToDatabase()
        {
            return true;
        }

        public static bool PullEmployeeData()
        {
            Dictionary<int, string> jobs = new Dictionary<int, string>();
            jobs.Add(157, "Manager");
            jobs.Add(1, "Crew");
            Dictionary<int, double> pay = new Dictionary<int, double>();
            pay.Add(157, 16.00);
            pay.Add(1, 11.00);
            data[0] = new Employee(1113674, "Jackson", "Abney", 0, jobs, pay);
            data[1] = new Employee(1113789, "Ezra", "Gilmore", 1);
            data[2] = new Employee(1113954, "Ethan", "Brandt", 2);
            data[3] = new Employee(1524852, "Steve", "Fall", 3);
            data[4] = new Employee(1125854, "Tracy", "Stevens", 4);
            employees = new Employee[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                employees[i] = data[i];
            }
            return true;
        }

        public static Employee GetEmployeeByEID(int uid)
        {
            return employees.Where((Employee e) => e.getEmployeeID() == uid).DefaultIfEmpty(null).First();
        }
    }
}
