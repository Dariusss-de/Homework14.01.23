//По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
switch(day)
{
    case 1:  Console.WriteLine("Понедельник"); break;
    case 2:  Console.WriteLine("Вторник");break;
    case 3:  Console.WriteLine("Среда");break;
    case 4:  Console.WriteLine("Четверг");break;
    case 5:  Console.WriteLine("Пятница");break;
    case 6:  Console.WriteLine("Суббота");break;
    case 7:  Console.WriteLine("Воскресенье");break;
}

/*Второй вариант через if else
Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
if(day == 1) Console.WriteLine("Понельник");
else if(day == 2) Console.WriteLine("Вторник");
else if(day == 3) Console.WriteLine("Среда");
else if(day == 4) Console.WriteLine("Четверг");
else if(day == 5) Console.WriteLine("Пятница");
else if(day == 6) Console.WriteLine("Суббота");
else if(day == 7) Console.WriteLine("Воскресенье");
*/
    