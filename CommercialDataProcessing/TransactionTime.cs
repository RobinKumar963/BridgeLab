using System;
using System.Collections.Generic;
using System.Text;
using Bridgelabz.DataStructure;

namespace Bridgelabz.ObjectOriented.CommercialDataProcessing
{
    class TransactionTime
    {
        DataStructure.Utility.Queue<String> transactiontime;

        public TransactionTime(Utility.Queue<string> transactiontime)
        {
            this.transactiontime = transactiontime;
        }
        public TransactionTime()
        {
            this.transactiontime = new DataStructure.Utility.Queue<string>();
        }
        public void Add(string date)
        {
            transactiontime.Enqueue(date);
        }
    }
}
