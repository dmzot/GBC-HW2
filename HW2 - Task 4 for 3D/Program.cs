// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Расстояние между точками в 3D");
Console.WriteLine("Введите координаты точки A - x1: ");
var X1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A - y1: ");
var Y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A - z1: ");
var Z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - x2: ");
var X2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - y2: ");
var Y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - z2: ");
var Z2 = double.Parse(Console.ReadLine());

var result = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1) + (Z2 - Z1) * (Z2 - Z1));
Console.WriteLine("Длина отрезка между координатами точек A и B в 3D=" + result);
