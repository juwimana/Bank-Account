using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class NegativeDepositException:ApplicationException
    {
        public NegativeDepositException(string exceptionType): base (exceptionType)
        {

        }
    }
}
