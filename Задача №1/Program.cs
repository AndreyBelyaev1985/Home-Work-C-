// Программа выбирающая большее число.

Console.WriteLine("Введите число => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);

Console.WriteLine("Введите число => ");
string inputB = Console.ReadLine();
int B = int.Parse(inputB); 

if (A > B) Console.WriteLine($"Большее число {A}");
if (B > A) Console.WriteLine($"Большее число {B}");