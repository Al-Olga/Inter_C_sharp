// Дано число обозначающее день недели. 
// Выяснить является номер дня недели выходным

int NumberWeek;

Console.Write("Введите номер дня недели  = ");
NumberWeek = Convert.ToInt32(Console.ReadLine());

if ((NumberWeek == 6) | (NumberWeek == 7)) 
    Console.WriteLine("Введенное число соответствует Выходному дню");
else Console.WriteLine("Введенное число не является Выходным днем");