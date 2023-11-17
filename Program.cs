namespace MyFirstConsoleWithNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            /* int a, b, c;
             Console.Write("Input the First Number: ");
             a = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input the Second Number: ");
             b = Convert.ToInt32(Console.ReadLine());

             c = a;
             a = b;
             b = c;

             Console.WriteLine("After Swapping:");
             Console.WriteLine("First Number : " + Convert.ToInt32(a));
             Console.WriteLine("Second Number : " + Convert.ToInt32(b));
            */

            //**************************Question 2******************************************//

            //Question 2

            /*
            int a, b, c,d;
            Console.Write("Input the first number to muiltiply: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = a * b * c;

            Console.WriteLine($"{a} x {b} x {c} = " + Convert.ToInt32(d));
            */

            //**************************Question 3******************************************//
            /*
            Write a C# Sharp program to print on screen the output of 
            adding, subtracting, multiplying and dividing two numbers
            entered by the user.
             Test Data:
             Input the first number: 25
             Input the second number: 4
             Expected Output:
            25 + 4 = 29
            25 - 4 = 21
            25 x 4 = 100
            25 / 4 = 6
            25 mod 4 = 1
            
            //Solution

            int a, b, c;

            Console.Write("Input the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine($"{a} + {b} = " + Convert.ToInt32(c));

            c = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, c);

            c = a * b;
            Console.WriteLine("{0} x {1} = {2}", a, b, c);

            c = a / b;
            Console.WriteLine("{0} / {1} = {2}", a, b, c);

            c = a % b;
            Console.WriteLine("{0} mod {1} = {2}", a, b, c);
            */

            //**************************Question 4******************************************//

            /*Write a C# Sharp program that prints the multiplication table of a number as input.
               Test Data:
               Enter the number: 5
               Expected Output:
               5 * 0 = 0
               5 * 1 = 5
               5 * 2 = 10
               5 * 3 = 15
               ....
               5 * 10 = 50



           //Solution

           int a, b, c;
           Console.Write("Enter the number: ");
           a = Convert.ToInt32(Console.ReadLine());

           b = 0;
           while(b<=10)
           {
               c = a * b;
               Console.WriteLine("{0} x {1} = {2}", a, b, c);
               b++;
           }

           */

            //**************************Question 5******************************************//

            /*
            Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the four number: 30

            Expected Output:
            The average of 10 , 15 , 20 , 30 is: 18
            */

            //Solution
            /*
            int a, b, c, d;
            double e;

            Console.Write("Enter the First number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            d = Convert.ToInt32(Console.ReadLine());

            e = (a + b + c + d) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3}, is: {4}", a, b, c, d, e);
            */

            //**************************Question 6******************************************//

            /*
            Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
            Test Data:
            Enter first number - 5
            Enter second number - 6
            Enter third number - 7

            Expected Output:
            Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72 
             
             */

            //Solution
            /*
            int x, y, z, a, b;

            Console.Write("Enter first number - ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number - ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number - ");
            z = Convert.ToInt32(Console.ReadLine());

            a = (x + y) * z;
            b = (x * y) + (y * z);

            Console.WriteLine("Result of specified numbers {0}, {1} and {2} (x+y).z is {3} and x.y + y.z is {4}", x, y, z, a, b);
            */


            //**************************Question 7******************************************//

            /*
             Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), 
            and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
            Test Data:
            Enter a digit: 25
            Expected Output:
            25 25 25 25
            25252525
            25 25 25 25
            25252525
             */

            //Solution
            /*
            int a;
            Console.Write("Enter a digit: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0}  {0}", a);
            Console.WriteLine("{0}{0}{0}{0}{0}", a);

            Console.WriteLine("{0} {0} {0}  {0}", a);
            Console.WriteLine("{0}{0}{0}{0}{0}", a);
            */

            //**************************Question 8******************************************//
            /*
             Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
            Test Data:
            Enter the amount of celsius: 30
            Expected Output:
            Kelvin = 303
            Fahrenheit = 86
             */

            //Solution
            /*
            double cel, kel, fah;

            Console.Write("Enter the amount of celsius: ");
            cel = Convert.ToDouble(Console.ReadLine());

            kel = cel + 273;
            fah = cel * 18 / 10 + 32;

            Console.WriteLine("Kelvin = {0}", kel);
            Console.WriteLine("Fahrenheit = {0}", fah);
            */

            //**************************Question 9******************************************//
            /*
             Write a C# program that removes a specified character from a non-empty string using the index of a character.
             Test Data:
            w3resource
            Sample Output:
            wresource
            w3resourc
            3resource
             */

            //Solution
            /*
            string str = "w3resource";

            Console.WriteLine(str.Remove(1,1)) ;
            Console.WriteLine(str.Remove(9));
            Console.WriteLine(str.Remove(0,1));
            */
            //**************************Question 10******************************************//

            /*
             Write a C# program to check a pair of integers and return true if one is negative and one is positive.
            Sample Output:
            Input first integer:
            -5
            Input second integer:
            25
            Check if one is negative and one is positive:
            True
             */

            //Solution
            /*
            int a, b;
            Console.Write("Input first integer: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            b = Convert.ToInt32(Console.ReadLine());

            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */

            //**************************Question 11******************************************//

            /*
             Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
             */

            //Solution
            /*
             int a, b, c;

             Console.Write("Input First Integert: ");
             a = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input Second Integer: ");
             b = Convert.ToInt32(Console.ReadLine());

             if(a==b)
             {
                 c = 3 * (a + b);
                 Console.WriteLine("Both the integers are same so triple of there sum is {0}", c);
             }
             else
             {
                 c = a + b;
                 Console.WriteLine("Total Sum = {0}",c);

             }
            */
            //**************************Question 12******************************************//



            Console.ReadLine();

        }


    }
}
