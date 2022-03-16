using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch
            {
                Console.WriteLine("there is Something wrong happened ");

            }
            finally
            {
                Console.WriteLine("Program is complete.");
            }
        }
        static void StartSequence()
        {
            Console.WriteLine("Please enter a number greater than zero");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            arr = Populate(arr);
            int sum = GetSum(arr);
            int product = GetProduct(arr, sum);
            decimal quotient = GetQuotient(product);


            Console.WriteLine("Your array size is: " + size);
            Console.Write("The numbers in the array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("The sum of the array is: " + sum);
            Console.WriteLine(sum + " " + "*" + " " + product / sum + " = " + product);
            int number = (int)quotient;
            Console.WriteLine(product + " " + "/" + " " + (product / number) + " = " + quotient);
        }

        static int[] Populate(int[] arr)
        {
           int i;
          for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter a number" + " " + (i + 1) + " of " + arr.Length);
                int input = Convert.ToInt32(Console.ReadLine());
                arr[i] = input;
            }
            return arr;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            if (sum < 20)
            {
                throw new Exception("Value of" + sum + "is too low");
            }
            return sum;
        }
        static int GetProduct(int[] arr, int sum)
        {
            int product = 0;
            try { 
            Console.WriteLine("select a random number between 1 and" + arr.Length);
            int randomnumber = Convert.ToInt32(Console.ReadLine());
            
            product = sum * randomnumber;
                }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
            return product;

        }
        static decimal GetQuotient(int product)
        {
            Console.WriteLine("enter a number to divide the product by" + "The product is " + product);
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                decimal quotient = decimal.Divide(product, userInput);
                return quotient;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

    }
}
