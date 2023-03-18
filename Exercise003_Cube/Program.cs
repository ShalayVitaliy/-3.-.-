// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int n = Prompt("Enter a munber: ");

for(int i = 1; i <= n; i++)
{
    Console.Write($" {Math.Pow(i,3)};");
}