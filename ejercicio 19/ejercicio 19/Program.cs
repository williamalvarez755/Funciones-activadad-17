Console.WriteLine("Ingrese el nombre del estudiante:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese la calificación 1:");
double cal1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la calificación 2:");
double cal2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la calificación 3:");
double cal3 = double.Parse(Console.ReadLine());

double calcularPromedioFinal(double cal1, double cal2, double cal3)
{
    double promedio = (cal1 + cal2 + cal3) / 3;
    return promedio;
}

Console.WriteLine("El promedio final de " + nombre + " es: " + calcularPromedioFinal(cal1, cal2, cal3));