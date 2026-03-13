double areacirculo(double radio)
{
    double area = 3.1416 * radio * radio;
    return area;
}

Console.WriteLine("ingrese el radio del circulo");
double radio = double.Parse(Console.ReadLine());

Console.WriteLine("el area del circulo es: " + areacirculo(radio));