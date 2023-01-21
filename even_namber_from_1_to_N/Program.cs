// Показать четные числа от 1 до N
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
for(int i=1;i<=N;i++)
{
    if(i%2 == 0) Console.WriteLine("Число "+i+" является чётным.");
   // else Console.WriteLine("Число "+i+" является нечётным");
}

/*Второй вариант с генератором
int N = new Random().Next(1,45);
for(int i=1;i<=N;i++)
{
    if(i%2 == 0) Console.WriteLine("Число "+i+" является чётным.");
    else Console.WriteLine("Число "+i+" является нечётным");
}
*/