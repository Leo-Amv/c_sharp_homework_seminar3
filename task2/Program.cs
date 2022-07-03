internal class Program // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
{
    private static void Main(string[] args)
    {
        Console.Clear();                                                    // Вариант для ввода через пробел с функцией .Split 
        Console.WriteLine("Enter coordinates of the first point (x y z): ");
        //                                                                  // string[] strA = Console.ReadLine().Split(' ');
        int xa = Convert.ToInt32(Console.ReadLine());                       // int xa = Convert.ToInt32(strA[0]);
        int ya = Convert.ToInt32(Console.ReadLine());                       // int ya = Convert.ToInt32(strA[1]);
        int za = Convert.ToInt32(Console.ReadLine());                       // int za = Convert.ToInt32(strA[2]);
        Console.WriteLine("Enter coordinates of the second point (x y z): ");
        //                                                                  // string[] strB = Console.ReadLine().Split(' ');
        int xb = Convert.ToInt32(Console.ReadLine());                       // int xb = Convert.ToInt32(strB[0]); 
        int yb = Convert.ToInt32(Console.ReadLine());                       // int yb = Convert.ToInt32(strB[1]);
        int zb = Convert.ToInt32(Console.ReadLine());                       // int zb = Convert.ToInt32(strB[2]);
        double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
        Console.WriteLine($"Distance = {distance}");
    }
}