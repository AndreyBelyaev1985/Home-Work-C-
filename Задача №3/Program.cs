// Напишите программу которая на вход принимает число и выдаёт, является ли число чётным.
Console.WriteLine("Введите число => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);
    if (A % 2 == 0) Console.WriteLine($"Введенное число {A} является четным");
        else
        Console.WriteLine($"Введенное число {A} является не четным");