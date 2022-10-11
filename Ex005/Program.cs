// Найти расстояние между точками в пространстве 3D

int x1, y1, z1, x2, y2, z2;
double distant;

Console.Write("Введите координату Х первой точки X1= ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки Y1= ");
y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки Z1= ");
z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х второй точки X2= ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки Y2= ");
y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки Z2= ");
z2 = Convert.ToInt32(Console.ReadLine());

distant = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
Console.WriteLine("Расстояние между двумя точками в пространстве (3D) = {0}", Math.Round(distant,2));