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
            Console.WriteLine("**********Welcome to Sales Analysis Application**********");

            Record sale = new Record(); // Create object instance of Record class.
            sale.GetRecord(); // Call method from Record class.

            Console.WriteLine("*************************END*****************************");
        }
    }
    class Record // parent class
    {
        public int recordsNumber;
        public double prodId;
        public double quantSold;
        public double salesAmount;
        public double topProd;
        public int highestProd;
        public double[] productArr;
        public double[] quantArr;
        public double[] amountArr;
        public double[] totalAmountArr;
        public void GetRecord()
        {
            Console.WriteLine("Enter the number of records: ");
            recordsNumber = int.Parse(Console.ReadLine());
            productArr = new double[recordsNumber];
            quantArr = new double[recordsNumber];
            amountArr = new double[recordsNumber];

            for (int i = 0; i < recordsNumber; i++)
            { // For loop to ask for values according to number of records.
                Console.WriteLine("Enter Product ID: ");
                prodId = Convert.ToDouble(Console.ReadLine());
                productArr[i] = prodId; // As array index increment, assign the next input to that index.

                Console.WriteLine("Enter Quantity sold: ");
                quantSold = Convert.ToDouble(Console.ReadLine());
                quantArr[i] = quantSold;

                Console.WriteLine("Enter Sales amount: ");
                salesAmount = Convert.ToDouble(Console.ReadLine());
                amountArr[i] = salesAmount;
            }
            /* Class object creation and Method calls */
            GetTotalSales total = new GetTotalSales(); // Create object instance of GetTotalSales class.
            totalAmountArr = total.GetTotalArr(quantArr, amountArr); // Assign new array to store all total sales amount by calling array method that has quantity and amount as parameters, which then parsed onto the method to calculate.

            Console.WriteLine("Total amount in sales: ");
            for (int t = 0; t < totalAmountArr.Length; t++)
            {
                Console.WriteLine($"Product ID # {productArr[t]} -- {totalAmountArr[t]}  ");
            }

            GetHighestSale highest = new GetHighestSale();
            highestProd = highest.HighestSales(totalAmountArr);
            Console.WriteLine($"Product ID with the highest sales: {productArr[highestProd]}");

        }
    }//End of Record Class.
    class GetTotalSales // Child class of Record. Parse array to GetTotalArr method.
    {
        public double[] GetTotalArr(double[] quantArr, double[] amountArr)
        {
            double[] totalAmount = new double[amountArr.Length];
            for (int i = 0; i < amountArr.Length; i++)
            {
                totalAmount[i] = quantArr[i] * amountArr[i]; // Iterate through amountArr array to work out each total amount (quantity * amount) of the products according to their index.
            }
            return totalAmount; // Return totalAmount back to where it was called (Record class).
        }
    }// End of GetTotalSales Class.
    class GetHighestSale
    {
        public int HighestSales(double[] totalAmountArr) // .
        {
            double highestSale = 0;
            int productId = 0; //Assign to 0 as starting point.
            bool foundHighest = false;
            for (int i = 0; i < totalAmountArr.Length; i++) // Loop to find the product ID with highest total sales by iterating through the total sales array
            {
                if (totalAmountArr[i] > highestSale) // Compare the current highest sales vs each index of the total sales array.
                {
                    highestSale = totalAmountArr[i]; //update the current highest sales every round.
                    productId = i; // Also update the ID to the current value of i every round.
                    foundHighest = true;
                }
            }
            if (foundHighest) // Once loop finished, and foundHighest is true, execute to return productId.
            {
                return productId;
            }
            return productId;
        }
    }// End of GetHighestSale Class.
    class GetAverage
    {
        public double Average(double[] totalAmountArr)
        {
            double average;
            double sum = 0;
            for (int i =0; i < totalAmountArr.Length; i++)
            {
                sum += totalAmountArr[i];
            }

            return 0;
        }
    }
}
