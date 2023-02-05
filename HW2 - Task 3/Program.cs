// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
int Z = int.Parse(Console.ReadLine());

if (Z == 1) Console.WriteLine("Диапазон координат при X > 0 и Y > 0");
else if (Z == 2) Console.WriteLine("Диапазон координат при X < 0 и Y > 0");
else if (Z == 3) Console.WriteLine("Диапазон координат при X < 0 и Y < 0");
else if (Z == 4) Console.WriteLine("Диапазон координат при X > 0 и Y < 0");
else Console.WriteLine("Введите номер четверти от 1 до 4 включительно");