Console.WriteLine("ignrese salario por hora");
double salarioHora = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese numero de horas trabajadas");
double horasTrabajadas = double.Parse(Console.ReadLine());

double totalSalario(double salarioHora, double horasTrabajadas)
{
    double salario = salarioHora * horasTrabajadas;
    return salario;
}

Console.WriteLine("el salario es " + totalSalario(salarioHora, horasTrabajadas));