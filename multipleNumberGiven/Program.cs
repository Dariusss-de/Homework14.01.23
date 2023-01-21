//Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 % number2 == 0) Console.WriteLine("Делятся нацело");
else if (number1 % number2 != 0)
{
int result = number1 % number2;
Console.WriteLine("Остаток от деления: "+result);
}