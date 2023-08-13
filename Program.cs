using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne_Hieu_Cu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int recordNumber;
            double soldQuant;
            double salesAmount;
            string[] IdArr;
            double[] soldArr;
            double[] salesArr;
            Console.WriteLine("Please enter the number of sales record");
            recordNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the following: ");
            for (int i = 0; i <= recordNumber; i++)
            {
                Console.WriteLine("Product ID: ");
                string productId = Console.ReadLine();
                IdArr = new string[recordNumber];
                for (int x = 0; x < IdArr.Length; x++)
                {
                    IdArr[x] = productId;
                }

                Console.WriteLine("Quantity sold: ");
                soldQuant = int.Parse(Console.ReadLine());
                soldArr = new double[recordNumber];
                for (int y = 0; y < IdArr.Length; y++)
                {
                    soldArr[y] = soldQuant;
                }

                Console.WriteLine("Sales amount: ");
                salesAmount = Convert.ToDouble(Console.ReadLine());
                salesArr = new double[recordNumber];
                for (int z = 0; z < IdArr.Length; z++)
                {
                    salesArr[z] = salesAmount;
                }
                GetTotal(soldQuant, salesAmount);
            }
        }
        static double GetTotal(double sold, double amount)
        {
            double total = sold * amount;
            Console.WriteLine($"Total: {total}");
            return total;
        }
    }
}
