namespace ConsoleApplication2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        public static void Main(string[] args)
        {
            DisplayMenus();
        }

        private static void CheckIsOddOrNot()
        {
            Console.WriteLine("Write a number:");
            int p = Convert.ToInt32(Console.ReadLine());
            var k = p % 2;
            if (k == 0)
            {
                Console.WriteLine("your number is even");
            }
            else
            {
                Console.WriteLine("your number is odd");
            }
        }

        static void CheckTwentyNumberIsOdd()
        {
            List<int> oddNumbers = new List<int>();
            for (int c = 0; c < 20; c++)
            {
                Console.WriteLine("Write "+c+"'th new Number");
                int p = Convert.ToInt32(Console.ReadLine());
                var k = p % 2;
                if (k == 0)
                {
                    oddNumbers.Add(p);
                }
            }

            Console.WriteLine("these are even numbers :");
            foreach (var oddNumber in oddNumbers)
            {
              Console.WriteLine(oddNumber);  
            }
        }

        static void sortByChar()
        {
            List<string> stringList = new List<string>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("write your string to add in list: " +
                                  "* if you want to sew sorted list, enter empty enter.");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    stringList.Sort();
                    foreach (var aString in stringList)
                    {
                        Console.WriteLine(aString);
                    }

                    flag = false;
                }
                else
                {
                    stringList.Add(input);
                }
            }
           
            
        }

        static void CalculateMatrix()
        {
           
        }
        
        static void zarb_matris(int n, int q)
        {
            int m;
            int p;
            m = n;
            p = q;
            int[][] a = RectangularIntArray(m, n);
            int[][] b = RectangularIntArray(q, p);
            int[][] c = RectangularIntArray(m,q);
            Console.Write(" \nAnaasor matris A :\n");
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    Console.Write("\n A(");
                    Console.Write(i + 1);
                    Console.Write(",");
                    Console.Write(j + 1);
                    Console.Write(") = ");
                    a[i][j] = int.Parse(ReadToWhiteSpace(true));
                }
            }

            Console.Write(" \nAnaasor matris B :\n");
            for (int i = 0; i < p; i++)
            {

                for (int j = 0; j < q; j++)
                {

                    Console.Write("\n B(");
                    Console.Write(i + 1);
                    Console.Write(",");
                    Console.Write(j + 1);
                    Console.Write(") = ");
                    b[i][j] = int.Parse(ReadToWhiteSpace(true));
                }
            }


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    c[i][j] = 0;
                }
            }

            Console.Write(" \nMatris A x B  :\n");
            Console.Write("\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        c[i][j] += a[i][k] * b[k][j];
                    }
                    Console.Write(" ");
                    Console.Write(c[i][j]);
                    Console.Write("\t");
                }
                Console.Write("\n\n");
            }


        }
        static int[][] RectangularIntArray(int size1, int size2)
        {
            int[][] newArray = new int[size1][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new int[size2];
            }

            return newArray;
        }
        static bool goodLastRead = false;
        static string ReadToWhiteSpace(bool skipLeadingWhiteSpace)
        {
            string input = "";

            char nextChar;
            while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
            {
                //accumulate leading white space if skipLeadingWhiteSpace is false:
                if (!skipLeadingWhiteSpace)
                    input += nextChar;
            }
            //the first non white space character:
            input += nextChar;

            //accumulate characters until white space is reached:
            while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
            {
                input += nextChar;
            }

            goodLastRead = input.Length > 0;
            return input;
        }

        static void DisplayMenus()
        {
            Console.WriteLine("Write your command:");
            Console.WriteLine("1 ====> check it is even or odd");
            Console.WriteLine("2 ====> return odd number of all 20 numbers");
            Console.WriteLine("3 ====> sort by character");
            Console.WriteLine("4 ====> multiplication n to n matrix");
            Console.WriteLine("5 ====> sort eche char of a string");
            Console.WriteLine("or press any other key to exit...");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    Console.Clear();
                    CheckIsOddOrNot();
                    break;
                case '2':
                    Console.Clear();
                    CheckTwentyNumberIsOdd();
                    break;
                case '3':
                    Console.Clear();
                    sortByChar();
                    break;
                case '4':
                    Console.Clear();
                    int n_columnA;
                    int n_columnB;
                    char check_continue;
                    bool keep_calc = true;
                    while (keep_calc)
                    {

                        Console.Write("----------    Matris A x Matris B   ---------\n");


                        Console.Write(" \nTedad sotoon matris A  : ");
                        n_columnA = int.Parse(ReadToWhiteSpace(true));
                        Console.Write(" \nTedad sotoon haye matris B  : ");
                        n_columnB = int.Parse(ReadToWhiteSpace(true));
                        zarb_matris(n_columnA, n_columnB);
                        Console.Write("\n");
                        Console.Write("Do you want to calculate another(Y or N): ");
                        if (!Confirm())
                        {
                            keep_calc = false;
                            Console.WriteLine("\n Good Bye");
                        }
                    }
                    break;
                case '5':
                    Console.WriteLine("Enter your string:");
                    string input = Console.ReadLine();
                        char[] chars = input.ToArray();
                        Array.Sort(chars);
                        Console.WriteLine(new string(chars));
                    ResetConsole();
                    break;
                default:
                    Console.WriteLine("\n ***** bye  ******** :->");
                    break;
            }
        }
        static void ResetConsole()
        {
            Console.WriteLine("Press any key to display menus...");
            Console.ReadKey();
            Console.Clear();
            DisplayMenus();
        }
        static bool Confirm()
        {
            ConsoleKey response;
            do
            {
                response = Console.ReadKey(false).Key;  
                if (response != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }
            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            return (response == ConsoleKey.Y);
        }
    }
}