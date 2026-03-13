Console.WriteLine("Ingrese la nota del estudiante 1:");
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota del estudiante 2:");
double nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota del estudiante 3:");
double nota3 = double.Parse(Console.ReadLine());

double calcularPromedioGrupo(double nota1, double nota2, double nota3)
{
    double promedio = (nota1 + nota2 + nota3) / 3;
    return promedio;
}

Console.WriteLine("El promedio del grupo es: " + calcularPromedioGrupo(nota1, nota2, nota3));
