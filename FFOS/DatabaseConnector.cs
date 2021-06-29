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
            DatabaseConnector.data[0] = new Employee(1113674, "Jackson", "Abney", 0);
            DatabaseConnector.data[1] = new Employee(1113789, "Ezra", "Gilmore", 1);
            DatabaseConnector.data[2] = new Employee(1113674, "Ethan", "Brandt", 2);
            DatabaseConnector.data[3] = new Employee(1113674, "Steve", "Fall", 3);
            DatabaseConnector.data[4] = new Employee(1113674, "Tracy", "Stevens", 4);
            for (int i = 0; i < data.Length; i++)
            {

            }
            return true;
        }
    }
}
