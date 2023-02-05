// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите число 1: ");
int X1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int X2 = int.Parse(Console.ReadLine());

if (X1 == 0 || X2 == 0) Console.WriteLine("Введите числа, не равные нулю");
else if (X1 / X2 == X2 || X2 / X1 == X1) Console.WriteLine("Одно число является квадратом другого");
else Console.WriteLine("Одно число НЕ является квадратом другого");