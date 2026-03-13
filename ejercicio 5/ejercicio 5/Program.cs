double arearectangulo(double base1 , double altura)
{
    double area = base1 * altura ;
    return area;
}
Console.WriteLine("ingrese la altura del rectangulo");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("ingrese la base del rectangulo");
double base1 = double.Parse(Console.ReadLine());
Console.WriteLine("El area del rectangulo es: " + arearectangulo(base1,altura));