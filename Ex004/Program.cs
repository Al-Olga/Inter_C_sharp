// Найти расстояние между точками в пространстве 2D

int x1, y1, x2, y2;
double distant;

Console.Write("Введите координату Х первой точки X1= ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки Y1= ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х второй точки X2= ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки Y2= ");
y2 = Convert.ToInt32(Console.ReadLine());

distant = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
Console.WriteLine("Расстояние между двумя точками на плоскости = {0}", Math.Round(distant,2));
