Console.WriteLine("Ingrese la cantidad de días trabajados:");
int diasTrabajados = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el pago diario:");
double pagoDiario = double.Parse(Console.ReadLine());

double calcularSalario(int diasTrabajados, double pagoDiario)
{
    double salario = diasTrabajados * pagoDiario;
    return salario;
}

Console.WriteLine("El salario total del empleado es: " + calcularSalario(diasTrabajados, pagoDiario));
