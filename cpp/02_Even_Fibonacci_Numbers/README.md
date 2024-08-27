# Problem 2 - Even Fibonacci Numbers

## Problemstellung

Jedes neue Glied der Fibonacci-Folge wird durch die Addition der beiden vorhergehenden Glieder gebildet. Die Folge startet mit den Zahlen 1 und 2. Die ersten 10 Glieder der Fibonacci-Folge lauten:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

Betrachte die Glieder der Fibonacci-Folge, deren Werte 4 Millionen nicht überschreiten. Finde die Summe der geradzahligen Glieder dieser Folge.

## Lösung

Um das Problem zu lösen, berechnen wir die Fibonacci-Folge und summieren nur die geraden Glieder, solange die Werte unter 4 Millionen bleiben.

### Algorithmus

1. **Initialisierung**: Wir starten mit den Werten `fib1 = 1` und `fib2 = 2`.
2. **Schleife**: Die Fibonacci-Zahlen werden berechnet, und die geraden Zahlen werden zur Summe hinzugefügt, bis die Grenze von 4 Millionen erreicht ist.
3. **Modulo-Überprüfung**: Wenn eine Fibonacci-Zahl durch 2 teilbar ist (d.h. gerade), wird sie zur Gesamtsumme hinzugefügt.

### Kompilierung und Ausführung

Um das Programm zu kompilieren und auszuführen, verwende folgende Befehle:

### Kompilierung
```bash
g++ -o solution solution.cpp
```
### Ausführung
```bash
./solution
```
### Beispiel
![image](https://github.com/user-attachments/assets/9ef64b0e-0aad-4124-bee5-f19e64c75316)

### Anforderungen
- C++17 oder höher
- Compiler wie g++, clang++ oder eine C++-kompatible Entwicklungsumgebung
### Beitragende

MariusH-Dev - Entwickler

### Lizenz

Dieses Projekt ist lizenziert unter der MIT-Lizenz - siehe die [LICENSE](https://github.com/MariusH-Dev/Eulers-Project-Solutions/blob/master/LICENSE) Datei für Details.
