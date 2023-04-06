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

int number = ReadNum("Введите число");

if (9999 < number && number < 100000)
{
    for (int i = 0; i <= 2; i++)
    {
        int firstNumber = (number / 10 ^ (4 - i)) % 10;
        int lastNumber = number % 10 ^ (1 + i);
        if (firstNumber == lastNumber)
        {
            System.Console.WriteLine($"Число {number} полиндром");
        }
        if (firstNumber != lastNumber)
        {
            System.Console.WriteLine($"Число {number} не полиндром");
        }
    }
}
else
{System.Console.WriteLine("Число не пятизначное");

}