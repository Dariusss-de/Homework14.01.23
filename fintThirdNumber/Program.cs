//Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = -1;
if (number >= 100)
{
while (number > 999)
{
number = number / 10;
}
result = number % 10;
}
if(result == -1) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine("Третье число: "+result);
