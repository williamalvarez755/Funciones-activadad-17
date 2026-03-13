Console.WriteLine("Ingrese el radio del círculo:");
double radio = double.Parse(Console.ReadLine());

void mostrarAreaCirculo(double radio)
{
    double area = 3.1416 * radio * radio;
    Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
}

mostrarAreaCirculo(radio);
