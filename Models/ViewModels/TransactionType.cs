using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class TransactionType
    {
        public int Type { get; set; }
        public string TransactionTypeName { get; set; }
        public List<TransactionType> TransactionTypes => new List<TransactionType>()
        {
            new TransactionType() { Type=1, TransactionTypeName="BEGINNING BALANCE"},
            new TransactionType(){Type=2,TransactionTypeName="IN"},
            new TransactionType(){Type=3,TransactionTypeName="OUT"},
            new TransactionType() { Type=4, TransactionTypeName="NEW TRANSACTION"},
        };
    }

    public enum Transaction
    {
        BEGINNING =1 ,
        IN = 2,
        OUT = 3,
        NEW = 4,
        


    }

   
}
