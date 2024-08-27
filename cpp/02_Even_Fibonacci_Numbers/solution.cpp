#include <iostream>

int main() {
    // Initialisierung der ersten beiden Fibonacci-Zahlen
    long long fib1 = 1, fib2 = 2;
    long long sum_even = 0;

    // Schleife, die die Fibonacci-Zahlen berechnet und die geraden Zahlen summiert
    while (fib2 <= 4000000) {
        if (fib2 % 2 == 0) {
            sum_even += fib2;
        }
        long long next_fib = fib1 + fib2;
        fib1 = fib2;
        fib2 = next_fib;
    }

    // Ausgabe der Summe der geraden Fibonacci-Zahlen
    std::cout << "Die Summe der geraden Fibonacci-Zahlen unter 4 Millionen ist: " << sum_even << std::endl;

    return 0;
}
