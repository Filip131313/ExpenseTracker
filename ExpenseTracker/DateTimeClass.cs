using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    internal class DateTimeClass
    {

        private DateTime _date;

        public DateTimeClass()
        {
            
        }

        public DateTime DateNow()
        {
            _date = DateTime.Now;
            return _date;
        }
    }
}
