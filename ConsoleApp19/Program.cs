using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                                                        /// C# Basic Declarations and Expression
            #region q1
            //1. Print Hello and Name
            // Display a greeting and a person's name on separate lines
            Console.WriteLine("Hello");
            Console.WriteLine("yasmeen");
            #endregion
            #region q2
            //2. Sum of Two Numbers
            // Read or define two numbers and print their sum
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine($"The sum is {num1 + num2}");
            #endregion
            #region q3
            //3. Divide Two Numbers
            // Calculate and display the quotient of two numbers
            int x = 20;
            int y = 4;
            Console.WriteLine($"The quotient is {x / y}");
            #endregion
            #region q4
            //4. Specified Operations Results
            // Evaluate the four supplied arithmetic expressions and display each result
            Console.WriteLine(5 * 3 + 2);
            Console.WriteLine(10 - 3 * 4);
            Console.WriteLine(15 / 3 - 3);
            Console.WriteLine((3 + 9 + 6 - 4) * 5); ;
            #endregion
            #region q5
            //5. Swap Two Numbers
            //  Exchange the values of two numbers and show the values after swapping.
            int temp;
            int a = 5;
            int b = 10;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swapping: a = {a}, b = {b}");
            #endregion
            #region q6
            //6. Multiply Three Numbers
            // Accept three numbers and print their product
            int muti1 = 2;
            int muti2 = 3;
            int muti3 = 4;
            Console.WriteLine($"The product is {muti1 * muti2 * muti3}");
            #endregion
            #region q7
            //7. Arithmetic Operations
            // For two input numbers, display addition, subtraction, multiplication, division, and remainder
            // results.
            int number1 = 15;
            int number2 = 4;
            Console.WriteLine($"Addition: {number1 + number2}");
            Console.WriteLine($"Subtraction: {number1 - number2}");
            Console.WriteLine($"Multiplication: {number1 * number2}");
            Console.WriteLine($"Division: {number1 / number2}");
            Console.WriteLine($"Remainder: {number1 % number2}");
            #endregion
            #region q8
            //. Multiplication Table
            // Print the multiplication table from 0 through 10 for a user-provided number.
            Console.WriteLine("Enter a number to display its multiplication table:");
            int tableNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{tableNumber} x {i} = {tableNumber * i}");
            }

            #endregion
            #region q9
            //9. Average of Four Numbers
            // Accept four numbers and calculate their average
            Console.WriteLine("Enter four numbers to calculate their average:");
            double numavg1 = double.Parse(Console.ReadLine());
            double numavg2 = double.Parse(Console.ReadLine());
            double numavg3 = double.Parse(Console.ReadLine());
            double numavg4 = double.Parse(Console.ReadLine());
            double average = (numavg1 + numavg2 + numavg3 + numavg4) / 4;
            Console.WriteLine($"The average is {average}");
            #endregion
            #region q10
            //10. Specified Formula with Three Numbers
            // For x, y, and z, calculate(x + y) * z and x *y + y * z.
            Console.WriteLine("Enter three numbers:");
            int x2 = int.Parse(Console.ReadLine());

            int y2 = int.Parse(Console.ReadLine());

            int z2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"(x + y) * z = {(x2 + y2) * z2}");
            Console.WriteLine($"x * y + y * z = {x2 * y2 + y2 * z2}");
            #endregion

                                                                                   ///C# Data Types
                #region q1
            //1. Read three letters and display them in reverse order
            Console.WriteLine("Enter 3 letters :");
            char[] letters = Console.ReadLine().ToCharArray();
            char[] lettersReversed = letters.Reverse().ToArray();
            Console.WriteLine(lettersReversed);
            #endregion
                #region q2
            //2. Read a number and a width, then print a descending-width triangle using that number.

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            for (int i = width; i > 0; i--)
            {
                for (int J = 1; J < i; J++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
            #endregion
                #region q3
            //. Read a user ID and password; reject the user after three unsuccessful attempts.
            string correct_id = "12354";
            string correct_password = "8$$";
            int attempts = 3;
            for (int i = 0; i < attempts; i++)
            {
                Console.WriteLine("enter your id");
                string id = Console.ReadLine();
                Console.WriteLine("enter your password");
                string password = Console.ReadLine();
                if (id == correct_id && password == correct_password)
                {
                    Console.WriteLine("login successful");
                    break;
                }
                else
                {
                    Console.WriteLine($"login failed. You have {attempts - i - 1} attempts left.");
                }




            #endregion
                #region q4
                Console.WriteLine("enter frisr number");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter operator");
                string operation = Console.ReadLine();
                Console.WriteLine("enter second number");
                double second = Convert.ToDouble(Console.ReadLine());
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"result is {first + second}");
                        break;
                    case "-":
                        Console.WriteLine($"result is {first - second}");
                        break;
                    case "*":
                        Console.WriteLine($"result is {first * second}");
                        break;
                    case "/":
                        if (second != 0)
                            Console.WriteLine($"result is {first / second}");
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                #endregion
                #region q5
                //Read a circle radius and calculate its perimeter and area.
                Console.WriteLine("Enter the radius of the circle:");
                double radius = Convert.ToDouble(Console.ReadLine());
                const double pi = Math.PI;
               double perimeter = 2 * pi * radius;
                double area = pi * Math.Pow(radius, 2);
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
                #endregion
                #region q6
                //6. Display values of x = y^2 + 2y + 1 for integer y from -5 through 5.
                for (int y3 = -5; y3 <= 5; y3++)
                {
                    int x3 = y3 * y3 + 2 * y3 + 1;
                    Console.WriteLine($"For y = {y3}, x = {x3}");
                }

                #endregion
                #region q7
                Console.WriteLine("enter  distance in m");
                 double distance = Convert.ToDouble (Console.ReadLine());
                Console.WriteLine("enter time in hours/ minuts/seconds");
                TimeSpan time = TimeSpan.ParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture);
                double speed = distance / time.TotalSeconds;
                Console.WriteLine($"Speed is {speed} m/s");
                Console.WriteLine($"speed is {speed*3.6} km/h");
                Console.WriteLine($"speed is {speed * 2.237} mph");

                #endregion
                #region q8
                // Read a sphere radius and calculate its surface area and volume.
                Console.WriteLine("enter sphere radius");
                double sphereRadius = Convert.ToDouble(Console.ReadLine());
                double sphereSurfaceArea = 4 * Math.PI * Math.Pow(sphereRadius, 2);
                double sphereVolume = (4.0 / 3.0) * Math.PI * Math.Pow(sphereRadius, 3);
                Console.WriteLine($"sphereSurfaceArea is {sphereSurfaceArea} and sphereVolume is {sphereVolume}");
                #endregion
                #region q9
                //. Read a character and classify it as a vowel, digit, or other symbol.
                Console.WriteLine("enter a character");
                char inputChar = Convert.ToChar( Console.ReadLine().ToLower());

                if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u' )
                    
                {
                    Console.WriteLine($"\n{inputChar} is a vowel.");
                }
                else if (char.IsDigit(inputChar))
                {
                    Console.WriteLine($"\n{inputChar} is a digit.");
                }
                else
                {
                    Console.WriteLine($"\n{inputChar} is another symbol.");
                }
                #endregion
                #region q10
                //Read two numbers and return true when both have the same parity (both even or both odd)
                Console.WriteLine(" enter two numbers");
                int value1 = Convert.ToInt32(Console.ReadLine());
                int value2 = Convert.ToInt32(Console.ReadLine());
                if (value1 % 2 == 0 && value2 %2 ==0 || value1 % 2 != 0 && value2 % 2 !=0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                #endregion
                #region q11
                //11. Read a decimal number and display its binary representation.
                Console.WriteLine("enter a decimal number");
               int decimalNumber = Convert.ToInt32(Console.ReadLine());
                string result = "";
                for ( int temp3 = decimalNumber;temp3 > 0; temp3/=2)
                {
                    int remainder = temp3 % 2;
                    result = remainder + result;




                }
                Console.WriteLine(result);
                #endregion



                ///C Conditional Statements
                #region q1
                //1. Read two integers and determine whether they are equal.
                int int1 = Convert.ToInt32(Console.ReadLine());
                int int2 = Convert.ToInt32(Console.ReadLine());
                if(int1 == int2)
                
                    Console.WriteLine("the are equal");
                
                else
                Console.WriteLine("they are not equal");
                #endregion
                #region q2
                //. Determine whether an integer is even or odd.
                Console.WriteLine("enter num");
                int number3 = Convert.ToInt32(Console.ReadLine());
                if (number3 % 2 == 0)
                {
                    Console.WriteLine("the number is even");
                }
                else
                {
                    Console.WriteLine("the number is odd");
                }
                #endregion
                #region q3
                //. Determine whether a number is positive or negative.
                int number4 = Convert.ToInt32(Console.ReadLine());
                if ( number4 > 0 ) 
                {
                    Console.WriteLine("positive");
                }
                else if (number4 < 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("zero");
                }
                #endregion
                #region q4

                #endregion




                                                            //# For Loop


                //. Display the first 10 natural numbers.


                for (int i2 = 0; i2 <= 10; i2++)
                {
                    Console.WriteLine(i);
                }
                //. Find the sum of the first 10 natural numbers.

                int sum = 0;
                int h;
                for (h = 0; h <= 10; h++)
                {
                    sum = sum + h;

                }
                Console.WriteLine(sum);
                //. Display the first n natural numbers and their sum.

                int sum2 = 0;
                Console.WriteLine("enter the count of numbers:");
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j <= n; j++)
                {
                    Console.WriteLine(j);
                    sum2 = sum2 + j;
                }
                Console.WriteLine(sum2);


                //. Read 10 numbers and calculate their sum and average.

                double sum3 = 0;

                for (int i5 = 1; i5 <= 3; i5++)
                {
                    double number9 = Convert.ToDouble(Console.ReadLine());
                    sum3 = sum3 + number9;
                }
                Console.WriteLine($"sum is {sum}  , average is {sum / 3}");


                //. Display the cubes of integers from 1 through a supplied limit.

                Console.WriteLine("enter limit");
                int x9 = int.Parse(Console.ReadLine());
                for (int k = 1; k < x9; k++)
                {
                    Console.WriteLine(Math.Pow(k, 3));
                }

                //. Display the multiplication table of a supplied integer.

                Console.WriteLine("enter integer");
                int intger = int.Parse(Console.ReadLine());
                int y9 = 1;
                while (y9 <= 12)
                {
                    Console.WriteLine($"  {y}*{intger} = {y * intger}");
                    y++;
                }

                //. Display multiplication tables from 1 through n vertically.

                int r = int.Parse(Console.ReadLine());
                for (int e = 1; e <= r; e++)
                {
                    for (int g = 1; g <= 12; g++)
                    {
                        Console.WriteLine($"{e}*{g}={e * g}");
                    }
                }

                //. Display the first n odd natural numbers and their sum.

                int odd = int.Parse(Console.ReadLine());
                for (int l = 0; l < odd; l++)
                {
                    if (l % 2 != 0)
                    {
                        Console.WriteLine($"{l}is odd");
                    }
                    else
                    {
                        continue;
                    }
                }
                //Print a right-angle triangle made of asterisks.
                int unmasterisks = int.Parse(Console.ReadLine());

                for (int asterisk = 1; asterisk <= unmasterisks; asterisk++)
                {
                    for (int ast = 1; ast <= asterisk; ast++)
                    {

                        Console.Write("*");

                    }
                    Console.WriteLine();
                }
                // Print a right - angle triangle whose rows contain 1, 12, 123, and so on.
                for (int p = 1; p <= 3; p++)
                {
                    for (int c = 1; c <= p; c++)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }


            }

        }
    }



}
        
    

