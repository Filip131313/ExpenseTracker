using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    internal class ExpenseDetails
    {

        private string spent_location;
        private string earn_location;

        public string Spent_Location
        {
            get { return spent_location; }
            private set
            {
                spent_location = string.IsNullOrEmpty(value) ? "Today nothing" : value;
            }
        }

        public string Earn_Location
        {
            get { return earn_location; }
            private set
            {
                earn_location = string.IsNullOrEmpty(value) ? "Today nothing" : value;
            }
        }

        // Constructor --------------------------
        public ExpenseDetails()
        {

        }
        // End Constructor --------------------------

        // ----------------------------------- Method SWhereISpentMoney ---------------------------------------
        public string SWhereISpentMoney(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Today you didn't spend anything");
                return "Today nothing";
            }
            Spent_Location = input;
            return Spent_Location;
        }

        // ----------------------------------- Method SWhereISpentMoney ---------------------------------------

        // ----------------------------------- End Method EWhereIEarnMoney ---------------------------------------
        public string EWhereIEarnMoney(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Today you didn't earn anything");
                return "Today nothing";
            }
            Earn_Location = input;
            return Earn_Location;
        }

        // ----------------------------------- End Method EWhereIEarnMoney ---------------------------------------

    }
}
