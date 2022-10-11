// Задать номер четверти, 
// показать диапазоны для возможных координат

int NumberQuarter = new Random().Next(1,5);
Console.WriteLine(NumberQuarter);

if (NumberQuarter == 1) 
    Console.WriteLine("Для четверти I возможны значения: x>0 и y>0");
else if (NumberQuarter == 2) 
    Console.WriteLine("Для четверти II возможны значения: x<0 и y>0");
else if (NumberQuarter == 3) 
    Console.WriteLine("Для четверти III возможны значения: x<0 и y<0");
else 
    Console.WriteLine("Для четверти IV возможны значения: x>0 и y<0");