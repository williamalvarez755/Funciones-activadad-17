Console.WriteLine("Ingrese la base del rectángulo:");
double base_ = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectángulo:");
double altura = double.Parse(Console.ReadLine());

void mostrarAreaRectangulo(double base_, double altura)
{
    double area = base_ * altura;
    Console.WriteLine("El área del rectángulo es: " + area);
}

mostrarAreaRectangulo(base_, altura);
