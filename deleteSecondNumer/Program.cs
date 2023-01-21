//Удалить вторую цифру трёхзначного числа
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int res2 = number/100;
Console.WriteLine("Первое число: "+res2);
int  res1 = number%10;
Console.WriteLine("Последнее число: "+res1);
while(number>=100)
{
    number /= 10;
}
int res3 = number%10;
Console.WriteLine("Среднее число: " +res3);
Console.WriteLine("В результате получили число: "+res2+res1);

