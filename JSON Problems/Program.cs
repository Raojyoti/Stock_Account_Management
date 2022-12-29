using System;

namespace JSON_Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stock Inventory Management");
            StockAccountManagement management=new StockAccountManagement(); 
            string stockFilePath = @"E:\Angular projects\Json_Problems\JSON Problems\Stock.json";
            management.ReadStockJsonFile(stockFilePath);
            string customerFilePath = @"E:\Angular projects\Json_Problems\JSON Problems\Customer.json";
            management.ReadCustomerJsonFile(customerFilePath);
            management.BuyStock("Myntra");
            management.WriteToStockJsonFile(stockFilePath);
            management.WriteToStockJsonFile(customerFilePath);
        }
    }
}
