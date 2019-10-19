using System;
using System.Collections.Generic;
using System.Text;

namespace Bridgelabz.ObjectOriented.CommercialDataProcessing
{
    class TransactionStatus
    {
        DataStructure.Utility.Stack<StockStatus> transactionstatus;

        public TransactionStatus()
        {
            transactionstatus = new DataStructure.Utility.Stack<StockStatus>();
        }

        public void Add(StockStatus stockStatus)
        {
            transactionstatus.push(stockStatus);
        }


    }
}
