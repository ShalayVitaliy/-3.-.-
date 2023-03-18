// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

double Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

Console.WriteLine("Enter coordinates of the first point: ");
double x1 = Prompt("x1 = ");
double y1 = Prompt("y1 = ");
double z1 = Prompt("z1 = ");

Console.WriteLine("Enter coordinates of the second point: ");
double x2 = Prompt("x2 = ");
double y2 = Prompt("y2 = ");
double z2 = Prompt("z2 = ");

Console.WriteLine();
Console.WriteLine("Wait a little bit...");
Console.WriteLine();

double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Your result is: {dist}");

