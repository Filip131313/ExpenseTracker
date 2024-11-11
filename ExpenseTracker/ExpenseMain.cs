using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExpenseTracker
{

    
    internal class ExpenseMain
    {
        private DateTimeClass timeClass;
        private MoneyExpenseDetails moneyExpenseDetails;

        // U Constructoru pozivam class MoneyExpenseDetails i class DateTime i printujem u consoli preko Program.cs
        
        public ExpenseMain()
        {
            PrintMainProgram();
        }

        private void PrintMainProgram()
        {
            timeClass = new DateTimeClass();
            Console.WriteLine($"{timeClass.DateNow()}");
            moneyExpenseDetails = new MoneyExpenseDetails();
        }


    }
}
