namespace loops_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# loops demonstration!");

            Console.WriteLine("\n*** For loop examples ***");

            Console.WriteLine("\nBasic for loop:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nReverse for loop:");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nFor loop with a step of 2:");
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nIterating through an array using a for loop:");
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("\nFor loop to calculate factorial:");
            int number = 5;
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {number} is {factorial}");

            Console.WriteLine("\n*** While loop examples ***");

            Console.WriteLine("\nBasic while loop:");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("\nWhile loop with a condition:");
            int num = 1234;
            while (num > 0)
            {
                Console.WriteLine(num % 10); // Prints digit
                num /= 10;
            }

            Console.WriteLine("\nWhile loop to calculate factorial:");
            number = 5;
            factorial = 1;
            while (number > 1)
            {
                factorial *= number;
                number--;
            }
            Console.WriteLine($"Factorial is {factorial}");

            Console.WriteLine("\nWhile loop to generate Fibonacci sequence up to a certain number:");
            int num1 = 0, num2 = 1, num3 = 0, maxNumber = 100;
            Console.Write(num1 + " " + num2 + " "); //printing 0 and 1
            while (num3 <= maxNumber)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                if (num3 <= maxNumber)
                {
                    Console.Write(num3 + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("\nInfinite while loop (breaks after 10 iterations):");
            int counter = 0;
            while (true)
            {
                if (counter >= 10)
                {
                    break; 
                }
                Console.WriteLine("Infinite loop iteration " + counter);
                counter++;
            }
        }
    }
}