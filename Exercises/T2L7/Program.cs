using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace T2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            string task;
            bool loopIsOn = true;

            while (loopIsOn)
            {
                Console.WriteLine("T2 L7:");
                Console.WriteLine("Wybierz zadanie od 1-13:");
                Console.WriteLine("Jeżeli chcesz wyświetlić wsztkie wyniki wpisz: all.");
                Console.WriteLine("Jeżeli chcesz wyjść z programu ćwiczeń wpisz: exit");

                task = Console.ReadLine();

                switch (task)
                {
                    case "1":
                        Console.WriteLine("Wynik: " + exercise1());
                        break;
                    case "2":
                        exercise2();
                        break;
                    case "3":
                        exercise3();
                        break;
                    case "4":
                        exercise4();
                        break;
                    case "5":
                        exercise5();
                        break;
                    case "6":
                        exercise6();
                        break;
                    case "7":
                        exercise7();
                        break;
                    case "8":
                        exercise8();
                        break;
                    case "9":
                        exercise9();
                        break;
                    case "10":
                        exercise10();
                        break;
                    case "11":
                        exercise11();
                        break;
                    case "12":
                        exercise12();
                        break;
                    case "13":
                        exercise13();
                        break;
                    case "all":
                        Console.WriteLine("Wynik: " + exercise1());
                        exercise2();
                        exercise3();
                        exercise4();
                        exercise5();
                        exercise6();
                        exercise7();
                        exercise8();
                        exercise9();
                        exercise10();
                        exercise11();
                        exercise12();
                        exercise13();
                        break;
                    case "exit":
                        loopIsOn = false;
                        break;
                    default:
                        Console.WriteLine("Podaj prawidłowy numer zadania 1-13 lub prawidłowe polecenie.");
                        break;
                }
            }

        }
        static string exercise1()
        {
            int a = 5, b = 5;
            if (a == b)
            {
                return a + " " + b + " są równe.";
            }
            else return a + " " + b + " nie są równe. Ale tego nigdy nie zobaczysz.";
        }
        static void exercise2()
        {
            int liczba;
            try
            {
                Console.WriteLine("Podaj liczbę int:");
                liczba = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wynik: " + exercise2(liczba));
            }
            catch (Exception)
            {
                Console.WriteLine("To nie jest liczba int!.");
            }

            string exercise2(int a)
            {
                if (a % 2 == 0)
                {
                    return "Liczba " + a + " jest parzysta, ale uważaj, TVP może twierdzić inaczej  ;-p  .";
                }
                else
                    return "Liczba " + a + " NIE jest parzysta, ale uważaj, TVP może twierdzić inaczej  ;-p  .";
            }
        }
        static void exercise3()
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
        static void exercise4()
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
                }
                else Console.WriteLine("Rok nie przestępny");
            }
            catch (Exception)
            {
                Console.WriteLine("To nie jest liczba int!.");
            }
        }
        static void exercise5()
        {
            int posel = 21;
            int senator = 30;
            int prezydent = 35;
            string answer;
            int year;

            Console.WriteLine("Podaj wiek.");
            answer = Console.ReadLine();

            if (Int32.TryParse(answer, out year))
            {
                if (year < posel)
                {
                    Console.WriteLine("Nie czas na politykę, jesteś za młody.");
                }
                if (year >= posel)
                {
                    Console.WriteLine("Możesz zostać posłem.");
                }
                if (year >= senator)
                {
                    Console.WriteLine("Możesz zostać senatorem.");
                }
                if (year >= prezydent)
                {
                    Console.WriteLine("Możesz zostać prezydentem.");
                }
            }
            else { Console.WriteLine("Podany wiek nie jest prawidłowy. Podaj liczbę."); }
        }
        static void exercise6()
        {
            int krasnolud = 140;
            int czlowiek = 160;
            int olbrzym = 220;
            string answer;
            int height;

            Console.WriteLine("Podaj wiek.");
            answer = Console.ReadLine();

            if (Int32.TryParse(answer, out height))
            {
                if (height < krasnolud)
                {
                    Console.WriteLine("Jesteś krasnoludem");
                }
                if (height >= czlowiek)
                {
                    Console.WriteLine("Jesteś człowiekiem.");
                }
                if (height >= olbrzym)
                {
                    Console.WriteLine("Jesteś olbrzymem.");
                }
            }
            else { Console.WriteLine("Podany wzrost jest nieprawidłowy."); }
        }
        static void exercise7()
        {
            string answer;
            int value;
            List<int> values = new List<int>();

            Console.WriteLine("Podaj pierwszą liczbę.");
            answer = Console.ReadLine();

            if (Int32.TryParse(answer, out value))
            {
                values.Add(value);
                Console.WriteLine("Podaj drugą liczbę.");
                answer = Console.ReadLine();

                if (Int32.TryParse(answer, out value))
                {
                    values.Add(value);
                    Console.WriteLine("Podaj trzecią liczbę.");
                    answer = Console.ReadLine();

                    if (Int32.TryParse(answer, out value))
                    {
                        values.Add(value);
                        Console.WriteLine("Podane liczby to:");
                        foreach (var item in values)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Największa to:");
                        values.Sort();
                        Console.WriteLine(values[values.Count - 1]);
                    }
                }
            }
            else Console.WriteLine("Coś poszło nie tak z podaniem liczby.");
        }
        static void exercise8()
        {
            int valueMatematyka;
            int valueFizyka;
            int valueChemia;

            Console.WriteLine("Podaj wynik z matematyki:");
            Int32.TryParse(Console.ReadLine(), out valueMatematyka);
            Console.WriteLine("Podaj wynik z fizyki:");
            Int32.TryParse(Console.ReadLine(), out valueFizyka);
            Console.WriteLine("Podaj wynik z chemii:");
            Int32.TryParse(Console.ReadLine(), out valueChemia);

            if ((valueMatematyka + valueChemia) > 150 || (valueMatematyka + valueFizyka) > 150)
            { Console.WriteLine("Kandydat dopuszczony do rekrutacji."); }
            else if (valueMatematyka > 70 && valueFizyka > 55 && valueChemia > 45 && (valueMatematyka + valueFizyka + valueChemia) > 180)
            { Console.WriteLine("Kandydat dopuszczony do rekrutacji."); }
            else Console.WriteLine("Kandydat NIE dopuszczony do rekrutacji.");
        }
        static void exercise9()
        {
            List<KeyValuePair<int, string>> listOfTemeratureFeelings = new List<KeyValuePair<int, string>>();

            listOfTemeratureFeelings.Add(new KeyValuePair<int, string>(0, "cholernie piździ"));
            listOfTemeratureFeelings.Add(new KeyValuePair<int, string>(10, "zimno"));
            listOfTemeratureFeelings.Add(new KeyValuePair<int, string>(20, "chłodno"));
            listOfTemeratureFeelings.Add(new KeyValuePair<int, string>(30, "w sam raz"));
            listOfTemeratureFeelings.Add(new KeyValuePair<int, string>(40, "zaczyna być słabo, bo gorąco"));
            listOfTemeratureFeelings.Add(new KeyValuePair<int, string>(41, "a weź wyprowadzam się na Alaskę."));

            int temperatureValue;

            Console.WriteLine("Podaj temperaturę.");
            Int32.TryParse(Console.ReadLine(), out temperatureValue);

            foreach (var item in listOfTemeratureFeelings)
            {
                if (temperatureValue < item.Key)
                {
                    Console.WriteLine(item.Value);
                    break;
                }
                if (temperatureValue >= listOfTemeratureFeelings[listOfTemeratureFeelings.Count - 1].Key)
                {
                    Console.WriteLine(listOfTemeratureFeelings[listOfTemeratureFeelings.Count - 1].Value);
                    break;
                }
            }

        }
        static void exercise10()
        {
            List<int> values = new List<int>();
            int bok;
            Console.WriteLine("Podaj pierwszy bok trójkąta.");
            if (Int32.TryParse(Console.ReadLine(), out bok))
            {
                values.Add(bok);
            }
            Console.WriteLine("Podaj drugi bok trójkąta.");
            if (Int32.TryParse(Console.ReadLine(), out bok))
            {
                values.Add(bok);
            }
            Console.WriteLine("Podaj trzeci bok trójkąta.");
            if (Int32.TryParse(Console.ReadLine(), out bok))
            {
                values.Add(bok);
            }
            values.Sort();

            if (values.Count == 3 && Math.Abs(values[2]) > (Math.Abs(values[1]) - Math.Abs(values[0])) && Math.Abs(values[2]) < (Math.Abs(values[1]) + Math.Abs(values[0])))
            {
                Console.WriteLine("Z podanych długości {0}, {1}, {2} można zbudować trójkąt", Math.Abs(values[0]), Math.Abs(values[1]), Math.Abs(values[2]));
            }
            else Console.WriteLine($"Z podanych długości {0}, {1}, {2} NIE można zbudować trójkąta", Math.Abs(values[0]), Math.Abs(values[1]), Math.Abs(values[2]));
        }
        static void exercise11()
        {
            List<string> listOfValues = new List<string>();
            int number;

            listOfValues.Add("Niedostateczny");
            listOfValues.Add("Dopuszczający");
            listOfValues.Add("Dostateczny");
            listOfValues.Add("Dobry");
            listOfValues.Add("Bardzo dobry");
            listOfValues.Add("Celujący");

            Console.WriteLine("Podaj ocenę (liczbę).");
            if (Int32.TryParse(Console.ReadLine(), out number))
            {
                if (number > 0 && number < 7)
                {
                    Console.WriteLine(listOfValues[number - 1]);
                }
                else Console.WriteLine("Podana liczba nie jest w zakresie ocen.");
            }
            else Console.WriteLine("Coś poszło nie tak z konwersją, może to nie liczba.");

        }

        #region exercise12
        enum Dni
        {
            Poniedziałek = 1,
            Wtorek = 2,
            Środa = 3,
            Czwartek = 4,
            Piątek = 5,
            Sobota = 6,
            Niedziela = 7
        }
        static void exercise12()
        {
            int dayNo;
            Console.WriteLine("Numer dnia tygodnia.");
            if (Int32.TryParse(Console.ReadLine(), out dayNo))
            {
                if (dayNo > 0 && dayNo < 8)
                {
                    Console.WriteLine((Dni)dayNo);
                }
                else Console.WriteLine("Liczba nie odpowiada dniu tygodnia.");
            }
            else Console.WriteLine("Coś poszło nie tak z konwersją, może to nie liczba.");
        }
        #endregion

        static void exercise13()
        {
            int a;
            int b;
            int result;
            string task = "";

            Console.WriteLine("Podaj pierwszą liczbę.");
            if (Int32.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Podaj drugą liczbę.");
                if (Int32.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Wybierz numer operacji do wykonania 1-4.");
                    Console.WriteLine("1: Dodawanie.");
                    Console.WriteLine("2: Odejmowanie.");
                    Console.WriteLine("3: Mnożenie.");
                    Console.WriteLine("4: Dzielenie.");

                    task = Console.ReadLine();

                    switch (task)
                    {
                        case "1":
                            result = a + b;
                            Console.WriteLine("Twój wynik to: " + result);
                            break;
                        case "2":
                            result = a - b;
                            Console.WriteLine("Twój wynik to: " + result);
                            break;
                        case "3":
                            result = a * b;
                            Console.WriteLine("Twój wynik to: " + result);
                            break;
                        case "4":
                            if (b != 0)
                            {
                                result = a / b;
                                Console.WriteLine("Twój wynik to: " + result);
                            }
                            else
                            Console.WriteLine("Dzielisz przez 0 więc Twój wynik to: nieskończoność.");
                            break;
                        default:
                            Console.WriteLine("Wybrana operacja jest nieprawidłowa.");
                            break;
                    }

                }
                else Console.WriteLine("Coś poszło nie tak z konwersją, może to nie liczba.");
            }
            else Console.WriteLine("Coś poszło nie tak z konwersją, może to nie liczba.");
        }
    }
}