﻿internal class Program // Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter number N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(Math.Pow(i, 3));
        }
    }
}