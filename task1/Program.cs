internal class Program //Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
{
    private static void Main(string[] args)
    {
        Console.Clear();
        string? str;           // Цикл добавлен для подтверждения правильности введеных данных (будет повторятся пока не будет введено именно пятизначное число,а так же для удобства, чтобы не вводить каждый раз dotnet run, цикл не обязателен)
        for (Console.WriteLine("Enter five-digit number: "), str = Console.ReadLine(); str != null && str.Length != 5; Console.WriteLine("Enter five-digit number: "), str = Console.ReadLine()) ;
        if (str != null && str[0] == str[4] && str[1] == str[3])
        {
            Console.WriteLine("This is palindrome !");
        }
        else Console.WriteLine("This is not polindrome!");
    }
}