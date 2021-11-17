using System;
class Program
        {            
            static int GetMin(int a, int b)
            {
                int min = a;
                if (a <= b)
                    min = a;
                else if (b <= a)
                    min = b;

                return min;
            }
            static void Main(string[] args)
            {
                int num1, num2, num3;
                Console.WriteLine("-----GET THE MINIMUM OF 3 NUMBERS-----\n");

                Console.WriteLine("Input 3 Numbers:");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                num3 = Convert.ToInt32(Console.ReadLine());

                var min = GetMin(GetMin(num1, num2), num3);
                Console.WriteLine("\nThe minimum number between the three number is: \n{0}", min);
            }
        }

