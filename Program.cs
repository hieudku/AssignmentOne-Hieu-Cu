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
            Console.WriteLine("Please enter the number of sales record");
            int recordNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the following: ");
            for (int i = 0; i < recordNumber; i++)
            {
                Console.WriteLine("Product ID: ");
                string productId = Console.ReadLine();
                string[] IdArr = new string[recordNumber];


                Console.WriteLine("Quantity sold: ");
                int soldQuant = int.Parse(Console.ReadLine());
                int[] soldArr = new int[recordNumber];


                Console.WriteLine("Sales amount: ");
                double salesAmount = Convert.ToDouble(Console.ReadLine());
                double[] salesArr = new double[recordNumber];
            }
        }

    }
    static class GetRecords
    {
        static void Record(string productId, int soldQuant, double salesAmount)
        {
            
        }
    }
}
