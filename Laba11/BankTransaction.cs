using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laba11
{
    namespace Banking
    {
        class BankTransaction
        {
            private readonly decimal summa;
            private readonly DateTime when;
            public decimal Summa()
            {
                return summa;
            }
            public DateTime When()
            {
                return when;
            }
            public BankTransaction(decimal summa)
            {
                this.summa = summa;
                when = DateTime.Now;
            }
        }
    }
}

