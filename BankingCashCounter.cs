// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BankingCashCounter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Customer Detail
    /// </summary>
    public class BankingCashCounter
    {
        internal class Customer : IComparable
        {
            private String cName;
            private String accountNo;   
            private Double balance;

            public Customer(String cName, String accountNo, Double balance)
            {
                this.cName = cName;
                this.accountNo = accountNo;
                this.balance = balance;
            }
            public Double getBalance()
            {
                return balance;
            }

            public String getAccountNo()
            {
                return accountNo;
            }

            public String getcName()
            {
                return cName;
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
            public void Deposit(Double amount)
            {
                balance = balance + amount;
            }
            public void Withdraw(Double amount)
            {
                balance = balance - amount;
            }
        }

        public static void Main(String[] args)
        {
            ////Defining customers

            Customer customer1 = new Customer("Robin Kumar","32339923507",50000);
            Customer customer2 = new Customer("Robin Ku", "32339923508", 50000);
            Customer customer3 = new Customer("Robin K", "32339923509", 50000);
            Customer customer4 = new Customer("Rob", "32339923510", 50000);
            Customer customer5 = new Customer("Roby", "32339923511", 50000);

            ////Adding Customer To list
            Utility.UnOrderedList<Customer> list = new Utility.UnOrderedList<Customer>();
            Utility.Queue<Customer> cashCounter = new Utility.Queue<Customer>();
            list.Add(customer1);
            list.Add(customer1);
            list.Add(customer1);
            list.Add(customer1);
            list.Add(customer1);
            ////Taking Customer from list and adding in Queue
            while(list.Size() > 0)
            {
                Console.Clear();
                Customer processingCustomer = list.Pop();
                cashCounter.Enqueue(processingCustomer);
                ////Processing Customer Request in Queue and removing them from Queue
                Console.WriteLine("1.Deposit   2.Withdraw 3.View Balance");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Amount:");
                        double amount = Convert.ToInt32(Console.ReadLine());
                        processingCustomer.Deposit(amount);
                        Console.WriteLine("New balance:" + processingCustomer.getBalance());
                        cashCounter.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("Amount:");
                        amount = Convert.ToInt32(Console.ReadLine());
                        processingCustomer.Withdraw(amount);
                        Console.WriteLine("New balance:" + processingCustomer.getBalance());
                        cashCounter.Dequeue();
                        break;

                    case 3:
                        Console.WriteLine("Balance:" + processingCustomer.getBalance());
                        cashCounter.Dequeue();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
               
                
                
            


        }





    }
}
