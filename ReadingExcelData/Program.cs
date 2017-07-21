using System;

namespace ReadingExcelData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Populate data in collection
            ExcelUtil.PopulateInCollection("./Data.xlsx");
            //Read data from Excel Sheet
            Console.WriteLine($"UserName: {ExcelUtil.ReadData(1, "UserName")} and Password: {ExcelUtil.ReadData(1, "Password")}");

            Console.Read();
        }
    }
}
