// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Расстояние между точками в 3D");
Console.WriteLine("Введите координаты точки A - x1: ");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A - y1: ");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A - z1: ");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - x2: ");
int X2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - y2: ");
int Y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - z2: ");
int Z2 = int.Parse(Console.ReadLine());


double x = X2-X1;
Console.WriteLine("X2-X1="+x);

double y = Y2-Y1;
Console.WriteLine("Y2-Y1="+y);

double z = Z2-Z1;
Console.WriteLine("Z2-Z1="+z);

double xSq = Math.Pow(x,2);
Console.WriteLine("x^2="+xSq);

double ySq = Math.Pow(y,2);
Console.WriteLine("y^2="+ySq);

double zSq = Math.Pow(z,2);
Console.WriteLine("z^2="+zSq);

double a = xSq + ySq + zSq;
Console.WriteLine("x^2+y^2+z^2="+a);

double result = Math.Sqrt(a);
Console.WriteLine("a^0.5="+result);

Console.WriteLine("Длина отрезка между координатами точек A и B в 3D=" + result);