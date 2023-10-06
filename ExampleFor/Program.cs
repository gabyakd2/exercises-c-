// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int cantidadNotasACargar = 0;
double promedioNotas = 0;
double nota;
double sumaNotas = 0;
int contadorAprobado = 0;
int contadorReprobado = 0;

Console.WriteLine("Ingrese cantidad de notas a cargar");
cantidadNotasACargar = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidadNotasACargar; i++)
{
    Console.WriteLine("Ingrese la nota:");
    nota = double.Parse(Console.ReadLine());
    sumaNotas += nota;
    if (nota >= 7)
    {
        contadorAprobado++;
    }
    else
    {
        contadorReprobado++;
    }
}

promedioNotas = sumaNotas / cantidadNotasACargar;

Console.WriteLine($"El promedio de las notas es: {promedioNotas}");
Console.WriteLine($"Aprobaron {contadorAprobado}");
Console.WriteLine($"Reprobaron {contadorReprobado}");
Console.ReadKey();