using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class NegativeBalanceException:ApplicationException
    {
        public NegativeBalanceException(string exceptionType) : base(exceptionType)
        {

        }
    }
}
