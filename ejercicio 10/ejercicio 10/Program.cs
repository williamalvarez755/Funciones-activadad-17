Console.WriteLine("Ingrese un número:");
double numero = double.Parse(Console.ReadLine());

double calcularCubo(double numero)
{
    double cubo = numero * numero * numero;
    return cubo;
}

Console.WriteLine("El cubo de " + numero + " es: " + calcularCubo(numero));
