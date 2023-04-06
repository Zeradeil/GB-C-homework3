//  Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт 
//  таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int ReadNum(string massage)
{
    System.Console.Write($"{massage} => ");
    return Convert.ToInt32(System.Console.ReadLine());
}

int number = ReadNum("Введите число");
System.Console.Write($"{number} -> ");

for (int i = 1; i <= number; i++)
{
    if (i < number)
    {
        System.Console.Write($"{Math.Pow(i, 3)}, ");
    }
    else
    {
        System.Console.Write($"{Math.Pow(i, 3)}");
    }
}

