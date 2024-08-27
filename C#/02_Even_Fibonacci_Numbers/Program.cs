using System;

class Program
{
    static void Main()
    {
        // Initialisierung der ersten beiden Fibonacci-Zahlen
        long fib1 = 1, fib2 = 2;
        long sum_even = 0;

        // Schleife, die die Fibonacci-Zahlen berechnet und die geraden Zahlen summiert
        while (fib2 <= 4000000)
        {
            if (fib2 % 2 == 0)
            {
                sum_even += fib2;
            }
            long next_fib = fib1 + fib2;
            fib1 = fib2;
            fib2 = next_fib;
        }

        // Ausgabe der Summe der geraden Fibonacci-Zahlen
        Console.WriteLine("Die Summe der geraden Fibonacci-Zahlen unter 4 Millionen ist: " + sum_even);
    }
}
