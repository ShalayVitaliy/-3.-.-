// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int a = Prompt("Введите пятизначное число: ");

if (a / 10000 == a % 10 && (a / 1000) % 10 == (a %100) / 10)
{
    Console.Write("Полиндром!");
}
else
    Console.Write("Число не полиндром!");
