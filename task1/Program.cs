//  Задача 1: Напишите программу, которая принимает на вход пятизначное число и 
//  проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int ReadNum(string massage)
{
    System.Console.Write($"{massage} => ");
    return Convert.ToInt32(System.Console.ReadLine());
}
int Count(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        int num = number % 10;
    }
    return count;
}

int number = ReadNum("Введите число");
int count = Count(number);
System.Console.WriteLine(count);

for (int i = 0; i < count / 2; i++)
{
    int firstNumber = number / 10 ^ (count - i);
    int lastNumber = number % 10 ^ (1 + i);
    if (firstNumber !=  lastNumber){
        System.Console.WriteLine($"Число {number} не полиндром");
        break;
    }
}