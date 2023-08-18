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

            Record sale = new Record();                             // Construct object instances of Record class.
            sale.GetRecord();                                       // Call method from Record class.

            Console.WriteLine("*************************END*****************************");
        }
    }
    class Record // parent class
    {
        int recordsNumber;
        double prodId;
        double quantSold;
        double salesAmount;
        int highestProd;
        double average;
        double[] productArr;
        double[] quantArr;
        double[] amountArr;
        double[] totalAmountArr;

        bool ValidationDouble(string input, out double result)          // Validation check method for double values.
        {
            return double.TryParse(input, out result);
        }
        bool ValidationInt(string input, out int result)                // Validation check method for int values.
        {
            return int.TryParse(input, out result);
        }

        public void GetRecord()
        {
            Console.WriteLine("Enter the number of records: ");
            while(!ValidationInt(Console.ReadLine(), out recordsNumber)) // Call validation method to loop and ask for user input until valid.
            {
                Console.WriteLine("Please enter a valid value (number)");
                Console.WriteLine("Enter the number of records: ");
            }
            productArr = new double[recordsNumber];                     // Create array with size of recordsNumber value entered.
            quantArr = new double[recordsNumber];
            amountArr = new double[recordsNumber];

            for (int i = 0; i < recordsNumber; i++)                     // For loop to ask for values according to number of records.
            {                                                       
                Console.WriteLine("Enter Product ID: ");
                while (!ValidationDouble(Console.ReadLine(), out prodId))       // Call validation method to loop and ask for user input until valid.
                {
                    Console.WriteLine("Please enter a valid value (number)");
                    Console.WriteLine("Enter Product ID: ");
                }
                productArr[i] = prodId;                                         // As array index increment, assign the next input to that index.

                Console.WriteLine("Enter Quantity sold: ");
                while (!ValidationDouble(Console.ReadLine(), out quantSold))    // Call validation method to loop and ask for user input until valid.
                {
                    Console.WriteLine("Please enter a valid value (number)");
                    Console.WriteLine("Enter Quantity sold: ");
                }
                quantArr[i] = quantSold;

                Console.WriteLine("Enter Sales amount: ");
                while (!ValidationDouble(Console.ReadLine(), out salesAmount))  // Call validation method to loop and ask for user input until valid.
                {
                    Console.WriteLine("Please enter a valid value (number)");
                    Console.WriteLine("Enter Sales amount: ");
                }
                amountArr[i] = salesAmount;
            }
                                                                    /* Class objects constructors and Method calls */
            GetTotalSales total = new GetTotalSales();              // Construct object instance of GetTotalSales class.
            totalAmountArr = total.GetTotalArr(quantArr, amountArr);// Assign totalAmountArr to store all total sales amount by calling array method that has quantity and amount as parameters, which then parsed onto the method to calculate.

            Console.WriteLine("Total amount in sales: ");
            for (int t = 0; t < totalAmountArr.Length; t++)         // Loop to write each element of the totalAmountArr as total sales. 
            {
                Console.WriteLine($"Product ID # {productArr[t]} -- {totalAmountArr[t]}  ");
            }

            GetHighestSale highest = new GetHighestSale();          // Construct object instance of GetHighestlSales class.
            highestProd = highest.HighestSales(totalAmountArr);
            Console.WriteLine($"Product ID with the highest sales: {productArr[highestProd]}");

            GetAverage aver = new GetAverage();                     // Construct object instance of GetAverage class.
            average = aver.Average(totalAmountArr);
            Console.WriteLine($"The average sales amount of all products: {average}");
        }
    }                                                               //End of Record Class.
    class GetTotalSales : Record                                    // Child class of Record. 
    {
        public double[] GetTotalArr(double[] quantArr, double[] amountArr) // Parse 2 arrays as parameter to store quantity and amount array.
        {
            double[] totalAmount = new double[amountArr.Length];
            for (int i = 0; i < amountArr.Length; i++)
            {
                totalAmount[i] = quantArr[i] * amountArr[i];        // Iterate through amountArr array to work out each total amount (quantity * amount) of the products according to their index.
            }
            return totalAmount;                                     // Return totalAmount back to where it was called (Record class).
        }
    }                                                               // End of GetTotalSales Class.
    class GetHighestSale : Record                                   // Child class of Record.
    {
        public int HighestSales(double[] totalAmountArr) 
        {
            double highestSale = 0;
            int productId = 0;                                      //Assign to 0 as starting point.
            bool foundHighest = false;
            for (int i = 0; i < totalAmountArr.Length; i++)         // Loop to find the product ID with highest total sales by iterating through the total sales array
            {
                if (totalAmountArr[i] > highestSale)                // Compare the current highest sales vs each index of the total sales array.
                {
                    highestSale = totalAmountArr[i];                // Update the current highest sales every round.
                    productId = i;                                  // Also update the ID to the current value of i every round.
                    foundHighest = true;
                }
            }
            if (foundHighest)                                       // Once loop finished, and foundHighest is true, execute to return productId.
            {
                return productId;
            }
            return productId;
        }
    }                                                               // End of GetHighestSale Class.
    class GetAverage : Record                                       // Child class of Record.
    {
        public double Average(double[] totalAmountArr)              // New array as parameter to store the total amount array parsed into the method.
        {
            double average;
            double sum = 0;
            for (int i =0; i < totalAmountArr.Length; i++)
            {
                sum += totalAmountArr[i];                           // Increment sum from 0 to final amount at the end of array for total value.
            }
            average = sum / totalAmountArr.Length;
            return average;
        }
    }
}
