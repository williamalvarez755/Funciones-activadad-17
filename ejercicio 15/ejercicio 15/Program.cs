Console.WriteLine("Ingrese la base del triángulo:");
double base_ = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triángulo:");
double altura = double.Parse(Console.ReadLine());

double calcularAreaTriangulo(double base_, double altura)
{
    double area = (base_ * altura) / 2;
    return area;
}

Console.WriteLine("El área del triángulo es: " + calcularAreaTriangulo(base_, altura));
