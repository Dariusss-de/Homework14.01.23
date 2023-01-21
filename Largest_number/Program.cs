
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите число число из отрезка [10, 99]: ");
int number = int.Parse(Console.ReadLine());
int res1 = number%10;
Console.WriteLine("Число: "+res1);
while(number>=10 && number<=99)
{
    number /=10;
}
int res2 = number%10;
Console.WriteLine("Число: "+res2);
if(res1>res2) Console.WriteLine("Наибольшей цифрой числа,является цифра: "+res1);
else if (res2>res1) Console.WriteLine("Наибольшей цифрой числа,является цифра: "+res2);
else Console.WriteLine("Значение цифр равны!");


/*Второй способ
int number = new Random().Next(10,99);
int res1 = number%10;
Console.WriteLine("Число: "+res1);
while(number>=10 && number<=99)
{
    number /=10;
}
int res2 = number%10;
Console.WriteLine("Число: "+res2);
if(res1>res2) Console.WriteLine("Наибольшей цифрой числа,является цифра: "+res1);
else if (res2>res1) Console.WriteLine("Наибольшей цифрой числа,является цифра: "+res2);
else Console.WriteLine("Значение цифр равны!");
*/