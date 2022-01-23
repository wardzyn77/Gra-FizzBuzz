using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_FizzBuzz
{
    class FizzBuzz
    {
        public string Play()
        {
            try
            {
                int num1 = 3, num2 = 5;
                Console.WriteLine("Podasz dwa dzielniki, oraz dzielną. sprawdzę czy liczba jest podzielna.\n");
                Console.WriteLine("Fizz = podzielna przez pierwszy dzielnik, Buzz - przez drugi, FizzBuzz przez obydwa. W przeciwnym wypadku zwrócę liczbę");
                Console.WriteLine("Wciśnięcie klawisza 'T' w dowolnym momencie przerwie zabawę");
                Console.WriteLine("Podaj pierwszy dzielnik");
                num1 = GetInput(int.MinValue, int.MaxValue, true, false);
                Console.WriteLine("Podaj drugi dzielnik");
                num2 = GetInput(int.MinValue, int.MaxValue, true, false);
                Console.WriteLine("Podaj dowolną liczbę całkowitą");
                var flFizz = false;
                var flBuzz = false;
                var num = GetInput(int.MinValue, int.MaxValue, true);
                flFizz = IsDivedWith0(num, num1);
                flBuzz = IsDivedWith0(num, num2);
                var info = num.ToString();
                if (flFizz && flBuzz)
                    info = "FizzBuzz";
                else if (flFizz)
                    info = "Fizz";
                else if (flBuzz)
                    info = "Buzz";
                return info;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Naciśnij dowolny klawisz.");
                Console.ReadKey();
            }
            return "T";
        }

        private bool IsDivedWith0(int num, int divByNum)
        {
            var fl = false;
            if (num % divByNum == 0)
                fl = true;
            return fl;
        }

        private int GetInput(int minNum = 1, int maxNum = int.MaxValue, bool withCloseByT = false, bool with0 = true)
        {
            while (true)
            {
                var userStr = Console.ReadLine();
                if (userStr.ToUpper() == "T" && withCloseByT)
                    throw new Exception("Nastąpi wyjście z aplikacji");
                //czy użycie tutaj sztucznego generowania błędu jest właściwe, zalecane? Oczywiście przy założeniu obsługi wyjątków wyżej
                //Environment.Exit(0);
                if (!int.TryParse(userStr, out int number) || number > maxNum || number < minNum || (number == 0 && !with0))
                {
                    Console.WriteLine("Wprowadziłeś błędne dane\nSpróbuj ponownie.");
                    continue;
                }
                return number;
            }
        }
    }
}
