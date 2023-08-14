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
            Record sale = new Record(); // Create object instance of Record class.
            sale.GetRecord(); // Call method from Record class.
        }
    }
    class Record // parent class
    {
        public int recordsNumber;
        public string prodId;
        public double quantSold;
        public double salesAmount;
        public string[] productArr;
        public double[] quantArr;
        public double[] amountArr;
        public void GetRecord()
        {
            Console.WriteLine("Enter the number of records: ");
            recordsNumber = int.Parse(Console.ReadLine());
            productArr = new string[recordsNumber];
            quantArr = new double[recordsNumber];
            amountArr = new double[recordsNumber];

            for (int i = 0; i < recordsNumber; i++) { // For loop to ask for values according to number of records.
                Console.WriteLine("Product ID: ");
                prodId = Console.ReadLine();
                    productArr[i] = prodId;

                Console.WriteLine("Quantity sold: ");
                quantSold = Convert.ToDouble(Console.ReadLine());
                    quantArr[i] = quantSold ;

                Console.WriteLine("Sales amount: ");
                salesAmount = Convert.ToDouble(Console.ReadLine());
                    amountArr[i] = salesAmount;
            }
            for (int i = 0; i < recordsNumber; i++)
            {
                Console.WriteLine(amountArr[i]);
            }

            GetTotalSales arr = new GetTotalSales(); // Create object instance of GetArray class.
            double[] totalAmount = arr.GetTotalArr(quantArr, amountArr); // Assign new array to store all total sales amount by calling array method which calculate them.
                                                                           

            for (int t = 0; t < totalAmount.Length; t++)
            {
                Console.WriteLine(totalAmount[t]);
            }
        }
    }
    class GetTotalSales : Record // Child class of Record. Parse array to GetTotalArr method.
    {
        public double[] GetTotalArr(double[] quantArr, double[] amountArr)
        {
            double[] totalAmount = new double[amountArr.Length];
            for (int i = 0; i < amountArr.Length; i++)
            {
                totalAmount[i] = quantArr[i] * amountArr[i]; // Iterate through amountArr array to work out each total amount (quantity * amount) of the products.
            }
            return totalAmount; // Return totalAmount back to where it was called (Record class).
        }
    }
}
