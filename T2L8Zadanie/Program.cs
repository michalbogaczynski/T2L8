using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace T2L8Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadania lekcja 8");
            Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
            //Exercise10();
        }

        public static void Exercise1()
        {
            Console.WriteLine("Zadanie 1 -liczby pierwsze");
            int count = 0;
            for (int i = 2; i < 100; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i == j)
                    {
                        count++;
                    }
                    else if (i % j == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"W zakresie 0-100 jest {count} liczb pierwszych");
        }

        public static void Exercise2()
        {
            Console.WriteLine("Zadanie 2 - liczby parzyste");
            int a = 0;
            do
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            } while (a <= 1000);
        }

        public static void Exercise3()
        {
            //0 1 1 2 3 5 8 13
            Console.WriteLine("Zadanie 3 - ciąg Fibonacciego");
            double a = 0;
            double b = 1;
            double c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 100; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }

        public static void Exercise4()
        {
            Console.WriteLine("Zadanie 4 - piramida");
            Console.WriteLine("Podaj liczbę całkowitą");
            int a = int.Parse(Console.ReadLine());
            int line = 1;
            int counter = 0;

            for (int i = 0; i < a; i++)
            {
                //Console.Write($"{i} ");
                counter++;
                if (counter == line)
                {
                    Console.WriteLine("\r\n");
                    counter = 0;
                    line++;
                }
            }

        }
        public static void Exercise5()
        {
            Console.WriteLine("Zadanie 5 - 3 potęga liczb od 1 do 20");
            for (int i = 1; i <= 20; i++)
            {
                double power = (Math.Pow(i, 3));
                Console.WriteLine(power);
            }
        }

        public static void Exercise6()
        {
            Console.WriteLine("Zadanie 6");
            double result = 0;
            for (int i = 1; i < 20; i++)
            {
                result += (1 / i);                
            }
            Console.WriteLine($"Suma ciągu wynosi: {result}");
        }   
        
        public static void Exercise7()
        {
            
            Console.WriteLine("Wprowadź długość przekątnej diamentu: ");
            int diagonal = int.Parse(Console.ReadLine());

            for (int i = 1; i <= diagonal; i++)
            {
                for (int j = 1; j <= diagonal - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= diagonal - 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = diagonal-1; k >= i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }

        public static void Exercise8()
        {
                Console.WriteLine("Zadanie 8 - Wprowadź ciąg znaków: ");
                string word = Console.ReadLine();
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(charArray);
        }

        public static void Exercise9()
        {
            Console.WriteLine("Zadanie 9 - Podaj liczbę dziesiętną: ");
            decimal decimalNumber = decimal.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString((byte)decimalNumber, 2);
            Console.WriteLine(binaryNumber);
        }

        public static void Exercise10()
        {
            Console.WriteLine("Zadanie 10 - Najmniejsza wspólna wielokrotność \r\nPodaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int nww = firstNumber * secondNumber / Nwd(firstNumber, secondNumber);
            Console.WriteLine($"Najmniejsza wspólna wielokrotność to: {nww}");
        }

        static int Nwd(int firstNumber, int secondNumber)
        {
            int rest;
            while (secondNumber !=0)
            {
                rest = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = rest;
            }
            return firstNumber;
        }
    } 
}
