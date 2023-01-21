//Выяснить является ли число чётным
Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());
if(number%2 == 0) 
{
    int result = number/2;
Console.WriteLine("Число "+number +"является чётным! "+ "Результат выполнения операции деления = "+result);
}
else Console.WriteLine("Число "+number +" является нечётным!");

/*Хотел решить через вещественные числа, но похоже так решить нельзя
Console.Write("Ведите число: ");
float number = float.Parse(Console.ReadLine());
if(number%2 == 0) 
{
    float result = number/2;
Console.WriteLine("Число "+number +"является чётным! "+ "Результат выполнения операции деления = "+result);
}
else Console.WriteLine("Число "+number +" является нечётным!");
*/