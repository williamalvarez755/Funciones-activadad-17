Console.WriteLine("ingrese el valor en farenheit para convertir en celcius");
double farenheit = double.Parse(Console.ReadLine());

double  celciusfx (double farenheit)
{     double celcius = (farenheit - 32) * 5 / 9;
    return celcius;
}
Console.WriteLine("El valor en celcius es: " + celciusfx(farenheit));