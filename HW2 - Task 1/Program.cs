// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите число: ");
int X = int.Parse(Console.ReadLine());

if (X == 6 || X == 7) Console.WriteLine("Выходной");

else if (X > 0 && X < 6) Console.WriteLine("Будний");

else Console.WriteLine("Не является днем недели, введите число от 1 до 7 включительно");