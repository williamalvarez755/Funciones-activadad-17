Console.WriteLine("Ingrese el nombre del estudiante:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese el curso:");
string curso = Console.ReadLine();
Console.WriteLine("Ingrese la calificación 1:");
double cal1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la calificación 2:");
double cal2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la calificación 3:");
double cal3 = double.Parse(Console.ReadLine());

void mostrarReporte(string nombre, string curso, double cal1, double cal2, double cal3)
{
    double promedio = (cal1 + cal2 + cal3) / 3;
    Console.WriteLine("Nombre:          " + nombre);
    Console.WriteLine("Curso:           " + curso);
    Console.WriteLine("Calificación 1:  " + cal1);
    Console.WriteLine("Calificación 2:  " + cal2);
    Console.WriteLine("Calificación 3:  " + cal3);
    Console.WriteLine("Promedio final:  " + promedio);
    
}

mostrarReporte(nombre, curso, cal1, cal2, cal3);
