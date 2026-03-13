
Console.WriteLine("Ingrese el peso en kilogramos:");
double pesoKg = double.Parse(Console.ReadLine());

double convertirALibras(double pesoKg)
{
    double libras = pesoKg * 2.20462;
    return libras;
}

Console.WriteLine("El peso en libras es: " + convertirALibras(pesoKg));
