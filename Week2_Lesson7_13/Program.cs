public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
            Podaj pierwszą liczbę:
            …
            Podaj drugą liczbę:
            …
            Podaj numer operacji do wykonania:
            1. Dodawanie
            2. Odejmowanie
            3. Mnożenie
            4. Dzielenie
            …
            Twój wynik to:
        */

        Console.WriteLine("Podaj pierwszą liczbę:");
        double a = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        double b = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj numer operacji do wykonania: \r\n 1. Dodawanie\r\n 2. Odejmowanie\r\n 3. Mnożenie\r\n 4. Dzielenie");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Twój wynik to {a + b}");
                break;
            case 2:
                Console.WriteLine($"Twój wynik to {a - b}");
                break;
            case 3:
                Console.WriteLine($"Twój wynik to {a * b}");
                break;
            case 4:
                if (b != 0)
                {
                    Console.WriteLine($"Twój wynik to {a / b}");
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez 0!");
                }
                break;
            default:
                Console.WriteLine("Błąd! Nie ma takiej operacji.");
                break;
        }



    }

}