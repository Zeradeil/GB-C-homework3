//  Задача 2: Напишите программу, которая принимает на вход координаты двух точек
//   и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double ReadNum(string massage)
{
    System.Console.Write($"{massage}");
    return Convert.ToInt32(System.Console.ReadLine());
}
System.Console.WriteLine("Введите координаты числа A");
double ax = ReadNum("X => ");
double ay = ReadNum("Y => ");
double az = ReadNum("Z => ");
System.Console.WriteLine("Введите координаты числа B");
double bx = ReadNum("X => ");
double by = ReadNum("Y => ");
double bz = ReadNum("Z => ");

double d = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)), 2);
System.Console.WriteLine(d);

