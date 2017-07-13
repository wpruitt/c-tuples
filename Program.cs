using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
         List<(string, double, int)> transactions = new List<(string, double, int)>();  
         transactions.Add(("Shoelace", 2.50, 10));
         transactions.Add(("Buttons", 0.50, 8));
         transactions.Add(("Hat", 15.50, 4));
         transactions.Add(("T-shirt", 9.50, 5));
         transactions.Add(("Glasses", 22.10, 3));
         int totalSold = 0;
         double totalAmount = 0;
         foreach ((string product, double amount, int quantity) t in transactions)
         {
             totalSold += t.quantity;
             totalAmount += t.amount;
         }
         Console.WriteLine("Items sold today: " + totalSold);
         Console.WriteLine("Total revenue: " + totalAmount);
        }
    }
}
