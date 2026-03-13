Console.WriteLine("Ingrese la distancia recorrida (km):");
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tiempo empleado (horas):");
double tiempo = double.Parse(Console.ReadLine());

double calcularVelocidad(double distancia, double tiempo)
{
    double velocidad = distancia / tiempo;
    return velocidad;
}

Console.WriteLine("La velocidad promedio es: " + calcularVelocidad(distancia, tiempo) + " km/h");
