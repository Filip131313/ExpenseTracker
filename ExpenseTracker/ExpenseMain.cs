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
        private SqlConnection sqlConnection;
        private string connectionString = ConfigurationManager.ConnectionStrings["ExpenseTracker.Properties.Settings.FilipDBConnectionString"].ConnectionString;
        private DateTimeClass timeClass;
        private MoneyExpenseDetails moneyExpenseDetails;
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




        // OVO ISPOD MI JE ZA POVEZIVANJE SA SQL TO CU ODRADITI POSLE


        // Klasa za kasnije, kada budem vec napravio sve sto je potrebno za izvrsavanje, onda cu da povezem sa SQL ------------------------
        private void DaNEZaboravim()
        {
            sqlConnection = new SqlConnection(connectionString);
            string query = "select * from ExpenseTracker";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
        }
         
        // Stavicu While petlju da moze da se ocitava dok god ne napisem u consoli q ili space i enter, tako nesto, onda se while petlja zavrsava i pocinje nova while petlja 
        // za earn i earn String (details) ili cu staviti sve u jedan while, videcemo
    }
}
