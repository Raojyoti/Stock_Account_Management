using System;

namespace JSON_Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stock Inventory Management");
            StockAccountManagement management = new StockAccountManagement();
            string stockFilePath = @"E:\Stock_Account_Problems\Stock_Account_Management\JSON Problems\Stock.json";
            string customerFilePath = @"E:\Stock_Account_Problems\Stock_Account_Management\JSON Problems\Customer.json";
            management.ReadStockJsonFile(stockFilePath);
            management.ReadCustomerJsonFile(customerFilePath);
            management.BuyStock("Myntra");
            management.SellStock("Myntra");
            management.WriteToStockJsonFile(stockFilePath);
            management.WriteToCustomerJsonFile(customerFilePath);
        }
    }
}
