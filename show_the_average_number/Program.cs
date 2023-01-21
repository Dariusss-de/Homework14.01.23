// Показать вторую цифру трёхзначного числа
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
while(number>=100)
{
    number /= 10;
}
int res = number%10;
Console.WriteLine("Число " +number);
Console.WriteLine("Десятки " +res);

/*Второй вариант
Console.Write("Введите число: ");
int number = new Random().Next(100,999);
Console.WriteLine("Число: "+number);
while(number >=100)
{
    number /= 10;
}
int res = number%10;
Console.WriteLine("Десятки " +res);
*/