double promedio(int num1, int num2, int num3)
{
    return (num1 + num2 + num3) / 3.0;
}


Console.WriteLine("ingrese n1");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese n2");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese n3");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine($"el promedio es {promedio(n1, n2, n3)}");

