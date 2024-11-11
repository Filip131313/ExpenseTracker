using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    internal class MoneyExpenseDetails
    {
        private int _balans;

        private int _spent;
        private int _earned;

        private int _amount;
        private ExpenseDetails _details;
        public MoneyExpenseDetails()
        {
             StartProgram();
        }

        // -------------------------------- Method StartProgram ------------------------------------------

        private void StartProgram()
        {

            _details = new ExpenseDetails();

            try
            {
                // Unos početnog stanja 
                Console.WriteLine("I have balans: ");
                _balans = int.Parse(Console.ReadLine());
                Console.WriteLine();
                bool moneySpentFlag = true;

                while (moneySpentFlag)
                {
                    // Unos potrošenog iznosa
                    Console.WriteLine("I spent: ");
                    string spendInput = Console.ReadLine();

                    // Proveravamo da li je unos 0 ili "q" za izlaz iz petlje
                    if (spendInput == "0" || spendInput.ToLower() == "q")
                    {
                        moneySpentFlag = false; 
                        break;
                    }

                    int spendINT;
                    if (int.TryParse(spendInput, out spendINT))
                    {
                        _spent = ResultAmount(spendINT, "spent");
                        Console.WriteLine("Where did you SPENT that money: ");
                        string spent = Console.ReadLine();
                        _details.SWhereISpentMoney(spent);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number or '0' or 'q' to continue.");
                    }
                }

                // while loop za zaradjivanje novca -------------------
                bool moneyEarnedFlag = true;
                Console.WriteLine();
                while (moneyEarnedFlag)
                {
                    // Unos zarađenog iznosa
                    Console.WriteLine("I earned: ");
                    string earnInput = Console.ReadLine();

                    // Proveravamo da li je unos 0 ili "q" za izlaz iz petlje
                    if (earnInput == "0" || earnInput.ToLower() == "q")
                    {
                        moneyEarnedFlag= false; 
                        break;
                    }

                    int earnedINT;
                    if (int.TryParse(earnInput, out earnedINT))
                    {
                        _earned = ResultAmount(earnedINT, "earned");
                        Console.WriteLine("Where did you EARN that money: ");
                        string earned = Console.ReadLine();
                        _details.EWhereIEarnMoney(earned);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number or '0' or 'q' to continue.");
                    }

                }
                // Prikaz rezultata
                Console.WriteLine($"{_balans} You spent today {_spent} and earned {_earned}");
                _balans -= _spent;
                _balans += _earned;
                Console.WriteLine($"Balance after {_balans}");
            }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong input");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Don't spent to much, you need that money :D");
                }
        }

        // -------------------------------- End Method StartProgram ------------------------------------------


        // -------------------------------- Method ResultAmount ------------------------------------------
        private int ResultAmount(int amount, string type)
        {
            string currency = Currency();
            int resultAmount = ConvertCurrency(amount, currency, type);
            return resultAmount;
        }

        // -------------------------------- End Method ResultAmount ------------------------------------------

        // -------------------------------- Method ConvertCurrency ------------------------------------------
        private int ConvertCurrency(int amount, string currency, string type)
        {
            int result = 0;

            if (currency.Equals("USD"))
            {
                result = (int)(amount * 107.7);
            }
            else if (currency.Equals("EUR"))
            {
                result = (int)(amount * 117.89);
            }
            else if (currency.Equals("RSD"))
            {
                result = amount;
            }
            else
            {
                Console.WriteLine("Invalid currency.");
            }
            return result;
        }

        // -------------------------------- End Method ConvertCurrency ------------------------------------------



        // ---------------------------------- Method Currency ----------------------------------------
        private string Currency()
        {
            string currency = "";
            Console.WriteLine("Which Currency: \n1) RSD\n2) Eur\n3) USD");
            int response = int.Parse(Console.ReadLine());

            switch (response)
            {
                case 1:
                    Console.WriteLine("Your currency is Serbian Dinar");
                    Console.WriteLine();
                    currency = "RSD";
                    break;
                case 2:
                    Console.WriteLine("Your currency is Euro");
                    Console.WriteLine();
                    currency = "EUR";
                    break;
                case 3:
                    Console.WriteLine("Your currency is Dollar");
                    Console.WriteLine();
                    currency = "USD";
                    break;
                default:
                    Console.WriteLine("No Currency");
                    Console.WriteLine();
                    break;
            }
            return currency;
        }

        // ---------------------------------- End Method Currency ----------------------------------------

    }
}
