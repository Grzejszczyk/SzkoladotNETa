using System;

namespace T2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz zadanie od 1-13:");
            string task;
            task = Console.ReadLine();

            switch (task)
            {
                case "1":
                    Console.WriteLine("Wynik: " + cw1());
                    break;
                case "2":
                    cw2();
                    break;
                case "3":
                    cw3();
                    break;
                case "4":
                    cw4();
                    break;
                default:
                    Console.WriteLine("Podaj prawidłowy numer zadania 1-13.");
                    break;
            }
        }
        static public string cw1()
        {
            int a = 5, b = 5;
            if (a == b)
            {
                return a + " " + b + " są równe.";
            }
            else return a + " " + b + " nie są równe. Ale tego nigdy nie zobaczysz.";
        }
        static public void cw2()
        {
            int liczba;
            try
            {
                Console.WriteLine("Podaj liczbę int:");
                liczba = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik: " + cw2(liczba));
            }
            catch (Exception)
            {
                Console.WriteLine("To nie jest liczba int!.");
            }

            string cw2(int a)
            {
                if (a % 2 == 0)
                {
                    return "Liczba " + a + " jest parzysta, ale uważaj, TVP może twierdzić inaczej  ;-p  .";
                }
                else
                    return "Liczba " + a + " NIE jest parzysta, ale uważaj, TVP może twierdzić inaczej  ;-p  .";
            }
        }
        static public void cw3()
        {
            int a = 0;
            try
            {
                Console.WriteLine("Podaj liczbę int:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    Console.WriteLine(a + " jest mniejsze od 0.");
                }
                else if (a > 0) Console.WriteLine(a + " jest większe od 0.");
                else Console.WriteLine("To jest Zero!");
            }
            catch (Exception)
            {
                Console.WriteLine("To nie jest liczba int!.");
            }
        }
        static void cw4()
        {
            int year = 0;
            Console.WriteLine("Podaj rok (np. 2020).");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
                DateTime dateTime = new DateTime(year, 1, 1);
                DateTime dateTime2 = new DateTime(year, 12, 31);
                int r = dateTime2.DayOfYear - dateTime.DayOfYear + 1;
                if (r > 365)
                {
                    Console.WriteLine("Rok przestępny");
                } else Console.WriteLine("Rok nie przestępny");
            }
            catch (Exception)
            {
                Console.WriteLine("To nie jest liczba int!.");
            }
        }
    }
}