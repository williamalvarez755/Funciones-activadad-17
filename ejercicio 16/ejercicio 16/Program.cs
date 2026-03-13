Console.WriteLine("Ingrese la cantidad de minutos:");
double minutos = double.Parse(Console.ReadLine());

double convertirAHoras(double minutos)
{
    double horas = minutos / 60;
    return horas;
}

Console.WriteLine(minutos + " minutos equivalen a " + convertirAHoras(minutos) + " horas");
