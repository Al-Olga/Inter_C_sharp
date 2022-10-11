// По двум заданным числам проверять является ли одно квадратом другого

int a;
int b;

Console.Write("Введите первое число А = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число B = ");
b = Convert.ToInt32(Console.ReadLine());

if (a == b*b) 
    Console.WriteLine("Число А={0} является квадратом числа В={1}", a, b);
else if (b == a*a) 
    Console.WriteLine("Число В={0} является квадратом числа А={1}", b, a);
else
    Console.WriteLine("Числа А={0} и В={1} не являются квадратами друг-друга", a, b);