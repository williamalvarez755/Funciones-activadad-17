Console.WriteLine("Ingrese la calificación 1:");
double cal1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la calificación 2:");
double cal2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la calificación 3:");
double cal3 = double.Parse(Console.ReadLine());

void mostrarPromedio(double cal1, double cal2, double cal3)
{
    double promedio = (cal1 + cal2 + cal3) / 3;
    Console.WriteLine("El promedio del estudiante es: " + promedio);
}

mostrarPromedio(cal1, cal2, cal3);
