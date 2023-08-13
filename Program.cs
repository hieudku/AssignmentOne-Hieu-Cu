using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne_Hieu_Cu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int recordNumber;
            double soldQuant;
            double salesAmount;
            double totalSales;
            string[] IdArr;
            double[] soldArr;
            double[] salesArr;
            Console.WriteLine("Please enter the number of sales record");
            recordNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the following: ");
            for (int i = 0; i <= recordNumber; i++) // Determine the number of records.
            {
                Console.WriteLine("Product ID: ");
                string productId = Console.ReadLine();
                IdArr = new string[recordNumber];
                for (int x = 0; x < IdArr.Length; x++) // Iterate & assign each array index as each input value.
                {
                    IdArr[x] = productId;

                }

                Console.WriteLine("Quantity sold: ");
                soldQuant = int.Parse(Console.ReadLine());
                soldArr = new double[recordNumber];
                for (int y = 0; y < IdArr.Length; y++) // Iterate & assign each array index as each input value.
                {
                    soldArr[y] = soldQuant;

                }

                Console.WriteLine("Sales amount: ");
                salesAmount = Convert.ToDouble(Console.ReadLine());
                salesArr = new double[recordNumber];
                for (int z = 0; z < IdArr.Length; z++) // Iterate & assign each array index as each input value.
                {
                    salesArr[z] = salesAmount;
                }
                totalSales = Multiply(soldQuant, salesAmount);
                Console.WriteLine($"Total Sales for product #{productId} is {totalSales}");
            }// End of recordNumber for loop.

        }// End of Main
        static double Multiply(double sold, double amount)
        {
            double total = sold * amount;
            return total;
        }
    }
}
