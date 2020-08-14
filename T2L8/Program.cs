using System;
using System.Collections.Generic;
using System.Globalization;

namespace T2L8
{
    class Program
    {
        static void Main(string[] args)
        {
            string task;
            bool loopIsOn = true;

            while (loopIsOn)
            {
                Console.WriteLine("T2 L8:");
                Console.WriteLine("Wybierz zadanie od 1-10:");
                Console.WriteLine("Jeżeli chcesz wyświetlić wsztkie wyniki wpisz: all.");
                Console.WriteLine("Jeżeli chcesz wyjść z programu ćwiczeń wpisz: exit");

                task = Console.ReadLine();

                switch (task)
                {
                    case "1":
                        exercise1();
                        break;
                    case "2":
                        exercise2();
                        break;
                    case "3":
                        exercise3(20);
                        break;
                    case "4":
                        exercise4(10);
                        break;
                    //case "5":
                    //    exercise5();
                    //    break;
                    //case "6":
                    //    exercise6();
                    //    break;
                    //case "7":
                    //    exercise7();
                    //    break;
                    //case "8":
                    //    exercise8();
                    //    break;
                    //case "9":
                    //    exercise9();
                    //    break;
                    //case "10":
                    //    exercise10();
                    //    break;

                    case "all":
                        exercise1();
                        exercise2();
                        exercise3();
                        exercise4(10);
                        //exercise5();
                        //exercise6();
                        //exercise7();
                        //exercise8();
                        //exercise9();
                        //exercise10();
                        break;
                    case "exit":
                        loopIsOn = false;
                        break;
                    default:
                        Console.WriteLine("Podaj prawidłowy numer zadania 1-10 lub prawidłowe polecenie.");
                        break;

                }

            }
        }

        private static void exercise1()
        {
            int counter = 0;

            for (int i = 2; i <= 100; i++)
            {
                if (i == 2)
                {
                    counter++;
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            break;
                        }
                        if ((j + 1) == i)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine("Ilość liczb pierwszych w zakresie 0-100 to: " + counter);
        }
        private static void exercise2()
        {
            int counter = 0;
            int n = 0;
            do
            {
                if (n % 2 == 0)
                {
                    counter++;
                }
                n++;
            } while (n <= 1000);
            Console.WriteLine("Ilość liczb parzystych w zakresie 0-1000 to: " + counter);
        }
        private static void exercise3(int fValuesQty = 10)
        {
            int fValue1 = 0;
            int fValue2 = 1;
            int fValue3;

            List<int> FItems = new List<int>();
            FItems.Add(fValue1);
            FItems.Add(fValue2);

            for (int i = 0; i < fValuesQty - 2; i++)
            {
                fValue3 = fValue1 + fValue2;
                FItems.Add(fValue3);
                fValue1 = fValue2;
                fValue2 = fValue3;
            }
            foreach (var item in FItems)
            {
                Console.WriteLine(item);
            }
        }
        private static void exercise4(int nQty)
        {
            int n = 1;
            string numbers = "";

            for (int i = 0; i < nQty; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    numbers = numbers + (n + " ");
                    n++;
                }
                Console.WriteLine(numbers);
                
                numbers = "";
            }
        }
    }
}